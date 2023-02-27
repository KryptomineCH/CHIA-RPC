using CHIA_RPC.Objects_NS;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Retrieves an estimate of the netspace, which is the total plotted space of all farmers, in bytes.
    /// </summary>
    public class GetNetworkSpace_Response
    {
        /// <summary>
        /// the network space in bytes
        /// </summary>
        public ulong space { get; set; }
        /// <summary>
        /// the netspace, calculated in petabytes
        /// <remarks>calculated on demand with binary prefix (/1024^5)</remarks>
        /// </summary>
        public decimal space_pb { get
            {
                return space / 1099511627776m;
            }
        }
        /// <summary>
        /// the netspace, calculated in exobytes
        /// <remarks>calculated on demand with binary prefix (/1024^6)</remarks>
        /// </summary>
        public decimal space_eb
        {
            get
            {
                return space / 1152921504606846976m;
            }
        }
        /// <summary>
        /// the netspace, calculated in zettabytes
        /// <remarks>calculated on demand with binary prefix (/1024^7)</remarks>
        /// </summary>
        public decimal space_zb
        {
            get
            {
                return space / 1152921504606846976000m;
            }
        }
        /// <summary>
        /// the netspace, calculated in yottabytes
        /// <remarks>calculated on demand with binary prefix (/1024^8)</remarks>
        /// </summary>
        public decimal space_yb
        {
            get
            {
                return space / 1152921504606846976000000m;
            }
        }

        /// <summary>
        /// the netspace, calculated in brontobytes
        /// <remarks>calculated on demand with binary prefix (/1024^9)</remarks>
        /// </summary>
        public decimal space_bb
        {
            get
            {
                return space / 1152921504606846976000000000m;
            }
        }
        /// <summary>
        /// indicates wether the server accepted the request
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// if the server refused the request, it will add an error here
        /// </summary>
        public string error { get; set; }
    }
    /// <summary>
    /// Retrieves the info about the net space (total space allocated by farmers)
    /// </summary>
    public class GetNetworkSpace_Rpc
    {
        /// <summary>
        /// the start header hash
        /// </summary>
        public string older_block_header_hash { get; set; }
        /// <summary>
        /// the end header hash
        /// </summary>
        public string newer_block_header_hash { get; set; }

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
        public static GetNetworkSpace_Rpc Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            GetNetworkSpace_Rpc rpc = JsonSerializer.Deserialize<GetNetworkSpace_Rpc>(text);
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
