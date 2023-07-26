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
        public ulong? amount { get; set; }

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
        /// The puzzlehash of the parent coin that was spent to create this coin.
        /// </summary>
        public string? parent_coin_info { get; set; }

        /// <summary>
        /// The puzzle hash of this coin.
        /// </summary>
        /// <remarks>
        /// When in the Mempool and for creation, the own puzzle hash can be unknown as the coin is yet to be minted.
        /// </remarks>
        public string? puzzle_hash { get; set; }

        /// <summary>
        /// The name of the coin which can be used to find the coin on blockchain explorers.
        /// </summary>
        [JsonIgnore]
        public string? CoinName { get { return GetCoinID(); } }

        /// <summary>
        /// Calculates the unique ID for the coin based on its properties.
        /// </summary>
        /// <remarks>
        /// This ID corresponds to the one found on blockchain explorers and is calculated by hashing the parent coin info, the puzzle hash and the amount.
        /// If any of these properties is null, the method returns null.
        /// </remarks>
        /// <returns>The unique ID of the coin as a string, or null if any of the properties required to calculate it is null.</returns>
        public string? GetCoinID()
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
