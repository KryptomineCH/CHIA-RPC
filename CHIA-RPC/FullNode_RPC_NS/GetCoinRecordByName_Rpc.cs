using CHIA_RPC.Objects_NS;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    public class GetCoinRecordByName_Response
    {
        public CoinRecord coin_record { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    /// <summary>
    /// finds a coin record in the blockchain. 
    /// Warning: This is barely useful, since it does not include spent coins!
    /// </summary>
    public class GetCoinRecordByName_RPC
    {
        /// <summary>
        /// A list of coin names from which to retrieve records
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string name { get; set; }

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
        public static GetCoinRecordByName_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            GetCoinRecordByName_RPC rpc = JsonSerializer.Deserialize<GetCoinRecordByName_RPC>(text);
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
