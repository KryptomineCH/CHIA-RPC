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
        public GetCoinRecordsByPuzzleHashes_RPC() { /* for serialisation */ }
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
        public string[] puzzle_hashes { get; set; } = new string[] { };
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
    }
}
