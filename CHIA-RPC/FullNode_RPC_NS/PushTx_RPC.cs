using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// this enum is beeing used in PushTx response and indicates wether the Transaction was pushed to Mempool successfully
    /// </summary>
    public enum TransactionStatus
    {
        SUCCESS,
        PENDING,
        FAILED
    }
    /// <summary>
    /// This class represents the response received after pushing a transaction to the mempool.
    /// </summary>
    public class PushTx_Response
    {
        /// <summary>
        /// the Status indicates wether the transaction was pushed to the Mempool successfully
        /// </summary>
        public TransactionStatus status { get; set; }
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
        public static PushTx_Response LoadResponseFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<PushTx_Response>(filePath);
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
    /// Represents an RPC request to push a transaction to the blockchain.
    /// </summary>
    public class PushTx_RPC
    {
        /// <summary>
        /// The SpendBundle to be included in the transaction.
        /// </summary
        public SpendBundle spend_bundle { get; set; }

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
        public static PushTx_RPC LoadRpcFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<PushTx_RPC>(filePath);
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
