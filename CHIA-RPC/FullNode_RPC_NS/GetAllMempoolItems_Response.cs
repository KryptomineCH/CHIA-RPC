using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Represents the response for the Get_All_Mempool_Items API call, which returns all items in the mempool.
    /// </summary>
    public class GetAllMempoolItems_Response : ResponseTemplate<GetAllMempoolItems_Response>
    {
        /// <summary>
        /// Array of mempool items.
        /// </summary>
        public MempoolItem[] mempool_items { get; set; }
    }
}
