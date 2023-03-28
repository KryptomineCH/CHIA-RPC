using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Represents the response for the Get_All_Mempool_Items API call, which returns all items in the mempool.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_all_mempool_items"/><br/><br/>
    /// Uses:<br/>the request does not have parameters
    /// </remarks>
    public class GetAllMempoolItems_Response : ResponseTemplate<GetAllMempoolItems_Response>
    {
        /// <summary>
        /// Array of mempool items.
        /// </summary>
        public Dictionary<string, MempoolItem> mempool_items { get; set; }
    }
}
