using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Class for retrieving coins for given parent coin IDs, by default returns unspent coins.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_parent_ids"/></remarks>
    /// <returns><see cref="General_NS.GetCoinRecords_Response"/></returns>
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
