using System.Text.Json;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{

    /// <summary>
    /// Represents a class that contains input parameters for the get_coin_records_by_puzzle_hashes RPC request.
    /// </summary>
    public class GetCoinRecordsByPuzzleHashes_RPC
    {
        /// <summary>
        /// Gets or sets the list of puzzle hashes to examine.
        /// </summary>
        public string puzzle_hashes { get; set; }
        /// <summary>
        /// Gets or sets the block height at which to begin the search.
        /// </summary>
        public ulong? start_height { get; set; }

        /// <summary>
        /// Gets or sets the block height at which to end the search.
        /// </summary>
        public ulong? end_height { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include spent coins.
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
        public static GetCoinRecordsByPuzzleHashes_RPC LoadRpcFromFile(string filePath)
        {
            return RpcFileManager.LoadObjectFromFile<GetCoinRecordsByPuzzleHashes_RPC>(filePath);
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
