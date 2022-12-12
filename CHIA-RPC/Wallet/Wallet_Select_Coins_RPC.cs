using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.Wallet
{
    public class Wallet_Select_Coins_RPC
    {
        /// <summary>
        /// The ID of the wallet from which to select coins
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The number of mojos to select
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong amount { get; set; }
        /// <summary>
        /// The smallest coin to be selected in this query [Default: No minimum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong min_coin_amount { get; set; }
        /// <summary>
        /// The largest coin to be selected in this query [Default: No maximum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong max_coin_amount { get; set; }
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
        public static Wallet_Select_Coins_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            Wallet_Select_Coins_RPC rpc = JsonSerializer.Deserialize<Wallet_Select_Coins_RPC>(text);
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
