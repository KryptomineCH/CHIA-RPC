using System.Text.Json;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CHIA_RPC.General
{

    public class GetCoinRecordsByHint_RPC
    {
        /// <summary>
        /// The hint to examine
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string hint { get; set; }
        /// <summary>
        /// The block height at which to start the query
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? start_height { get; set; }
        /// <summary>
        /// The block height at which to end the query
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? end_height { get; set; }
        /// <summary>
        /// Include spent coins in the result[Default: false]
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? include_spent_coins { get; set; }
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
        public static GetCoinRecordsByHint_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            GetCoinRecordsByHint_RPC rpc = JsonSerializer.Deserialize<GetCoinRecordsByHint_RPC>(text);
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
