using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Retrieves coins by hint; by default only returns unspent coins
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_hint"/></remarks>
    /// <returns><see cref="General_NS.GetCoinRecords_Response"/></returns>
    public class GetCoinRecordsByHint_RPC : RPCTemplate<GetCoinRecordsByHint_RPC>
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
    }
}
