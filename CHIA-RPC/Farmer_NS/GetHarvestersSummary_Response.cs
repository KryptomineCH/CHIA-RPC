using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Response object for get_harvesters_summary API endpoint.
    /// </summary>
    /// <remarks>
    /// request is parameterless<br/>
    /// <see href="https://docs.chia.net/farmer-rpc#get_harvesters_summary"/>
    /// </remarks>
    public class GetHarvestersSummary_Response : ResponseTemplate<GetHarvestersSummary_Response>
    {
        /// <summary>
        /// List of harvesters in your network.
        /// </summary>
        public Harvester[] harvesters { get; set; }
    }
}
