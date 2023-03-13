using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS.FarmerObjects_NS
{
    /// <summary>
    /// Contains detailed information about a harvester node
    /// </summary>
    public class Harvester : ObjectTemplate<Harvester>
    {
        /// <summary>
        /// information about theharvester host (name, address, port)
        /// </summary>
        public HarvesterConnection connection { get; set; }
        /// <summary>
        /// a list with duplicate plots (delete duplicates please)
        /// </summary>
        public object[] duplicates { get; set; }
        /// <summary>
        /// a list with plots which could not be read
        /// </summary>
        public object[] failed_to_open_filenames { get; set; }
        /// <summary>
        /// the last time when the harvester node got synced
        /// </summary>
        public double last_sync_time { get; set; }
        /// <summary>
        /// a list with plots without key
        /// </summary>
        public object[] no_key_filenames { get; set; }
        /// <summary>
        /// a list with proper, valid plots
        /// </summary>
        HarvesterPlotInfo[] plots { get; set; }
        /// <summary>
        /// bool identifying if the harvester node was synchronizing or not at the time of request
        /// </summary>
        public bool? syncing { get; set; }
        /// <summary>
        /// the total size of plots on this harvester node
        /// </summary>
        public ulong total_plot_size { get; set; }
    }
}
