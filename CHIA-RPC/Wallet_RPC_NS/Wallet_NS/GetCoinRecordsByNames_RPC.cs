using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{

    /// <summary>
    /// get_coin_records_by_names
    /// Functionality: Obtain coin records from a list of coin names
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#get_coin_records_by_names"/><br/><br/>
    /// Uses:<br/><see cref="GetCoinRecordsByNames_RPC"/>
    /// </remarks>
    public class GetCoinRecordsByNames_Response : ResponseTemplate<GetCoinRecordsByNames_Response>
    {
        /// <summary>
        /// A list of coin records returned by the server.
        /// </summary>
        public CoinRecord[] coin_records { get; set; }
    }
    /// <summary>
    /// Class representing a JSON RPC request for the get_coin_records_by_names method.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#get_coin_records_by_names"/></remarks>
    /// <returns><see cref="GetCoinRecordsByNames_Response"/></returns>
    public class GetCoinRecordsByNames_RPC : RPCTemplate<GetCoinRecordsByNames_RPC>
    {
        /// <summary>
        /// A list of coin names from which to retrieve records.
        /// </summary>
        public string[] names { get; set; }

        /// <summary>
        /// The block height at which to start the query.
        /// </summary>
        public ulong? start_height { get; set; }

        /// <summary>
        /// The block height at which to end the query.
        /// </summary>
        public ulong? end_height { get; set; }

        /// <summary>
        /// Include spent coins in the result (default: false).
        /// </summary>
        public bool? include_spent_coins { get; set; }
    }
}
