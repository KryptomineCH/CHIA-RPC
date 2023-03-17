using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// various metrics for the blockchain's blocks. Currently shows:
    /// compact blocks
    /// hint count
    /// uncompact blocks
    /// </summary>
    public class GetBlockCountMetrics_Response : ResponseTemplate<GetBlockCountMetrics_Response>
    {
        /// <summary>
        /// An object that contains the metric values
        /// </summary>
        public Metrics metrics { get; set; }
    }

    /// <summary>
    /// An object that contains the metric values
    /// </summary>
    public class Metrics : ObjectTemplate<Metrics>
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
