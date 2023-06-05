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
        /// for serializer
        /// </summary>
        public GetCoinRecordsByHint_RPC() { /* for serialisation */ }
        /// <summary>
        /// Retrieves coins by hint; by default only returns unspent coins
        /// </summary>
        /// <param name="hint">The hint to examine</param>
        /// <param name="start_height">The block height at which to start the query</param>
        /// <param name="end_height">The block height at which to end the query</param>
        /// <param name="include_spent_coins">Include spent coins in the result[Default: false]</param>
        public GetCoinRecordsByHint_RPC(string hint, ulong? start_height = null, ulong? end_height = null, bool? include_spent_coins = null)
        {
            this.hint = hint;
            this.start_height = start_height;
            this.end_height = end_height;
            this.include_spent_coins = include_spent_coins;
        }

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
