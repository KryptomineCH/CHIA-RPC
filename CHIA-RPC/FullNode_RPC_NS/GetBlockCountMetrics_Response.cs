
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// various metrics for the blockchain's blocks. Currently shows:
    /// compact blocks
    /// hint count
    /// uncompact blocks
    /// </summary>
    public class GetBlockCountMetrics_Response
    {
        /// <summary>
        /// An object that contains the metric values
        /// </summary>
        public Metrics metrics { get; set; }

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
        public static GetBlockCountMetrics_Response LoadResponseFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetBlockCountMetrics_Response>(filePath);
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
    /// An object that contains the metric values
    /// </summary>
    public class Metrics
    {
        /// <summary>
        /// The number of compact blocks
        /// </summary>
        public ulong compact_blocks { get; set; }

        /// <summary>
        /// The number of hint counts
        /// </summary>
        public ulong hint_count { get; set; }

        /// <summary>
        /// The number of uncompact blocks
        /// </summary>
        public ulong uncompact_blocks { get; set; }
    }
}
