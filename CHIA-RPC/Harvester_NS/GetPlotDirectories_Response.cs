using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Harvester_NS
{
    /// <summary>
    /// Represents the response for the 'get_plot_directories' API call.
    /// </summary>
    /// <remarks>
    /// This request does not have parameters
    /// <see href="https://docs.chia.net/harvester-rpc/#get_plot_directories"/>
    /// </remarks>
    public class GetPlotDirectories_Response : ResponseTemplate<GetPlotDirectories_Response>
    {
        /// <summary>
        /// Gets or sets the list of directories containing plots.
        /// </summary>
        public string[] directories { get; set; }
    }

}
