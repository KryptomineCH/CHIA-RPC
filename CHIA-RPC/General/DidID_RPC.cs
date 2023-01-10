using System.Text.Json;
using System.Text;

namespace CHIA_RPC.General
{
    public class DidID_Response
    {
        /// <summary>
        /// eg:<br/>
        /// did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </summary>
        public string did_id { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class DidID_RPC
    {
        /// <summary>
        /// The Wallet ID of the wallet from which to obtain the balance
        /// </summary>
        /// <remarks>eg:<br/>
        /// did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </remarks>
        public string did_id { get; set; }
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
        public static DidID_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            DidID_RPC rpc = JsonSerializer.Deserialize<DidID_RPC>(text);
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
