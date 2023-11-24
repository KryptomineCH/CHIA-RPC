using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// This class represents a coin in the Chia network. Each coin in Chia is a separate entity with its own characteristics.
    /// </summary>
    /// <remarks>
    /// The Coin class includes several properties that store information about the coin's value, the parent coin that was spent to create it, and its puzzle hash. 
    /// It also includes methods for calculating the coin's unique ID, which can be used to find it on blockchain explorers.
    /// </remarks>
    public class Coin : ObjectTemplate<Coin>
    {
        /// <summary>
        /// Represents the coin's value in mojos, where: <br/>
        /// - 1 Chia = 1e12 mojos. <see cref="GlobalVar.OneChiaInMojos"/>
        /// - 1 Ct = 1000 mojos. <see cref="GlobalVar.OneCatInMojos"/>
        /// </summary>
        /// <remarks>
        /// This property is used by both full node and wallet node in the Chia network.
        /// For more details, see: <see href="https://docs.chia.net/full-node-rpc#get_coin_record_by_name"/>
        /// </remarks>
        public ulong? amount { get { return _amount; }
            set
            {
                _CoinName = null; // invalidate coin name as amount was changed
                _amount = value;
            }
        }
        private ulong? _amount; // Backing field

        /// <summary>
        /// Represents the coin's value in Chia (XCH).
        /// </summary>
        /// <remarks>This value is derived from the mojos amount.</remarks>
        [JsonIgnore]
        public decimal? amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// Represents the coin's value in a CAT token.
        /// </summary>
        /// <remarks>This value is derived from the mojos amount.</remarks>
        [JsonIgnore]
        public decimal? amount_in_cat
        {
            get { return amount / GlobalVar.OneCatInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneCatInMojos); }
        }

        /// <summary>
        /// The puzzlehash of the parent coin that was spent to create this coin.
        /// </summary>
        public string? parent_coin_info { get { return _parent_coin_info; } 
            set
            {
                _CoinName = null; // invalidate CoinName since parent coin info changed
                _parent_coin_info = value;
            }
        }
        private string? _parent_coin_info;

        /// <summary>
        /// The puzzle hash of this coin.
        /// </summary>
        /// <remarks>
        /// When in the Mempool and for creation, the own puzzle hash can be unknown as the coin is yet to be minted.
        /// </remarks>
        public string? puzzle_hash { get { return _puzzle_hash; } set
            {
                _CoinName = null; // invalidate coin name since puzzhash changed
                _puzzle_hash = value;
            }
        }
        private string? _puzzle_hash;

        /// <summary>
        /// The name of the coin which can be used to find the coin on blockchain explorers.
        /// </summary>
        /// <remarks>
        /// Calls GetCoinID(); in the background
        /// </remarks>
        [JsonIgnore]
        public string? CoinName {
            get => _CoinName ??= GetCoinID(); // lazy load Coin ID
        }
        private string? _CoinName;

        // ============================
        // ############################
        //
        // Public utility functions
        // 
        // ############################
        // ============================

        /// <summary>
        /// Determines whether two specified Coin instances are equal.
        /// </summary>
        /// <remarks>
        /// WARNING: 0xhash != hash<br/>
        /// </remarks>
        /// <param name="coin1">The first Coin to compare.</param>
        /// <param name="coin2">The second Coin to compare.</param>
        /// <returns>true if coin1 and coin2 represent the same  amount, parent coin and puzzhash; otherwise, false.</returns>
        public static bool operator ==(Coin? coin1, Coin? coin2)
        {
            // Handle null on either side
            if (ReferenceEquals(coin1, null))
                return ReferenceEquals(coin2, null);

            return coin1.Equals(coin2);
        }

        /// <summary>
        /// Determines whether two specified Coin instances are not equal.
        /// </summary>
        /// <remarks>
        /// WARNING: 0xhash != hash<br/>
        /// </remarks>
        /// <param name="coin1">The first Coin to compare.</param>
        /// <param name="coin2">The second Coin to compare.</param>
        /// <returns>true if coin1 and coin2 do not represent the same amount, parent coin or puzzhash; otherwise, false.</returns>
        public static bool operator !=(Coin? coin1, Coin? coin2)
        {
            return !(coin1 == coin2);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current Coin.
        /// </summary>
        /// <remarks>
        /// WARNING: 0xhash != hash<br/>
        /// </remarks>
        /// <param name="obj">The object to compare with the current Coin.</param>
        /// <returns>true if the specified object represent the same amount, parent coin and puzzhash; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            // Return false if the passed object is null or isn't a Coin
            if (obj is not Coin otherCoin)
                return false;

            // Use your existing AreCoinsEqual method for comparison
            return AreCoinsEqual(this, otherCoin);
        }

        // ============================
        // ############################
        //
        // Private Utility Functions
        //
        // ############################
        // ============================

        /// <summary>
        /// checks if two coins are equal in an efficient manner
        /// </summary>
        /// <param name="coin1">the first coin to compare</param>
        /// <param name="coin2">the second coin to compare</param>
        /// <returns></returns>
        private static bool AreCoinsEqual(Coin coin1, Coin coin2)
        {
            // Compare amounts
            if (coin1.amount != coin2.amount)
            {
                return false;
            }
            // Compare parent_coin_info
            if (!HashCompare.AreHashesEqual(coin1.parent_coin_info, coin2.parent_coin_info))
            {
                return false;
            }

            // Compare puzzle_hash
            return HashCompare.AreHashesEqual(coin1.puzzle_hash, coin2.puzzle_hash);
        }

        /// <summary>
        /// <b>Use the CoinName property instead.</b>
        /// <br/><br/>
        /// Calculates the unique ID for the coin based on its properties.
        /// </summary>
        /// <remarks>
        /// This ID corresponds to the one found on blockchain explorers and is calculated by hashing the parent coin info, the puzzle hash and the amount.
        /// If any of these properties is null, the method returns null.
        /// </remarks>
        /// <returns>The unique ID of the coin as a string, or null if any of the properties required to calculate it is null.</returns>
        private string? GetCoinID()
        {
            if (amount == null || parent_coin_info == null || puzzle_hash == null)
            {
                return null;
            }

            byte[] parent_id_bytes = Convert.FromHexString(parent_coin_info![2..]);
            byte[] puzzle_hash_bytes = Convert.FromHexString(puzzle_hash![2..]);
            var amount_hex_string = ((ulong)amount).ToString("X");
            amount_hex_string = (amount_hex_string.Length % 2 == 0 ? "" : "0") + amount_hex_string;
            byte[] amount_bytes = Convert.FromHexString(amount_hex_string);

            byte[] bytes = parent_id_bytes.Concat(puzzle_hash_bytes).Concat(amount_bytes).ToArray();

            var hash = SHA256.Create();
            byte[] coin_id_bytes = hash.ComputeHash(bytes);
            string coin_id = "0x" + Convert.ToHexString(coin_id_bytes).ToLower();
            return coin_id;
        }
    }
}
