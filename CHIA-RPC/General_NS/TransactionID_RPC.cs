﻿using CHIA_RPC.HelperFunctions_NS;
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
    public class TransactionID_Response : ResponseTemplate<TransactionID_Response>
    {
        /// <summary>
        /// optional the transaction details
        /// </summary>
        public Transaction? transaction { get; set; }
        /// <summary>
        /// The ID of the transaction. This is listed as name in the output of the transactions RPC
        /// </summary>
        public string transaction_id { get; set; }
    }
    public class TransactionID_RPC : RPCTemplate<TransactionID_RPC>
    {
        /// <summary>
        /// The ID of the transaction to obtain. This is listed as name in the output of the transactions RPC
        /// </summary>
        public string transaction_id { get; set; }
    }
}
