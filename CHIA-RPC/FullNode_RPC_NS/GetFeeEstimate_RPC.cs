using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Contains information about the estimated Transaction Fees from the Chia Client
    /// </summary>
    public class GetFeeEstimate_Response
    {
        /// <summary>
        /// Current fee rate in mojos per byte.
        /// </summary>
        public ulong CurrentFeeRate { get; set; }

        /// <summary>
        /// Estimated fee for each targeted time in seconds.
        /// </summary>
        public ulong[] Estimates { get; set; }

        /// <summary>
        /// Whether or not the full node is synced.
        /// </summary>
        public bool FullNodeSynced { get; set; }

        /// <summary>
        /// Timestamp in seconds of the last peak.
        /// </summary>
        public ulong LastPeakTimestamp { get; set; }

        /// <summary>
        /// Maximum size of the mempool in bytes.
        /// </summary>
        public ulong MempoolMaxSize { get; set; }

        /// <summary>
        /// Current size of the mempool in bytes.
        /// </summary>
        public ulong MempoolSize { get; set; }

        /// <summary>
        /// The current UTC timestamp of the node.
        /// </summary>
        public ulong NodeTimeUTC { get; set; }

        /// <summary>
        /// The height of the last peak.
        /// </summary>
        public ulong PeakHeight { get; set; }

        /// <summary>
        /// Whether or not the RPC call was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Targeted times for transaction inclusion, in seconds.
        /// </summary>
        public ulong[] TargetTimes { get; set; }
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
        public static GetFeeEstimate_Response LoadResponseFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetFeeEstimate_Response>(filePath);
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
    /// Contains the request parameters for the get_fee_estimate RPC method. 
    /// Used to obtain an estimated fee for one or more targeted times for a transaction to be included in the blockchain.
    /// </summary>
    public class GetFeeEstimate_RPC
    {
        /// <summary>
        /// The spend bundle file (in json format) for which to estimate the fee. 
        /// Exactly one of spend_bundle or cost must be specified.
        /// </summary>
        /// <remarks>
        /// either spend_bundle or cost need to be specified
        /// </remarks>
        public string? spend_bundle { get; set; }

        /// <summary>
        /// The CLVM cost for which to estimate the fee. 
        /// Exactly one of spend_bundle or cost must be specified.
        /// </summary>
        /// <remarks>
        /// either spend_bundle or cost need to be specified
        /// </remarks>
        public ulong? cost { get; set; }

        /// <summary>
        /// An array of the targeted times for transaction inclusion, in seconds. 
        /// Each targeted time must be at least 0.
        /// </summary>
        public ulong[] target_times { get; set; }
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
        public static GetFeeEstimate_RPC LoadRpcFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetFeeEstimate_RPC>(filePath);
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
