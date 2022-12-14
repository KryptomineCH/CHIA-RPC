using System.Text.Json;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet
{
    public class ExtendDerivationIndex_Response
    {
        /// <summary>
        /// The derivation index is the minimum number of addresses the wallet will examine. It's not possible to decrease this number.
        /// </summary>
        public ulong index { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class ExtendDerivationIndex_RPC
    {
        /// <summary>
        /// The new derivation index. Must be larger than the previous index
        /// </summary>
        /// <remarks>The derivation index is the minimum number of addresses the wallet will examine. It's not possible to decrease this number.
        /// <br/>mandatory</remarks>
        [Required]
        public ulong index { get; set; }
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
        public static ExtendDerivationIndex_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            ExtendDerivationIndex_RPC rpc = JsonSerializer.Deserialize<ExtendDerivationIndex_RPC>(text);
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
