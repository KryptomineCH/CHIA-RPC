using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

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
        /// the spend bundle hash (tx ID) of the mempool item to retrieve.
        /// </summary>
        public string tx_id { get; set; }
    }
}
