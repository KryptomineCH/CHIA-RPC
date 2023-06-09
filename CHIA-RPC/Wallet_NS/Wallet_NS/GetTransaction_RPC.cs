using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
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
        public Transaction_DictMemos transaction { get; set; }
        public string transaction_id { get; set; }
        /// <summary>
        /// converts this to a transaction id rpc which can be used to check the transaction status
        /// </summary>
        /// <param name="response"></param>
        public static implicit operator TransactionID_RPC(GetTransaction_Response response)
        {
            return new TransactionID_RPC(response.transaction_id);
        }
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
        public Transaction_DictMemos[] transactions { get; set; }
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
        /// parameterless constructor, for serialisation
        /// </summary>
        public GetTransactions_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents a JSON RPC request for getting all transactions for a given wallet.
        /// </summary>
        /// <param name="wallet_id">The Wallet ID of the wallet from which to obtain transactions.</param>
        /// <param name="start">The sequence number of the first transaction to show. Default: 0.</param>
        /// <param name="end">The sequence number of the last transaction to show. Default: 50.</param>
        /// <param name="sort_key">The key for sorting. Default: None.</param>
        /// <param name="reverse">Set to true to sort the results in reverse order. Default: false.</param>
        /// <param name="to_address">Only include transactions with this to_address. Default: None.</param>
        public GetTransactions_RPC(ulong wallet_id, ulong? start = null, ulong? end = null, ulong? sort_key = null, bool? reverse = null, string? to_address = null)
        {
            this.wallet_id = wallet_id;
            this.start = start;
            this.end = end;
            this.sort_key = sort_key;
            this.reverse = reverse;
            this.to_address = to_address;
        }

        /// <summary>
        /// The Wallet ID of the wallet from which to obtain transactions.
        /// </summary>
        /// <remarks>Mandatory</remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The sequence number of the first transaction to show. Default: 0.
        /// </summary>
        /// <remarks>Optional</remarks>
        public ulong? start { get; set; }

        /// <summary>
        /// The sequence number of the last transaction to show. Default: 50.
        /// </summary>
        /// <remarks>Optional</remarks>
        public ulong? end { get; set; }

        /// <summary>
        /// The key for sorting. Default: None.
        /// </summary>
        /// <remarks>Optional</remarks>
        public ulong? sort_key { get; set; }

        /// <summary>
        /// Set to true to sort the results in reverse order. Default: false.
        /// </summary>
        /// <remarks>Optional</remarks>
        public bool? reverse { get; set; }

        /// <summary>
        /// Only include transactions with this to_address. Default: None.
        /// </summary>
        /// <remarks>Optional</remarks>
        public string? to_address { get; set; }
    }
}
