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
        public Block[]? blocks { get; set; }
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
        /// parameterless constructor, for serializer
        /// </summary>
        public GetBlocks_RPC() { /* for serialisation */ }
        /// <summary>
        /// Gets a list of full blocks by height. 
        /// </summary>
        /// <param name="start">The start height.</param>
        /// <param name="end">The end height(non-inclusive).</param>
        /// <param name="exclude_header_hash">whether to exclude the header hash in the response(default false)</param>
        public GetBlocks_RPC(ulong start, ulong end, bool? exclude_header_hash = null)
        {
            this.start = start;
            this.end = end;
            this.exclude_header_hash = exclude_header_hash;
        }

        /// <summary>
        /// The start height.
        /// </summary>/
        /// <remarks>mandatory</remarks>
        public ulong? start { get; set; }
        /// <summary>
        /// The end height(non-inclusive).
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong? end { get; set; }
        /// <summary>
        /// whether to exclude the header hash in the response(default false)
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? exclude_header_hash { get; set; }
    }
}
