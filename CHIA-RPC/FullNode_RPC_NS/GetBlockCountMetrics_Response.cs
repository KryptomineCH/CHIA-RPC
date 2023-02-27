
namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// A class to deserialize the JSON data
    /// </summary>
    public class MetricsData
    {
        /// <summary>
        /// An object that contains the metric values
        /// </summary>
        public Metrics metrics { get; set; }

        /// <summary>
        /// A boolean value indicating whether the operation was successful
        /// </summary>
        public bool success { get; set; }
        public string error { get; set; }
    }

    /// <summary>
    /// An object that contains the metric values
    /// </summary>
    public class Metrics
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
