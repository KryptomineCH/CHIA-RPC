using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// List details for all signage points going back several challenges
    /// </summary>
    /// <remarks>
    /// the request is parameterless<br/>
    /// <see href="https://docs.chia.net/farmer-rpc#get_signage_points"/>
    /// </remarks>
    public class GetSignagePoints_Response : ResponseTemplate<GetSignagePoints_Response>
    {
        /// <summary>
        /// An array of all signage points
        /// </summary>
        public SignagePoint[] signage_points { get; set; }
    }
}
