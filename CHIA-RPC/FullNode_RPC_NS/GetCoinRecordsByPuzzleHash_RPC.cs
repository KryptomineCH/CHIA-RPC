using System.Text.Json;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{

    /// <summary>
    /// Class to retrieve a list of coin records with a certain puzzle hash.
    /// </summary>
    public class GetCoinRecordsByPuzzleHash_RPC
    {
        /// <summary>
        /// Puzzle hash to search for.
        /// </summary>
        public string puzzle_hash { get; set; }

        /// <summary>
        /// Confirmation start height for search. Optional parameter.
        /// </summary>
        public ulong? start_height { get; set; }

        /// <summary>
        /// Confirmation end height for search. Optional parameter.
        /// </summary>
        public ulong? end_height { get; set; }

        /// <summary>
        /// Whether to include spent coins too, instead of just unspent. Defaults to false.
        /// </summary>
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
        public static GetCoinRecordsByPuzzleHash_RPC LoadRpcFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetCoinRecordsByPuzzleHash_RPC>(filePath);
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
