using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Represents the response for the Get_All_Mempool_Items API call, which returns all items in the mempool.
    /// </summary>
    /// <remarks>
    /// this Request does not contain any parameters<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_all_mempool_items"/>
    /// </remarks>
    public class GetAllMempoolItems_Response : ResponseTemplate<GetAllMempoolItems_Response>
    {
        /// <summary>
        /// Array of mempool items.
        /// </summary>
        public Dictionary<string, MempoolItem> mempool_items { get; set; }
    }
}
