using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// this enum is beeing used in PushTx response and indicates wether the Transaction was pushed to Mempool successfully
    /// </summary>
    public enum TransactionStatus
    {
        /// <summary>
        /// The transaction was successful and it complete
        /// </summary>
        SUCCESS,
        /// <summary>
        /// The transaction is still waiting for confirmation on the Blockchain
        /// </summary>
        PENDING,
        /// <summary>
        /// The Transaction got cancelled. It did not pass through
        /// </summary>
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
        /// parameterless constructor, for serialisation
        /// </summary>
        public PushTx_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents an RPC request to push a transaction to the blockchain.
        /// </summary>
        /// <param name="spend_bundle">The SpendBundle to be included in the transaction.</param>
        public PushTx_RPC(SpendBundle spend_bundle)
        {
            this.spend_bundle = spend_bundle;
        }

        /// <summary>
        /// The SpendBundle to be included in the transaction.
        /// </summary>
        public SpendBundle? spend_bundle { get; set; }
        /// <summary>
        /// Implicit conversion from SpendBundle to PushTx_RPC.
        /// </summary>
        /// <param name="response">PushTx_RPC object</param>
        public static implicit operator PushTx_RPC(SpendBundle response)
        {
            return new PushTx_RPC(response);
        }
    }
}
