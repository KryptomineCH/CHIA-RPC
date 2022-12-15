
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_RPC_NS.Wallet;
using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.WalletManagement_NS
{
    public class GetWallets_Response
    {
        public ulong fingerprint { get; set; }
        public bool success { get; set; }
        public Wallets_info[] wallets { get; set; }
        public string error { get; set; }
    }
    public class Wallets_info
    {
        public string data { get; set; }
        public ulong id { get; set; }
        public string name { get; set; }
        public WalletType type { get; set; }
    }
    public class GetWallets_RPC
    {
        /// <summary>
        /// Set to true to include all coin info for this wallet [Default: true]
        /// </summary>
        public bool include_data { get; set; }
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
        public static GetWallets_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            GetWallets_RPC rpc = JsonSerializer.Deserialize<GetWallets_RPC>(text);
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
