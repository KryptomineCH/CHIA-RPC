using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class SignMessage_Response
    {
        public string pubkey { get; set; }
        public string signature { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class SignMessageByAddress_RPC
    {
        /// <summary>
        /// The address to use for signing.Must possess the key for this address
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string address { get; set; }
        /// <summary>
        /// The message to include with the signature
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string message { get; set; }
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
        public static SignMessageByAddress_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            SignMessageByAddress_RPC rpc = JsonSerializer.Deserialize<SignMessageByAddress_RPC>(text);
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
