using CHIA_RPC.HelperFunctions_NS;
using System.Security.Cryptography;

namespace CHIA_RPC.Objects_NS
{
    public class Coin : ObjectTemplate<Coin>
    {
        /// <summary>
        /// the coins value in mojos
        /// </summary>
        /// <remarks>
        /// used by full node and wallet node<br/>
        /// <see href="https://docs.chia.net/full-node-rpc#get_coin_record_by_name"/>
        /// </remarks>
        public ulong amount { get; set; }
        public string parent_coin_info { get; set; }
        public string puzzle_hash { get; set; }
        public string GetCoinID()
        {
            // convert values to bytes
            byte[] parent_id_bytes = Convert.FromHexString(parent_coin_info[2..]);
            byte[] puzzle_hash_bytes = Convert.FromHexString(puzzle_hash[2..]);
            var amount_hex_string = amount.ToString("X");
            // add leading zero if needed
            amount_hex_string = (amount_hex_string.Length % 2 == 0 ? "" : "0") + amount_hex_string;
            byte[] amount_bytes = Convert.FromHexString(amount_hex_string);

            // concat all to one bytes array
            byte[] bytes = parent_id_bytes.Concat(puzzle_hash_bytes).Concat(amount_bytes).ToArray();

            var hash = SHA256.Create();
            byte[] coin_id_bytes = hash.ComputeHash(bytes);
            string coin_id = "0x"+Convert.ToHexString(coin_id_bytes).ToLower();
            return coin_id;
        }
    }
}
