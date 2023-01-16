using System.Security.Cryptography;

namespace CHIA_RPC.Objects_NS
{
    public class Coin
    {
        /// <summary>
        /// the coins value in mojos
        /// </summary>
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
