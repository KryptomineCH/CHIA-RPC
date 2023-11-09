using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// Get a transaction's details from its ID
    /// </summary>
    /// <remarks>
    /// <b>
    /// <b>WARNING:</b> The transaction history is not deterministic due to heuristics we use to counter privacy features of the blockchain.<br/>
    /// this means, a couple of details cannot be fetched fully:<br/>
    /// - The transaction IDs can and will change if you resync the wallet<br/>
    /// - The transaction time is a <b>rough</b> estimate. When an offer is accepted, the individual offer transactions have different created times
    /// - For your offers that a 3rd Party accepted, the incoming coins are beeing marked as incoming transaction, not as incoming coin<br/>
    /// - When cancelling offers, the cancellation Transactions are beeing shown as transaction, not as trade<br/>
    /// - Offers are split into multiple transactions on the corresponding wallets.<br/>
    /// - Offer Transactions do not share the same ids. To match them up, it is best to keep the offer files.<br/>
    /// - Transactions which are not kept in XCH and have a fee will cause a second Transaction in the XCH Wallet<br/>
    /// For accurate records, you should keep a local record of transactions (TXs) and the Offer files made. <br/><br/>
    /// <see href="https://docs.chia.net/wallet-rpc#get_transaction"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.TransactionID_RPC"/>
    /// </remarks>
    public class GetTransaction_Response : ResponseTemplate<GetTransaction_Response>
    {
        /// <summary>
        /// The 'Transaction_DictMemos' object that contains the details of the transaction.
        /// This includes information such as the inputs, outputs, and other details of the transaction.
        /// 'Transaction_DictMemos' is a dictionary that maps transaction details to their respective memo data.
        /// </summary>
        /// <remarks>
        /// <b>WARNING:</b> <br/>
        /// - Transactions are not deterministic. Information such as "confirmed_at_height" "created_at_time" and Name WILL CHANGE when resynching the wallet!<br/>
        /// - The transaction types are not fully functional. Specifically `INCOMING_TRADE` cannot be matched up on an offer you created and someone else accepted!
        /// <br/><br/> 
        /// </remarks>
        public Transaction_DictMemos? transaction { get; set; }

        /// <summary>
        /// The unique identifier of the transaction.
        /// This is a string that is generated when the transaction is created and is used to uniquely identify the transaction in the Chia network.
        /// It can be used to look up the transaction, verify its existence, and check its status.
        /// </summary>
        public string? transaction_id { get; set; }
        /// <summary>
        /// converts this to a transaction id rpc which can be used to check the transaction status
        /// </summary>
        /// <param name="response"></param>
        public static implicit operator TransactionID_RPC(GetTransaction_Response response)
        {
            if (response.transaction_id == null)
            {
                throw new NullReferenceException(nameof(response.transaction_id));
            }
            return new TransactionID_RPC(response.transaction_id);
        }
    }
    /// <summary>
    /// all transactions for a given wallet (filtered).
    /// </summary>
    /// <remarks>
    /// <b>
    /// <b>WARNING:</b> The transaction history is not deterministic due to heuristics we use to counter privacy features of the blockchain.<br/>
    /// this means, a couple of details cannot be fetched fully:<br/>
    /// - The transaction IDs can and will change if you resync the wallet<br/>
    /// - The transaction time is a <b>rough</b> estimate. When an offer is accepted, the individual offer transactions have different created times
    /// - For your offers that a 3rd Party accepted, the incoming coins are beeing marked as incoming transaction, not as incoming coin<br/>
    /// - When cancelling offers, the cancellation Transactions are beeing shown as transaction, not as trade<br/>
    /// - Offers are split into multiple transactions on the corresponding wallets.<br/>
    /// - Offer Transactions do not share the same ids. To match them up, it is best to keep the offer files.<br/>
    /// - Transactions which are not kept in XCH and have a fee will cause a second Transaction in the XCH Wallet<br/>
    /// For accurate records, you should keep a local record of transactions (TXs) and the Offer files made. <br/><br/>
    /// <see href="https://docs.chia.net/wallet-rpc#get_transactions"/><br/><br/>
    /// Uses:<br/><see cref="GetTransactions_RPC"/>
    /// </remarks>
    public class GetTransactions_Response : ResponseTemplate<GetTransactions_Response>
    {
        /// <summary>
        /// the transactions details
        /// </summary>
        /// <remarks>
        /// <b>WARNING:</b> The transaction history is not deterministic due to heuristics we use to counter privacy features of the blockchain.<br/>
        /// this means, a couple of details cannot be fetched fully:<br/>
        /// - The transaction IDs can and will change if you resync the wallet<br/>
        /// - The transaction time is a <b>rough</b> estimate. When an offer is accepted, the individual offer transactions have different created times
        /// - For your offers that a 3rd Party accepted, the incoming coins are beeing marked as incoming transaction, not as incoming coin<br/>
        /// - When cancelling offers, the cancellation Transactions are beeing shown as transaction, not as trade<br/>
        /// - Offers are split into multiple transactions on the corresponding wallets.<br/>
        /// - Offer Transactions do not share the same ids. To match them up, it is best to keep the offer files.<br/>
        /// - Transactions which are not kept in XCH and have a fee will cause a second Transaction in the XCH Wallet<br/>
        /// For accurate records, you should keep a local record of transactions (TXs) and the Offer files made. <br/><br/>
        /// </remarks>
        public Transaction_DictMemos[]? transactions { get; set; }
        /// <summary>
        /// the wallet id where the transactions belong to
        /// </summary>
        public ulong? wallet_id { get; set; }
    }
    /// <summary>
    /// Represents a JSON RPC request for getting all transactions for a given wallet.
    /// </summary>
    /// <remarks>
    /// <b>WARNING:</b> The transaction history is not deterministic due to heuristics we use to counter privacy features of the blockchain.<br/>
    /// this means, a couple of details cannot be fetched fully:<br/>
    /// - The transaction IDs can and will change if you resync the wallet<br/>
    /// - The transaction time is a <b>rough</b> estimate. When an offer is accepted, the individual offer transactions have different created times
    /// - For your offers that a 3rd Party accepted, the incoming coins are beeing marked as incoming transaction, not as incoming coin<br/>
    /// - When cancelling offers, the cancellation Transactions are beeing shown as transaction, not as trade<br/>
    /// - Offers are split into multiple transactions on the corresponding wallets.<br/>
    /// - Offer Transactions do not share the same ids. To match them up, it is best to keep the offer files.<br/>
    /// - Transactions which are not kept in XCH and have a fee will cause a second Transaction in the XCH Wallet<br/>
    /// For accurate records, you should keep a local record of transactions (TXs) and the Offer files made. <br/><br/>
    /// <see href="https://docs.chia.net/wallet-rpc#get_transactions"/></remarks>
    /// <returns><see cref="GetTransactions_Response"/></returns>
    public class GetTransactions_RPC : RPCTemplate<GetTransactions_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serialisation
        /// </summary>
        /// <remarks>
        /// <b>WARNING:</b> The transaction history is not deterministic due to heuristics we use to counter privacy features of the blockchain.<br/>
        /// this means, a couple of details cannot be fetched fully:<br/>
        /// - The transaction IDs can and will change if you resync the wallet<br/>
        /// - The transaction time is a <b>rough</b> estimate. When an offer is accepted, the individual offer transactions have different created times
        /// - For your offers that a 3rd Party accepted, the incoming coins are beeing marked as incoming transaction, not as incoming coin<br/>
        /// - When cancelling offers, the cancellation Transactions are beeing shown as transaction, not as trade<br/>
        /// - Offers are split into multiple transactions on the corresponding wallets.<br/>
        /// - Offer Transactions do not share the same ids. To match them up, it is best to keep the offer files.<br/>
        /// - Transactions which are not kept in XCH and have a fee will cause a second Transaction in the XCH Wallet<br/>
        /// For accurate records, you should keep a local record of transactions (TXs) and the Offer files made. <br/><br/>
        /// </remarks>
        public GetTransactions_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents a JSON RPC request for getting all transactions for a given wallet.
        /// </summary>
        /// <remarks>
        /// <b>WARNING:</b> The transaction history is not deterministic due to heuristics we use to counter privacy features of the blockchain.<br/>
        /// this means, a couple of details cannot be fetched fully:<br/>
        /// - The transaction IDs can and will change if you resync the wallet<br/>
        /// - The transaction time is a <b>rough</b> estimate. When an offer is accepted, the individual offer transactions have different created times
        /// - For your offers that a 3rd Party accepted, the incoming coins are beeing marked as incoming transaction, not as incoming coin<br/>
        /// - When cancelling offers, the cancellation Transactions are beeing shown as transaction, not as trade<br/>
        /// - Offers are split into multiple transactions on the corresponding wallets.<br/>
        /// - Offer Transactions do not share the same ids. To match them up, it is best to keep the offer files.<br/>
        /// - Transactions which are not kept in XCH and have a fee will cause a second Transaction in the XCH Wallet<br/>
        /// For accurate records, you should keep a local record of transactions (TXs) and the Offer files made. <br/><br/>
        /// </remarks>
        /// <param name="wallet_id">The Wallet ID of the wallet from which to obtain transactions.</param>
        /// <param name="start">The sequence number of the first transaction to show. Default: 0.</param>
        /// <param name="end">The sequence number of the last transaction to show. Default: 50.</param>
        /// <param name="sort_key">The key for sorting. Default: None.</param>
        /// <param name="reverse">Set to true to list newest results first. Default: false (oldest first (better for history building due to pagination).</param>
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
        public ulong? wallet_id { get; set; }

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
        /// <remarks>Set to true to list newest results first. Default: false (oldest first (better for history building due to pagination).</remarks>
        public bool? reverse { get; set; }

        /// <summary>
        /// Only include transactions with this to_address. Default: None.
        /// </summary>
        /// <remarks>Optional</remarks>
        public string? to_address { get; set; }
    }
}
