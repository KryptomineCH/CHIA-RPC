using System.Text;
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS
{
    internal class RpcFileManager
    {
        /// <summary>
        /// Saves the provided serialized object to the specified file path with the specified file extension.
        /// </summary>
        /// <typeparam name="T">The type of object to serialize.</typeparam>
        /// <param name="obj">The object to serialize.</param>
        /// <param name="filePath">The path to save the file to.</param>
        /// <param name="fileExtension">The file extension to use.</param>
        internal static void SaveObjectToFile<T>(T obj, string filePath, string fileExtension = "rpc")
        {
            string serializedObject = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
            SaveStringToFile(serializedObject, filePath, fileExtension);
        }

        /// <summary>
        /// Loads an object from the specified file path.
        /// </summary>
        /// <typeparam name="T">The type of object to deserialize.</typeparam>
        /// <param name="filePath">The path to load the object from.</param>
        /// <returns>The loaded object.</returns>
        internal static T LoadObjectFromFile<T>(string filePath, string fileExtension = "rpc")
        {
            string serializedObject = LoadStringFromFile(filePath, fileExtension);
            return JsonSerializer.Deserialize<T>(serializedObject, new JsonSerializerOptions { AllowTrailingCommas = true });
        }

        /// <summary>
        /// Saves the provided string to the specified file path with the specified file extension.
        /// </summary>
        /// <param name="content">The string to save.</param>
        /// <param name="filePath">The path to save the string to.</param>
        /// <param name="fileExtension">The file extension to use.</param>
        internal static void SaveStringToFile(string content, string filePath, string fileExtension = "rpc")
        {
            if (!filePath.EndsWith("." + fileExtension))
            {
                filePath += "." + fileExtension;
            }
            Encoding utf8WithoutBom = new UTF8Encoding(false); // no bom
            File.WriteAllText(filePath, content, utf8WithoutBom);
        }

        /// <summary>
        /// Loads a string from the specified file path.
        /// </summary>
        /// <param name="filePath">The path to load the string from.</param>
        /// <returns>The loaded string.</returns>
        internal static string LoadStringFromFile(string filePath, string fileExtension = "rpc")
        {
            if (!filePath.EndsWith("." + fileExtension))
            {
                filePath += "." + fileExtension;
            }
            FileInfo fileInfo = new FileInfo(filePath);
            return File.ReadAllText(fileInfo.FullName);
        }
    }
}
