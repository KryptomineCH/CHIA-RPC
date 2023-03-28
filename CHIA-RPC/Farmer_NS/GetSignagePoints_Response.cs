using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// List details for all signage points going back several challenges
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/farmer-rpc#get_signage_points"/><br/><br/>
    /// Uses:<br/>the request has no parameters
    /// </remarks>
    public class GetSignagePoints_Response : ResponseTemplate<GetSignagePoints_Response>
    {
        /// <summary>
        /// an array of all signage points
        /// </summary>
        public SignagepointInfo[] signage_points { get; set;}
        public class SignagepointInfo : ObjectTemplate<SignagepointInfo>
        {
            public Proof[] proofs { get; set; }
            /// <summary>
            /// An array of all signage points
            /// </summary>
            public SignagePoint signage_point { get; set; }
        }
    }
}
