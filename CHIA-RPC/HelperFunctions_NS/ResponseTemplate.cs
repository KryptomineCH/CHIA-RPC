
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS
{
    public class ResponseTemplate<T>
    {
        /// <summary>
        /// this boolean indicates whether the server accepted and processed the request or not.
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// this string contains details about the error when the node refused the request or couldnt process it. 
        /// </summary>
        /// <remarks>
        /// This will only contain a value when the node actually received the request and actively refused it.
        /// </remarks>
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
        public static T LoadResponseFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<T>(filePath);
        }

        /// <summary>
        /// Loads a response from a json string (which the chia-node returned)
        /// </summary>
        /// <param name="inputString">The json payload to load the response from.</param>
        /// <returns>The loaded response.</returns>
        public static T LoadResponseFromString(string inputString)
        {
            return JsonSerializer.Deserialize<T>(inputString);
        }

        /// <summary>
        /// Returns a JSON formatted string representing this response with indentation.
        /// </summary>
        /// <returns>A JSON formatted string representing this response with indentation.</returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }

}
