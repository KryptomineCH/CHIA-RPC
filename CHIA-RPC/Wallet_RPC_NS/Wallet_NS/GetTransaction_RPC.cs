using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    /// <summary>
    /// Get a transaction's details from its ID
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_transaction"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.TransactionID_RPC"/>
    /// </remarks>
    public class GetTransaction_Response : ResponseTemplate<GetTransaction_Response>
    {
        public Transaction transaction { get; set; }
        public string transaction_id { get; set; }
    }
    /// <summary>
    /// all transactions for a given wallet (filtered).
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_transactions"/><br/><br/>
    /// Uses:<br/><see cref="GetTransactions_RPC"/>
    /// </remarks>
    public class GetTransactions_Response : ResponseTemplate<GetTransactions_Response>
    {
        public Transaction[] transactions { get; set; }
        public ulong wallet_id { get; set; }
    }
    /// <summary>
    /// Represents a JSON RPC request for getting all transactions for a given wallet.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#get_transactions"/></remarks>
    /// <returns><see cref="GetTransactions_Response"/></returns>
    public class GetTransactions_RPC : RPCTemplate<GetTransactions_RPC>
    {
        /// <summary>
        /// The Wallet ID of the wallet from which to obtain transactions.
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The sequence number of the first transaction to show. Default: 0.
        /// </summary>
        public ulong? start { get; set; }

        /// <summary>
        /// The sequence number of the last transaction to show. Default: 50.
        /// </summary>
        public ulong? end { get; set; }

        /// <summary>
        /// The key for sorting. Default: None.
        /// </summary>
        public ulong? sort_key { get; set; }

        /// <summary>
        /// Set to true to sort the results in reverse order. Default: false.
        /// </summary>
        public bool? reverse { get; set; }

        /// <summary>
        /// Only include transactions with this to_address. Default: None.
        /// </summary>
        public string? to_address { get; set; }
    }
}
