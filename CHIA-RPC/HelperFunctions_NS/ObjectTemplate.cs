﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace CHIA_RPC.HelperFunctions_NS
{
    /// <summary>
    /// this class is the base class for Object classes. It contains some functions for IO and Serialisation/Deserialisation
    /// </summary>
    /// <remarks>
    /// An abstract class is a class that cannot be instantiated on its own, but instead is meant to be used as a base class for other classes. 
    /// </remarks>
    /// <typeparam name="T"> 
    /// This constraint ensures that the T type parameter represents a class that inherits from the ObjectTemplate&lt;T&gt; base class. 
    /// This is known as a recursive type constraint, because it constrains the type parameter to be related to the base class in a recursive way.
    /// By using this recursive type constraint, 
    /// you can ensure that any derived classes of ObjectTemplate&lt;T&gt; can use this as T to cast the base class to the derived class in order to properly serialize it using the JsonSerializer.
    /// </typeparam>
    public abstract class ObjectTemplate<T> where T : ObjectTemplate<T>
    {
        /// <summary>
        /// The raw response of the server
        /// </summary>
        [JsonIgnore]
        public string? RawContent { get; set; }
        /// <summary>
        /// May contain error message from serialisation/deserialisation
        /// </summary>
        [JsonIgnore]
        public string? error { get; set; }
        /// <summary>
        /// Saves the RPC to the specified file path with a ".rpc" file extension.
        /// </summary>
        /// <remarks>
        /// always assumes and appends the filetype
        /// </remarks>
        /// <param name="filePath">The path to save the RPC request to.</param>
        public void SaveObjectToFile(string filePath)
        {
            string extension = "."+typeof(T).Name.ToLower();
            FileManager.SaveObjectToFile(this as T, filePath, extension);
        }
        /// <summary>
        /// Saves the RPC to the specified file path with a ".rpc" file extension.
        /// </summary>
        /// <remarks>
        /// always assumes and appends the filetype
        /// </remarks>
        /// <param name="file">The path to save the RPC request to.</param>
        public void SaveObjectToFile(FileInfo file)
        {
            SaveObjectToFile(file.FullName);
        }
        /// <summary>
        /// checks if the file exists on disk
        /// </summary>
        /// <param name="filePath">the path of the file (preferrably without extension)</param>
        /// <returns></returns>
        public static bool FileExists(string filePath)
        {
            string extension = "." + typeof(T).Name.ToLower();
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
        /// Loads an RPC request from the specified file path.
        /// </summary>
        /// <remarks>
        /// always assumes the filetype
        /// </remarks>
        /// <param name="filePath">The path to load the RPC request from.</param>
        /// <returns>The loaded RPC request.</returns>
        public static T LoadObjectFromFile(string filePath)
        {
            string extension = "." + typeof(T).Name.ToLower();
            return FileManager.LoadObjectFromFile<T?>(filePath, extension);
        }
        /// <summary>
        /// Loads an RPC request from the specified file path.
        /// </summary>
        /// <remarks>
        /// always assumes the filetype
        /// </remarks>
        /// <param name="file">The path to load the RPC request from.</param>
        /// <returns>The loaded RPC request.</returns>
        public static T LoadObjectFromFile(FileInfo file)
        {
            return LoadObjectFromFile(file.FullName);
        }

        /// <summary>
        /// Loads an RPC from a json formatted string
        /// </summary>
        /// <param name="inputString">The json formatted string to load the RPC from.</param>
        /// <returns>The loaded RPC</returns>
        public static ActionResult<T> LoadObjectFromString(string inputString)
        {
            ActionResult<T> result = new ActionResult<T>(inputString);
            result.RawJson = inputString;
            if (string.IsNullOrEmpty(inputString))
            {
                result.Success = false;
                if (inputString == "") result.Error = "Could not convert Response from empty string!";
                else result.Error = "Could not convert Response from null string!";
                return result;
            }
            var options = new JsonSerializerOptions();
            options.AllowTrailingCommas = true;
            options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            options.Converters.Add(new BigIntegerConverter());
            try
            {
                result.Data = JsonSerializer.Deserialize<T?>(inputString, options);
                if (result.Data == null)
                {
                    result.Success = false;
                    result.Error = "Json Deserialisation resulted in null!";
                }
                else
                {
                    result.Success = true;
                    result.Error = result.Data.error;
                }
            }
            catch (JsonException ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// Returns a JSON formatted string representing this RPC with indentation.
        /// </summary>
        /// <returns>A JSON formatted string representing this RPC with indentation.</returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this as T, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
