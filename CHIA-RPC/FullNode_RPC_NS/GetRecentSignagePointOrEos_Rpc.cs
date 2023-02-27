using CHIA_RPC.Objects_NS;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{

    /// <summary>
    /// Warning: Gets a list of full blocks by height. Important note: there might be multiple blocks at each height. To find out which one is in the blockchain, use get_block_record_by_height.
    /// </summary>
    public class GetRecentSignagePointOrEos_Rpc
    {
        /// <summary>
        /// 
        /// </summary>
        public string sp_hash { get; set; }
        public string challenge_hash { get; set; }

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
        public static GetRecentSignagePointOrEos_Rpc Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            GetRecentSignagePointOrEos_Rpc rpc = JsonSerializer.Deserialize<GetRecentSignagePointOrEos_Rpc>(text);
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
