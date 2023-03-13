using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS.FarmerObjects_NS
{
    /// <summary>
    /// Contains information about a harvester node
    /// </summary>
    public class HarvesterInfo : ObjectTemplate<HarvesterInfo>
    {
        /// <summary>
        /// Connection information for the harvester.
        /// </summary>
        public HarvesterConnection connection { get; set; }

        /// <summary>
        /// Number of duplicates on the harvester.
        /// </summary>
        public ulong duplicates { get; set; }

        /// <summary>
        /// Number of filenames the harvester failed to open.
        /// </summary>
        public ulong failed_to_open_filenames { get; set; }

        /// <summary>
        /// Time of the last successful sync on the harvester.
        /// </summary>
        public double last_sync_time { get; set; }

        /// <summary>
        /// Number of filenames on the harvester that don't have keys.
        /// </summary>
        public ulong no_key_filenames { get; set; }

        /// <summary>
        /// Number of plots on the harvester.
        /// </summary>
        public ulong plots { get; set; }

        /// <summary>
        /// Whether the harvester is currently syncing.
        /// </summary>
        public bool? syncing { get; set; }

        /// <summary>
        /// Total size of plots on the harvester.
        /// </summary>
        public ulong total_plot_size { get; set; }
    }
}
