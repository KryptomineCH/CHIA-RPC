using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// response with a transaction id
    /// </summary>
    public class TxID_Response : ResponseTemplate<TxID_Response>
    {
        /// <summary>
        /// The transaction ID
        /// </summary>
        public string tx_id { get; set; }
    }
    /// <summary>
    /// response with a transaction id
    /// </summary>
    public class TransactionID_Response : ResponseTemplate<TransactionID_Response>
    {
        /// <summary>
        /// optional the transaction details
        /// </summary>
        public Transaction_DictMemos? transaction { get; set; }
        /// <summary>
        /// The ID of the transaction. This is listed as name in the output of the transactions RPC
        /// </summary>
        public string transaction_id { get; set; }
    }
    /// <summary>
    /// the transaction id is relevant for a variety of identifier tasks on the Blockchain
    /// </summary>
    public class TransactionID_RPC : RPCTemplate<TransactionID_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serialisation
        /// </summary>
        public TransactionID_RPC() { /* for serialisation */ }
        /// <summary>
        /// the transaction id is relevant for a variety of identifier tasks on the Blockchain
        /// </summary>
        /// <param name="transaction_id">The ID of the transaction to obtain. This is listed as name in the output of the transactions RPC</param>
        public TransactionID_RPC(string transaction_id)
        {
            this.transaction_id = transaction_id;
        }
        /// <summary>
        /// the transaction id is relevant for a variety of identifier tasks on the Blockchain
        /// </summary>
        /// <param name="transaction_id">The ID of the transaction to obtain. This is listed as name in the output of the transactions RPC</param>
        public TransactionID_RPC(TransactionID_Response transaction_id)
        {
            this.transaction_id = transaction_id.transaction_id;
        }
        /// <summary>
        /// the transaction id is relevant for a variety of identifier tasks on the Blockchain
        /// </summary>
        /// <param name="transaction_id">The ID of the transaction to obtain. This is listed as name in the output of the transactions RPC</param>
        public TransactionID_RPC(TxID_Response transaction_id)
        {
            this.transaction_id = transaction_id.tx_id;
        }

        /// <summary>
        /// The ID of the transaction to obtain. This is listed as name in the output of the transactions RPC
        /// </summary>
        public string transaction_id { get; set; }
        /// <summary>
        /// Implicit conversion from TransactionID_Response to TransactionID_RPC.
        /// </summary>
        /// <param name="response">DidID_Response object</param>
        public static implicit operator TransactionID_RPC(TransactionID_Response response)
        {
            return new TransactionID_RPC(response);
        }
        /// <summary>
        /// Implicit conversion from TxID_Response to TransactionID_RPC.
        /// </summary>
        /// <param name="response">DidID_Response object</param>
        public static implicit operator TransactionID_RPC(TxID_Response response)
        {
            return new TransactionID_RPC(response);
        }
    }
}
