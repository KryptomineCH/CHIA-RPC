using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class GetNextAddress_Response
    {
        /// <summary>
        /// chia adress, eg <br/>
        /// xch1jxe8yfq8xem0e8ty5dq9hp86ududys96n6ugy2q4fextr0pplw9qwpfru9
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// the wallet number which this request was made for (eg. 2)
        /// </summary>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// wether the request against the chia daemon was sucessful or not
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// if there was an error, this will contain the error message
        /// </summary>
        public string error { get; set; }
    }
    public class GetNextAddress_RPC
    {
        /// <summary>
        /// the wallet number of the wallet in the chia client (eg. 2)
        /// </summary>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// specifies if a new address should be generated or the last one used
        /// </summary>
        public bool new_address { get; set; }
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
        public static GetNextAddress_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            GetNextAddress_RPC rpc = JsonSerializer.Deserialize<GetNextAddress_RPC>(text);
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
