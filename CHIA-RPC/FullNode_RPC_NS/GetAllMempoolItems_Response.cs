using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Represents the response for the Get_All_Mempool_Items API call, which returns all items in the mempool.
    /// </summary>
    public class GetAllMempoolItems_Response
    {
        /// <summary>
        /// Array of mempool items.
        /// </summary>
        public MempoolItem[] mempool_items { get; set; }
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
        public static GetAllMempoolItems_Response LoadResponseFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetAllMempoolItems_Response>(filePath);
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
}
