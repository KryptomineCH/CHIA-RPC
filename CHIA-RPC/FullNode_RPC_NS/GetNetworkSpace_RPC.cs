using CHIA_RPC.HelperFunctions_NS;
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
        /// this boolean indicates wether the server accepted the request or not.
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// this string contains the error message when the server refused the request. This will only happen, when the server actually got reached.
        /// </summary>
        public string? error { get; set; }
        /// <summary>
        /// Saves the response to the specified file path with a ".response" file extension.
        /// </summary>
        /// <param name="filePath">The path to save the response to.</param>
        public void SaveResponseToFile(string filePath)
        {
            RpcFileManager.SaveObjectToFile(this, filePath, "response");
        }

        /// <summary>
        /// Loads a response from the specified file path.
        /// </summary>
        /// <param name="filePath">The path to load the response from.</param>
        /// <returns>The loaded response.</returns>
        public static GetNetworkSpace_Response LoadResponseFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetNetworkSpace_Response>(filePath);
        }

        /// <summary>
        /// Returns a JSON formatted string representing this object with indentation.
        /// </summary>
        /// <returns>A JSON formatted string representing this object with indentation.</returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
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
        /// Saves the RPC request to the specified file path.
        /// </summary>
        /// <param name="filePath">The path to save the RPC request to.</param>
        public void SaveRpcToFile(string filePath)
        {
            RpcFileManager.SaveObjectToFile(this, filePath);
        }

        /// <summary>
        /// Loads an RPC request from the specified file path.
        /// </summary>
        /// <param name="filePath">The path to load the RPC request from.</param>
        /// <returns>The loaded RPC request.</returns>
        public static GetNetworkSpace_Rpc LoadRpcFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetNetworkSpace_Rpc>(filePath);
        }

        /// <summary>
        /// Serializes this object into a JSON formatted string.
        /// </summary>
        /// <returns>A JSON formatted string representing this object.</returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = false });
        }
    }
}
