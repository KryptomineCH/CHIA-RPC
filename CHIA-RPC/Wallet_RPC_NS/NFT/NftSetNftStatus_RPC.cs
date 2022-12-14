using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftSetNftStatus_RPC
    {
        /// <summary>
        /// The ID of an NFT wallet
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The coin_id of the NFT on which to set the status
        /// </summary>
        /// <remarks>
        /// eg: 
        /// </remarks>
        public string coin_id { get; set; }

        /// <summary>
        /// A boolean to set the transaction status for the NFT
        /// </summary>
        public bool in_transaction { get; set; }

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
        public static NftSetNftStatus_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            NftSetNftStatus_RPC rpc = JsonSerializer.Deserialize<NftSetNftStatus_RPC>(text);
            return rpc;
        }
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
