using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// List plots in your local network
    /// </summary>
    /// <remarks>
    /// this respinse is used for multiple request endpoints such as get_harvester_plots_valid, get_harvester_plots_invalid, get_harvester_plots_keys_missing, get_harvester_plots_duplicates
    /// </remarks>
    public class GetHarvesterPlots_Response : ResponseTemplate<GetHarvesterPlots_Response>
    {
        /// <summary>
        /// Node ID of the harvester
        /// </summary>
        public string node_id { get; set; }

        /// <summary>
        /// Page number of the plots
        /// </summary>
        public ulong page { get; set; }

        /// <summary>
        /// Total number of pages of plots
        /// </summary>
        public ulong page_count { get; set; }

        /// <summary>
        /// List of valid plots in the harvester
        /// </summary>
        public HarvesterPlotInfo[] plots { get; set; }

        /// <summary>
        /// Total number of plots
        /// </summary>
        public ulong total_count { get; set; }
    }

    /// <summary>
    /// List plots in your local network.
    /// </summary>
    /// <remarks>
    /// this respinse is used for multiple request endpoints such as get_harvester_plots_valid, get_harvester_plots_invalid, get_harvester_plots_keys_missing, get_harvester_plots_duplicates
    /// </remarks>
    public class GetHarvesterPlots_RPC : RPCTemplate<GetHarvesterPlots_RPC>
    {
        /// <summary>
        /// This node's node_id, obtainable from the get_harvesters RPC.
        /// </summary>
        public string node_id { get; set; }

        /// <summary>
        /// The page in the results sequence to list (starts with 0).
        /// </summary>
        public ulong page { get; set; }

        /// <summary>
        /// The number of entries per page to list.
        /// </summary>
        public ulong page_size { get; set; }
    }
}
