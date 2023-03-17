﻿using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.Harvester_NS.HarvesterObjects_NS;
using CHIA_RPC.HelperFunctions_NS;
using static System.Net.WebRequestMethods;

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
