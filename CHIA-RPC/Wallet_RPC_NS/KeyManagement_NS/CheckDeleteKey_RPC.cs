using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    public class CheckDeleteKey_Response
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
        /// <summary>
        /// farm rewards go to this wallet
        /// </summary>
        public bool used_for_farmer_rewards { get; set; }
        /// <summary>
        /// pool rewards go to this wallet
        /// </summary>
        public bool used_for_pool_rewards { get; set; }
        /// <summary>
        /// wallet still contains a balance
        /// </summary>
        public bool wallet_balance { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class CheckDeleteKey_RPC
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong fingerprint { get; set; }
        /// <summary>
        /// The maximum number of puzzle hashes to search [Default: 100]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong max_ph_to_search { get; set; }
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
        public static CheckDeleteKey_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            CheckDeleteKey_RPC rpc = JsonSerializer.Deserialize<CheckDeleteKey_RPC>(text);
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
