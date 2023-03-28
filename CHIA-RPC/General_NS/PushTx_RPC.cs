using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.General_NS
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
    /// <remarks>
    /// request uses a <see cref="PushTx_RPC"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#push_tx"/>
    /// </remarks>
    public class PushTx_Response : ResponseTemplate<PushTx_Response>
    {
        /// <summary>
        /// the Status indicates wether the transaction was pushed to the Mempool successfully
        /// </summary>
        [JsonConverter(typeof(StringToEnumConverter<TransactionStatus>))]
        public TransactionStatus status { get; set; }
    }
    /// <summary>
    /// Represents an RPC request to push a transaction to the blockchain.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#push_tx"/></remarks>
    /// <returns><see cref="PushTx_Response"/></returns>
    public class PushTx_RPC : RPCTemplate<PushTx_RPC>
    {
        /// <summary>
        /// The SpendBundle to be included in the transaction.
        /// </summary
        public SpendBundle spend_bundle { get; set; }
    }
}
