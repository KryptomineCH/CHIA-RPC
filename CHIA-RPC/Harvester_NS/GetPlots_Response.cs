using CHIA_RPC.Harvester_NS.HarvesterObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Harvester_NS
{
    /// <summary>
    /// GetPlots_Response represents the server response for the get_plots functionality.
    /// The functionality lists all local plots of the harvester.
    /// </summary>
    public class GetPlots_Response : ResponseTemplate<GetPlots_Response>
    {
        /// <summary>
        /// The list of filenames that failed to open.
        /// </summary>
        public string[] failed_to_open_filenames { get; set; }

        /// <summary>
        /// The list of filenames that were not found.
        /// </summary>
        public string[] not_found_filenames { get; set; }

        /// <summary>
        /// the list of plots which are managed by the Harvester
        /// </summary>
        public HarvesterPlotInfo[] plots { get; set; }
    }
}
