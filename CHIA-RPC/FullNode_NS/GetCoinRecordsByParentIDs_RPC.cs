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
        /// parameterless constructor, for serializer
        /// </summary>
        public GetCoinRecordsByParentIDs_RPC() { /* for serialisation */ }
        /// <summary>
        /// Class for retrieving coins for given parent coin IDs, by default returns unspent coins.
        /// </summary>
        /// <param name="parent_ids">A list of parent IDs to examine.</param>
        /// <param name="start_height">The block height at which to begin the search.</param>
        /// <param name="end_height">The block height at which to end the search.</param>
        /// <param name="include_spent_coins">A boolean indicating whether to include spent coins (default=false).</param>
        public GetCoinRecordsByParentIDs_RPC(string[] parent_ids, ulong? start_height = null, ulong? end_height = null, bool? include_spent_coins = null)
        {
            this.parent_ids = parent_ids;
            this.start_height = start_height;
            this.end_height = end_height;
            this.include_spent_coins = include_spent_coins;
        }

        /// <summary>
        /// A list of parent IDs to examine.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[] parent_ids { get; set; }

        /// <summary>
        /// The block height at which to begin the search.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? start_height { get; set; }

        /// <summary>
        /// The block height at which to end the search.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? end_height { get; set; }

        /// <summary>
        /// A boolean indicating whether to include spent coins (default=false).
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? include_spent_coins { get; set; }
    }
}
