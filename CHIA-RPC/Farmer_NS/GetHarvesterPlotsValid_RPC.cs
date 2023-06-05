using CHIA_RPC.Harvester_NS.HarvesterObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{

    /// <summary>
    /// List plots in your local network
    /// </summary>
    /// <remarks>
    /// <see cref="GetHarvesterPlots_RPC"/> is beeing used for the request<br/>
    /// this response is used for multiple request endpoints:<br/>
    /// get_harvester_plots_valid <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_valid"/><br/>
    /// get_harvester_plots_invalid <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_invalid"/><br/>
    /// get_harvester_plots_keys_missing <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_keys_missing"/><br/>
    /// get_harvester_plots_duplicates <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_duplicates"/>
    /// </remarks>
    public class GetHarvesterPlotsInvalid_Response : ResponseTemplate<GetHarvesterPlotsInvalid_Response>
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
        public string[] plots { get; set; }

        /// <summary>
        /// Total number of plots
        /// </summary>
        public ulong total_count { get; set; }
    }
    /// <summary>
    /// List plots in your local network
    /// </summary>
    /// <remarks>
    /// <see cref="GetHarvesterPlots_RPC"/> is beeing used for the request<br/>
    /// this response is used for multiple request endpoints:<br/>
    /// get_harvester_plots_valid <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_valid"/><br/>
    /// get_harvester_plots_invalid <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_invalid"/><br/>
    /// get_harvester_plots_keys_missing <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_keys_missing"/><br/>
    /// get_harvester_plots_duplicates <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_duplicates"/>
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
    /// this rpc is used for multiple request endpoints:<br/>
    /// get_harvester_plots_valid <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_valid"/><br/>
    /// get_harvester_plots_invalid <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_invalid"/><br/>
    /// get_harvester_plots_keys_missing <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_keys_missing"/><br/>
    /// get_harvester_plots_duplicates <see href="https://docs.chia.net/farmer-rpc#get_harvester_plots_duplicates"/>
    /// </remarks>
    /// <returns><see cref="GetHarvesterPlots_Response"/></returns>
    public class GetHarvesterPlots_RPC : RPCTemplate<GetHarvesterPlots_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public GetHarvesterPlots_RPC() { /* for serialisation */ }
        /// <summary>
        /// List plots in your local network.
        /// </summary>
        /// <param name="node_id">This node's node_id, obtainable from the <see cref="GetHarvesters_Response"/> RPC.</param>
        /// <param name="page">The page in the results sequence to list (starts with 0).</param>
        /// <param name="page_size">The number of entries per page to list.</param>
        public GetHarvesterPlots_RPC(string node_id, ulong page, ulong page_size)
        {
            this.node_id = node_id;
            this.page = page;
            this.page_size = page_size;
        }

        /// <summary>
        /// This node's node_id, obtainable from the <see cref="GetHarvesters_Response"/> RPC.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string node_id { get; set; }

        /// <summary>
        /// The page in the results sequence to list (starts with 0).
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong page { get; set; }

        /// <summary>
        /// The number of entries per page to list.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong page_size { get; set; }
    }
}
