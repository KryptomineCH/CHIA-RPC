using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS
{
    public class RPCTemplate<T>
    {
        /// <summary>
        /// Saves the RPC to the specified file path with a ".rpc" file extension.
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
        public static T LoadRpcFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<T>(filePath);
        }

        /// <summary>
        /// Loads an RPC from a json formatted string
        /// </summary>
        /// <param name="inputString">The json formatted string to load the RPC from.</param>
        /// <returns>The loaded RPC</returns>
        public static T LoadRpcFromString(string inputString)
        {
            return JsonSerializer.Deserialize<T>(inputString);
        }

        /// <summary>
        /// Returns a JSON formatted string representing this RPC with indentation.
        /// </summary>
        /// <returns>A JSON formatted string representing this RPC with indentation.</returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
