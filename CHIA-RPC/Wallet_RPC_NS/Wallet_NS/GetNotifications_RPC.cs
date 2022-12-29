using System.Text.Json;
using System.Text;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class GetNotifications_Response
    {
        public Notification[] notifications { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class GetNotifications_RPC
    {
        /// <summary>
        /// Set to receive notifications only from the specified IDs. [Default: receive from all IDs]
        /// </summary>
        /// <remarks>optional</remarks>
        public string ids { get; set; }
        /// <summary>
        /// The number corresponding to the first notification to list. [Default: the first notification]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong start { get; set; }
        /// <summary>
        /// The number corresponding to the last notification to list. [Default: the last notification]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong end { get; set; }
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
        public static GetNotifications_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            GetNotifications_RPC rpc = JsonSerializer.Deserialize<GetNotifications_RPC>(text);
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
