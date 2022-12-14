using CHIA_RPC.Objects;
using CHIA_RPC.Wallet_RPC_NS.Wallet;
using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    public class PushTx_Response
    {
        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// SUCCESS: if the transaction was successfully added to the mempool
        /// </item>
        /// <item>
        /// PENDING: if the transaction cannot be included yes due to timelocks or conflicts
        /// </item>
        /// <item>
        /// FAILED: transaction was not added to the mempool, and was dropped
        /// </item>
        /// </list>
        /// </summary>
        public string status { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class PushTx_RPC
    {
        public SpendBundle spend_bundle { get; set; }
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
        public static PushTx_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            PushTx_RPC rpc = JsonSerializer.Deserialize<PushTx_RPC>(text);
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
