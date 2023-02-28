using System.Text.Json;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General
{

    public class GetCoinRecordsByHint_RPC
    {
        /// <summary>
        /// The hint to examine
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string hint { get; set; }
        /// <summary>
        /// The block height at which to start the query
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? start_height { get; set; }
        /// <summary>
        /// The block height at which to end the query
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? end_height { get; set; }
        /// <summary>
        /// Include spent coins in the result[Default: false]
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? include_spent_coins { get; set; }

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
        public static GetCoinRecordsByHint_RPC LoadRpcFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetCoinRecordsByHint_RPC>(filePath);
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
