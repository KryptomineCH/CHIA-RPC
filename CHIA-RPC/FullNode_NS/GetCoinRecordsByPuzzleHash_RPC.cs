using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{

    /// <summary>
    /// Class to retrieve a list of coin records with a certain puzzle hash.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_puzzle_hash"/></remarks>
    /// <returns><see cref="General_NS.GetCoinRecords_Response"/></returns>
    public class GetCoinRecordsByPuzzleHash_RPC : RPCTemplate<GetCoinRecordsByPuzzleHash_RPC>
    {
        public GetCoinRecordsByPuzzleHash_RPC() { /* for serialisation */ }
        public GetCoinRecordsByPuzzleHash_RPC(string puzzle_hash, ulong? start_height = null, ulong? end_height = null, bool? include_spent_coins = null)
        {
            this.puzzle_hash = puzzle_hash;
            this.start_height = start_height;
            this.end_height = end_height;
            this.include_spent_coins = include_spent_coins;
        }

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
    }
}
