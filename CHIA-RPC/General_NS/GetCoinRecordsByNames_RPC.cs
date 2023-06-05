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
        /// parameterless constructor, for serialisation
        /// </summary>
        public GetCoinRecordsByNames_RPC() { /* for serialisation */ }
        /// <summary>
        /// Retrieves the coins for given coin IDs; by default only returns unspent coins
        /// </summary>
        /// <param name="names">A list of coin names from which to retrieve records</param>
        /// <param name="start_height">The block height at which to start the query</param>
        /// <param name="end_height">The block height at which to end the query</param>
        /// <param name="include_spent_coins">Include spent coins in the result[Default: false]</param>
        public GetCoinRecordsByNames_RPC(string[] names, ulong? start_height = null, ulong? end_height = null, bool? include_spent_coins = null)
        {
            this.names = names;
            this.start_height = start_height;
            this.end_height = end_height;
            this.include_spent_coins = include_spent_coins;
        }

        /// <summary>
        /// A list of coin names from which to retrieve records
        /// </summary>
        /// <remarks>mandatory</remarks>
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
