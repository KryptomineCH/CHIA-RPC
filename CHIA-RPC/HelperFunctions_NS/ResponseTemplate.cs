
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS
{
    /// <summary>
    /// this class is the base class for Response classes. It contains some functions for IO and Serialisation/Deserialisation.
    /// It also contains the base properties success and error which are part of every node response.
    /// </summary>
    /// <remarks>
    /// An abstract class is a class that cannot be instantiated on its own, but instead is meant to be used as a base class for other classes. 
    /// </remarks>
    /// <typeparam name="T">
    /// this constraint ensures that the T type parameter represents a class that inherits from the ResponseTemplate<T> base class. 
    /// This is known as a recursive type constraint, because it constrains the type parameter to be related to the base class in a recursive way.
    /// By using this recursive type constraint, 
    /// you can ensure that any derived classes of ResponseTemplate<T> can use this as T to cast the base class to the derived class in order to properly serialize it using the JsonSerializer.
    /// </typeparam>
    public abstract class ResponseTemplate<T> where T : ResponseTemplate<T>, new()
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
            RpcFileManager.SaveObjectToFile(this as T, filePath, "response");
        }

        /// <summary>
        /// Loads a response from the specified file path.
        /// </summary>
        /// <param name="filePath">The path to load the response from.</param>
        /// <returns>The loaded response.</returns>
        public static T LoadResponseFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<T>(filePath, "response");
        }

        /// <summary>
        /// Loads a response from a json string (which the chia-node returned)
        /// </summary>
        /// <param name="inputString">The json payload to load the response from.</param>
        /// <returns>The loaded response.</returns>
        public static T LoadResponseFromString(string inputString)
        {
            if (inputString == "") return (T)Activator.CreateInstance(typeof(T));
            return JsonSerializer.Deserialize<T>(inputString, new JsonSerializerOptions { AllowTrailingCommas = true });
        }

        /// <summary>
        /// Returns a JSON formatted string representing this response with indentation.
        /// </summary>
        /// <returns>A JSON formatted string representing this response with indentation.</returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this as T, new JsonSerializerOptions { WriteIndented = true });
        }
    }

}
