using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Warning: Gets a list of full blocks by height. 
    /// </summary>
    /// <remarks>
    /// Important note: there might be multiple blocks at each height. 
    /// To find out which one is in the blockchain, use get_block_record_by_height.
    /// </remarks>
    public class GetRecentSignagePointOrEos_Rpc
    {
        /// <summary>
        /// Gets or sets the hash of the output for a signage point (if it's in the middle of a sub slot).
        /// </summary>
        public string sp_hash { get; set; }
        /// <summary>
        /// Gets or sets the challenge_hash for the subslot (if it's an end of sub slot challenge).
        /// </summary>
        public string challenge_hash { get; set; }

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
        public static GetRecentSignagePointOrEos_Rpc LoadRpcFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetRecentSignagePointOrEos_Rpc>(filePath);
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
