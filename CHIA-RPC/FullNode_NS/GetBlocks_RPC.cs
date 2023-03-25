using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// a list of full blocks by height. Important note: there might be multiple blocks at each height. To find out which one is in the blockchain, use get_block_record_by_height.
    /// </summary>
    /// <remarks>
    /// Important note: there might be multiple blocks at each height. To find out which one is in the blockchain, use get_block_record_by_height.<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_blocks"/><br/><br/>
    /// Uses:<br/><see cref="GetBlocks_RPC"/>
    /// </remarks>
    public class GetBlocks_Response : ResponseTemplate<GetBlocks_Response>
    {
        /// <summary>
        /// list of full blocks within the listed height range
        /// </summary>
        public Block[] blocks { get; set; }
    }
    /// <summary>
    /// Gets a list of full blocks by height. 
    /// </summary>
    /// <remarks>
    /// Important note: there might be multiple blocks at each height. To find out which one is in the blockchain, use get_block_record_by_height.<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_blocks"/>
    /// </remarks>
    /// <returns><see cref="GetBlocks_Response"/></returns>
    public class GetBlocks_RPC : RPCTemplate<GetBlocks_RPC>
    {
        /// <summary>
        /// The start height.
        /// </summary>
        public ulong start { get; set; }
        /// <summary>
        /// The end height(non-inclusive).
        /// </summary>
        public ulong end { get; set; }
        /// <summary>
        /// whether to exclude the header hash in the response(default false)
        /// </summary>
        public bool? exclude_header_hash { get; set; }
    }
}
