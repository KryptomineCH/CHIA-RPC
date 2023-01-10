using System.Text.Json;
using System.Text;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftGetInfo_Response
    {
        public Nft nft_info { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class NftGetInfo_RPC
    {
        /// <summary>
        /// The coin ID of the NFT about which to retrieve info
        /// </summary>
        /// <remarks>eg: 0x821fdd13fe209466f1c69d82eb951cf630d28e901c2e14285d8a574dbde034c4</remarks>
        public string coin_id { get; set; }

        /// <summary>
        /// The Wallet ID of the NFT from which to retrieve info
        /// </summary>
        public ulong wallet_id { get; set; }
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
        public static NftGetInfo_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            NftGetInfo_RPC rpc = JsonSerializer.Deserialize<NftGetInfo_RPC>(text);
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
