using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// used by the server to return a specific block
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.HeaderHash_RPC"/>
    /// </remarks>
    public class GetBlock_Response : ResponseTemplate<GetBlock_Response>
    {
        /// <summary>
        /// the block which is returned
        /// </summary>
        public Block? block { get; set; }
    }
}
