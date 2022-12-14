using System.Text.Json;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class GetSpendableCoins_Response
    {

        public CoinRecord[] confirmed_records { get; set; }
        public bool success { get; set; }
        public string[] unconfirmed_additions { get; set; }
        public string[] unconfirmed_removals { get; set; }
        public string error { get; set; }
    }
    public class GetSpendableCoins_RPC
    {
        /// <summary>
        /// The ID of the wallet from which to display coins
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The smallest coin to be selected in this query[Default: No minimum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// The largest coin to be selected in this query[Default: No maximum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; }
        /// <summary>
        /// A list of coin amounts to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong[] excluded_coin_amounts { get; set; }
        /// <summary>
        /// A list of coins to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public string[] excluded_coins { get; set; }
        /// <summary>
        /// A list of coin IDs to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public string[] excluded_coin_ids { get; set; }
        /// <summary>
        /// saves the rpc as rpc-file (json) to the specified path
        /// </summary>
        /// <param name="path"></param>
        public void Save(string path)
        {
            if (!path.EndsWith(".rpc"))
            {
                path += ".rpc";
            }
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            string testText = JsonSerializer.Serialize(this, options: options);
            Encoding utf8WithoutBom = new UTF8Encoding(false); // no bom
            File.WriteAllText(path, testText, utf8WithoutBom);
        }
        /// <summary>
        /// loads an rpc file from the specified path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static GetSpendableCoins_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            GetSpendableCoins_RPC rpc = JsonSerializer.Deserialize<GetSpendableCoins_RPC>(text);
            return rpc;
        }
        /// <summary>
        /// serializes this object into a json string
        /// </summary>
        /// <returns>json formatted string</returns>
        public override string ToString()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = false;
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            string jsonString = JsonSerializer.Serialize(this, options: options);
            return jsonString;
        }
    }
}
