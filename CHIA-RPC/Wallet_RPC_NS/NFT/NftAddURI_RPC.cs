using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftAddURI_RPC
    {
        /// <summary>
        /// The Wallet ID of the DID wallet to transfer
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The coin ID of the NFT on which to add a URI
        /// </summary>
        public string nft_coin_id { get; set; }

        /// <summary>
        /// Key must be either "u" (data URI), "mu" (metadata URI), or "lu" (license URI)
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// The URI to add
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// The one-time blockchain fee (in mojos) to be used upon adding a URI
        /// </summary>
        public ulong fee { get; set; }
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
        public static NftAddURI_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            NftAddURI_RPC rpc = JsonSerializer.Deserialize<NftAddURI_RPC>(text);
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
