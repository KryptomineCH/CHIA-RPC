
using CHIA_RPC.Objects_NS;
using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftCalculateRoyalties_Response
    {
        /// <summary>
        /// Dictionary to hold key-value pairs where key is the NFT coin id, and value is list of TradeData
        /// </summary>
        public Dictionary<string, List<TradeData>> NFTTrade { get; set; }

        /// <summary>
        /// Indicates if the operation was successful
        /// </summary>
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class NftCalculateRoyalties_RPC
    {
        /// <summary>
        /// A list of NFTs for which to calculate royalties
        /// </summary>
        public List<RoyaltyAsset> royalty_assets { get; set; }

        /// <summary>
        /// The assets against which to calculate royalties
        /// </summary>
        public List<FungibleAsset> fungible_assets { get; set; }
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
        public static NftCalculateRoyalties_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            NftCalculateRoyalties_RPC rpc = JsonSerializer.Deserialize<NftCalculateRoyalties_RPC>(text);
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
