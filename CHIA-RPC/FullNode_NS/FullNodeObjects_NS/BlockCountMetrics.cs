using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// An object that contains the metric values
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_block_count_metrics"/></remarks>
    public class BlockCountMetrics : ObjectTemplate<BlockCountMetrics>
    {
        /// <summary>
        /// The number of compact blocks
        /// </summary>
        public ulong compact_blocks { get; set; }

        /// <summary>
        /// The number of hint counts
        /// </summary>
        public ulong hint_count { get; set; }

        /// <summary>
        /// The number of uncompact blocks
        /// </summary>
        public ulong uncompact_blocks { get; set; }
    }
}
