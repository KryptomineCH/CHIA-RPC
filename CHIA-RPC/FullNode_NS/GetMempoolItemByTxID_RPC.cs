using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Represents a response containing a mempool item retrieved by tx ID.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_mempool_item_by_tx_id"/><br/><br/>
    /// Uses:<br/><see cref="GetMempoolItemByTxID_RPC"/>
    /// </remarks>
    public class GetMempoolItemByTxID_Response : ResponseTemplate<GetMempoolItemByTxID_Response>
    {
        /// <summary>
        /// the mempool item retrieved by tx ID.
        /// </summary>
        public MempoolItem mempool_item { get; set; }
    }
    /// <summary>
    /// Represents a request to retrieve a mempool item by tx ID.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_mempool_item_by_tx_id"/></remarks>
    /// <returns><see cref="GetMempoolItemByTxID_Response"/></returns>
    public class GetMempoolItemByTxID_RPC : RPCTemplate<GetMempoolItemByTxID_RPC>
    {
        /// <summary>
        /// for serializer
        /// </summary>
        public GetMempoolItemByTxID_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents a request to retrieve a mempool item by tx ID.
        /// </summary>
        /// <param name="tx_id">the spend bundle hash (tx ID) of the mempool item to retrieve.</param>
        public GetMempoolItemByTxID_RPC(string tx_id)
        {
            this.tx_id = tx_id;
        }
        /// <summary>
        /// Represents a request to retrieve a mempool item by tx ID.
        /// </summary>
        /// <param name="tx_id">the spend bundle hash (tx ID) of the mempool item to retrieve.</param>
        public GetMempoolItemByTxID_RPC(TxID_Response txID)
        {
            this.tx_id = txID.tx_id;
        }
        /// <summary>
        /// Represents a request to retrieve a mempool item by tx ID.
        /// </summary>
        /// <param name="tx_id">the spend bundle hash (tx ID) of the mempool item to retrieve.</param>
        public GetMempoolItemByTxID_RPC(TransactionID_Response txID)
        {
            this.tx_id = txID.transaction_id;
        }
        /// <summary>
        /// Represents a request to retrieve a mempool item by tx ID.
        /// </summary>
        /// <param name="tx_id">the spend bundle hash (tx ID) of the mempool item to retrieve.</param>
        public GetMempoolItemByTxID_RPC(Transaction_Response txID)
        {
            this.tx_id = txID.transaction_id;
        }

        /// <summary>
        /// the spend bundle hash (tx ID) of the mempool item to retrieve.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string tx_id { get; set; }
    }
}
