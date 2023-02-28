using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Represents the response of a GetCoinRecordByName request.
    /// </summary>
    public class GetCoinRecordByName_Response
    {
        /// <summary>
        /// A CoinRecord object containing information about the retrieved coin.
        /// </summary>
        public CoinRecord coin_record { get; set; }
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
        public static GetCoinRecordByName_Response LoadResponseFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetCoinRecordByName_Response>(filePath);
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
    /// Represents the request for retrieving a coin record by its name or ID.
    /// </summary>
    public class GetCoinRecordByName_RPC
    {
        /// <summary>
        /// A string containing the name or ID of the coin to retrieve.
        /// </summary>
        public string name { get; set; }

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
        public static GetCoinRecordByName_RPC LoadRpcFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetCoinRecordByName_RPC>(filePath);
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
