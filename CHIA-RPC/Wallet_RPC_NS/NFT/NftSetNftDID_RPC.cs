using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_RPC_NS.KeyManagement;
using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftSetNftDID_Response
    {
        public SpendBundle spend_bundle { get; set; }
        public ulong wallet_id { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class NftSetNftDID_RPC
    {
        /// <summary>
        /// The Wallet ID that holds the NFT on which to set the DID
        /// </summary>
        /// <remarks>
        /// mandatory
        /// </remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The coin ID of the NFT on which to set the DID
        /// </summary>
        /// <remarks>
        /// mandatory
        /// </remarks>
        public string nft_coin_id { get; set; }

        /// <summary>
        /// Optionally: DID to be associated with this NFT. 
        /// If this parameter is not specified, the DID will be Unassigned
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
        public string did_id { get; set; }

        /// <summary>
        /// optional: The one-time blockchain fee (in mojos) to be used upon adding a URI
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
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
        public static NftSetNftDID_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            NftSetNftDID_RPC rpc = JsonSerializer.Deserialize<NftSetNftDID_RPC>(text);
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
