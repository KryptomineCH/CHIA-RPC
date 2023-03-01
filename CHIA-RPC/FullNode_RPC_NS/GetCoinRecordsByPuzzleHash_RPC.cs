using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{

    /// <summary>
    /// Class to retrieve a list of coin records with a certain puzzle hash.
    /// </summary>
    public class GetCoinRecordsByPuzzleHash_RPC : RPCTemplate<GetCoinRecordsByPuzzleHash_RPC>
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
    }
}
