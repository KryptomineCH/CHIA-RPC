
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CHIA_RPC.HelperFunctions_NS
{
    public interface IResponseTemplate
    {
        // Properties that are common to all ResponseTemplates
        string? error { get; set; }
        string? RawContent { get; set; }
        // ... other common properties and methods
    }
    /// <summary>
    /// this class is the base class for Response classes. It contains some functions for IO and Serialisation/Deserialisation.
    /// It also contains the base properties success and error which are part of every node response.
    /// </summary>
    /// <remarks>
    /// An abstract class is a class that cannot be instantiated on its own, but instead is meant to be used as a base class for other classes. 
    /// </remarks>
    /// <typeparam name="T">
    /// this constraint ensures that the T type parameter represents a class that inherits from the ResponseTemplate T base class. 
    /// This is known as a recursive type constraint, because it constrains the type parameter to be related to the base class in a recursive way.
    /// By using this recursive type constraint, 
    /// you can ensure that any derived classes of ResponseTemplate T can use this as T to cast the base class to the derived class in order to properly serialize it using the JsonSerializer.
    /// </typeparam>
    public abstract class ResponseTemplate<T> : IResponseTemplate where T : ResponseTemplate<T>, new()
    {
        /// <summary>
        /// the raw response of the server
        /// </summary>
        [JsonIgnore]
        public string? RawContent { get; set; }
        /// <summary>
        /// this boolean indicates whether the server accepted and processed the request or not.
        /// </summary>
        public bool? success { get; set; }

        /// <summary>
        /// this string contains details about the error when the node refused the request or couldnt process it. 
        /// </summary>
        /// <remarks>
        /// This will only contain a value when the node actually received the request and actively refused it.
        /// </remarks>
        public string? error { get; set; }
        /// <summary>
        /// checks if the file exists on disk
        /// </summary>
        /// <param name="filePath">the path of the file (preferrably without extension)</param>
        /// <returns></returns>
        public static bool FileExists(string filePath)
        {
            string extension = ".response";
            return File.Exists(filePath);
        }
        /// <summary>
        /// checks if the file exists on disk
        /// </summary>
        /// <param name="file">the file (preferrably without extension)</param>
        /// <returns></returns>
        public static bool FileExists(FileInfo file)
        {
            return FileExists(file.FullName);
        }
        /// <summary>
        /// Saves the response to the specified file path with a ".response" file extension.
        /// </summary>
        /// <remarks>
        /// always assumes and appends the file type
        /// </remarks>
        /// <param name="filePath">The path to save the response to.</param>
        public void SaveResponseToFile(string filePath)
        {
            FileManager.SaveObjectToFile(this as T, filePath, "response");
        }
        /// <summary>
        /// Saves the response to the specified file path with a ".response" file extension.
        /// </summary>
        /// <remarks>
        /// always assumes and appends the file type
        /// </remarks>
        /// <param name="file">The path to save the response to.</param>
        public void SaveResponseToFile(FileInfo file)
        {
            SaveResponseToFile(file.FullName);
        }

        /// <summary>
        /// Loads a response from the specified file path.
        /// </summary>
        /// <remarks>
        /// always assumes and appends the file type
        /// </remarks>
        /// <param name="filePath">The path to load the response from.</param>
        /// <returns>The loaded response.</returns>
        public static T? LoadResponseFromFile(string filePath)
        {
            return FileManager.LoadObjectFromFile<T?>(filePath, "response");
        }
        /// <summary>
        /// Loads a response from the specified file path.
        /// </summary>
        /// <remarks>
        /// always assumes and appends the file type
        /// </remarks>
        /// <param name="file">The path to load the response from.</param>
        /// <returns>The loaded response.</returns>
        public static T LoadResponseFromFile(FileInfo file)
        {
            return LoadResponseFromFile(file);
        }

        /// <summary>
        /// Loads a response from a json string (which the chia-node returned)
        /// </summary>
        /// <param name="inputString">The json payload to load the response from.</param>
        /// <returns>The loaded response.</returns>
        public static T? LoadResponseFromString(string inputString)
        {
            if (inputString == "") return (T?)Activator.CreateInstance(typeof(T));
            T? result;
            try
            {
                result = JsonSerializer.Deserialize<T?>(inputString, new JsonSerializerOptions { AllowTrailingCommas = true });
            }
            catch (JsonException ex)
            {
                result = new T();
                result.success = false;
                result.error = ex.Message;
            }
            if (result == null) result = new T();
            result.RawContent = inputString;
            return result;
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
