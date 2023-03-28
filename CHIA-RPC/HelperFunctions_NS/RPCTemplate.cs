using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS
{
    /// <summary>
    /// this class is the base class for RPC classes. It contains some functions for IO and Serialisation/Deserialisation
    /// </summary>
    /// <remarks>
    /// An abstract class is a class that cannot be instantiated on its own, but instead is meant to be used as a base class for other classes. 
    /// </remarks>
    /// <typeparam name="T"> 
    /// this constraint ensures that the T type parameter represents a class that inherits from the RPCTemplate<T> base class. 
    /// This is known as a recursive type constraint, because it constrains the type parameter to be related to the base class in a recursive way.
    /// By using this recursive type constraint, 
    /// you can ensure that any derived classes of RPCTemplate<T> can use this as T to cast the base class to the derived class in order to properly serialize it using the JsonSerializer.
    /// </typeparam>
    public abstract class RPCTemplate<T> where T : RPCTemplate<T>, new()
    {
        /// <summary>
        /// Saves the RPC to the specified file path with a ".rpc" file extension.
        /// </summary>
        /// <param name="filePath">The path to save the RPC request to.</param>
        public void SaveRpcToFile(string filePath)
        {
            RpcFileManager.SaveObjectToFile(this as T, filePath);
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
            if (inputString == "") return (T)Activator.CreateInstance(typeof(T));
            return JsonSerializer.Deserialize<T>(inputString,new JsonSerializerOptions { AllowTrailingCommas = true});
        }

        /// <summary>
        /// Returns a JSON formatted string representing this RPC with indentation.
        /// </summary>
        /// <returns>A JSON formatted string representing this RPC with indentation.</returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this as T, new JsonSerializerOptions { WriteIndented = false });
        }
    }
}
