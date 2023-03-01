using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.General
{
    /// <summary>
    /// this enum is beeing used in PushTx response and indicates wether the Transaction was pushed to Mempool successfully
    /// </summary>
    public enum TransactionStatus
    {
        SUCCESS,
        PENDING,
        FAILED
    }
    /// <summary>
    /// This class represents the response received after pushing a transaction to the mempool.
    /// </summary>
    public class PushTx_Response : ResponseTemplate<PushTx_Response>
    {
        /// <summary>
        /// the Status indicates wether the transaction was pushed to the Mempool successfully
        /// </summary>
        public TransactionStatus status { get; set; }
    }
    /// <summary>
    /// Represents an RPC request to push a transaction to the blockchain.
    /// </summary>
    public class PushTx_RPC : RPCTemplate<PushTx_RPC>
    {
        /// <summary>
        /// The SpendBundle to be included in the transaction.
        /// </summary
        public SpendBundle spend_bundle { get; set; }
    }
}
