using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{

    /// <summary>
    /// Class for retrieving coins for given parent coin IDs, by default returns unspent coins.
    /// </summary>
    public class GetCoinRecordsByParentIDs_RPC : RPCTemplate<GetCoinRecordsByParentIDs_RPC>
    {
        /// <summary>
        /// A list of parent IDs to examine.
        /// </summary>
        public string[] parent_ids { get; set; }

        /// <summary>
        /// The block height at which to begin the search.
        /// </summary>
        public ulong? start_height { get; set; }

        /// <summary>
        /// The block height at which to end the search.
        /// </summary>
        public ulong? end_height { get; set; }

        /// <summary>
        /// A boolean indicating whether to include spent coins (default=false).
        /// </summary>
        public bool? include_spent_coins { get; set; }
    }
}
