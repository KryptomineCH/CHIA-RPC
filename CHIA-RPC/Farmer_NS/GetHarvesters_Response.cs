using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Represents the response from the 'get_harvesters' RPC call in Chia farmer.
    /// </summary>
    /// <remarks>
    /// request is parameterless<br/>
    /// <see href="https://docs.chia.net/farmer-rpc#get_harvesters"/>
    /// </remarks>
    public class GetHarvesters_Response : ResponseTemplate<GetHarvesters_Response>
    {
        /// <summary>
        /// An array of all harvesters in the owned network
        /// </summary>
        public Harvester[] harvesters { get; set; }
    }
}
