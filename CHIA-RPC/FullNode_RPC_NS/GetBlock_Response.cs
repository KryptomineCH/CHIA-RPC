using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// used by the server to return a specific block
    /// </summary>
    public class GetBlock_Response : ResponseTemplate<GetBlock_Response>
    {
        /// <summary>
        /// the block which is returned
        /// </summary>
        public Block block { get; set; }
    }
}
