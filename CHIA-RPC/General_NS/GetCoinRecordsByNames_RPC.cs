using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// Retrieves the coins for given coin IDs; by default only returns unspent coins
    /// </summary>
    /// <remarks>
    /// this endpoint is used in WalletNode and FullNode<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_names"/>
    /// </remarks>
    /// <returns><see cref="GetCoinRecords_Response"/></returns>
    public class GetCoinRecordsByNames_RPC : RPCTemplate<GetCoinRecordsByNames_RPC>
    {
        /// <summary>
        /// A list of coin names from which to retrieve records
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string[] names { get; set; }
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
