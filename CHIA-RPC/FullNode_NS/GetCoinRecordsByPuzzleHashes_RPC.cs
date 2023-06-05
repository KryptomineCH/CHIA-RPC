using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{

    /// <summary>
    /// Represents a class that contains input parameters for the get_coin_records_by_puzzle_hashes RPC request.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_puzzle_hashes"/></remarks>
    /// <returns><see cref="General_NS.GetCoinRecords_Response"/></returns>
    public class GetCoinRecordsByPuzzleHashes_RPC : RPCTemplate<GetCoinRecordsByPuzzleHashes_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public GetCoinRecordsByPuzzleHashes_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents a class that contains input parameters for the get_coin_records_by_puzzle_hashes RPC request.
        /// </summary>
        /// <param name="puzzle_hashes">Gets or sets the list of puzzle hashes to examine.</param>
        /// <param name="start_height">Gets or sets the block height at which to begin the search.</param>
        /// <param name="end_height">Gets or sets the block height at which to end the search.</param>
        /// <param name="include_spent_coins">Gets or sets a value indicating whether to include spent coins.</param>
        public GetCoinRecordsByPuzzleHashes_RPC(string[] puzzle_hashes, ulong? start_height = null, ulong? end_height = null, bool? include_spent_coins = true)
        {
            this.puzzle_hashes = puzzle_hashes;
            this.start_height = start_height;
            this.end_height = end_height;
            this.include_spent_coins = include_spent_coins;
        }

        /// <summary>
        /// Gets or sets the list of puzzle hashes to examine.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[] puzzle_hashes { get; set; } = new string[] { };
        /// <summary>
        /// Gets or sets the block height at which to begin the search.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? start_height { get; set; }

        /// <summary>
        /// Gets or sets the block height at which to end the search.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? end_height { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include spent coins.
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? include_spent_coins { get; set; }
    }
}
