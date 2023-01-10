using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftTransferNft_RPC
    {
        /// <summary>
        /// The Wallet ID of the NFT to transfer
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The address to transfer the NFT to. For NFT0 this must be an XCH address. For NFT1 this could also be a DID address
        /// </summary>
        public string target_address { get; set; }

        /// <summary>
        /// The coin ID of the NFT to transfer
        /// </summary>
        public string nft_coin_id { get; set; }

        /// <summary>
        /// The one-time blockchain fee (in mojos) to be used upon transferring the NFT
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
        public static NftTransferNft_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            NftTransferNft_RPC rpc = JsonSerializer.Deserialize<NftTransferNft_RPC>(text);
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
