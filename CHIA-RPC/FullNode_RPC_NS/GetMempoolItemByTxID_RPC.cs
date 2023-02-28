using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Represents a response containing a mempool item retrieved by tx ID.
    /// </summary>
    public class GetMempoolItemByTxID_Response
    {
        /// <summary>
        /// Gets or sets the mempool item retrieved by tx ID.
        /// </summary>
        public MempoolItem mempool_item { get; set; }
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
        public static GetMempoolItemByTxID_Response LoadResponseFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetMempoolItemByTxID_Response>(filePath);
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
    /// Represents a request to retrieve a mempool item by tx ID.
    /// </summary>
    public class GetMempoolItemByTxID_RPC
    {
        /// <summary>
        /// Gets or sets the spend bundle hash (tx ID) of the mempool item to retrieve.
        /// </summary>
        public string tx_id { get; set; }

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
        public static GetMempoolItemByTxID_RPC LoadRpcFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetMempoolItemByTxID_RPC>(filePath);
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
