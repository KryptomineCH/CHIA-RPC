using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// List details for all signage points going back several challenges
    /// </summary>
    public class GetSignagePoints_Response : ResponseTemplate<GetSignagePoints_Response>
    {
        /// <summary>
        /// An array of all signage points
        /// </summary>
        public SignagePoint[] signage_points { get; set; }

        /// <summary>
        /// Details of a signage point
        /// </summary>
        public class SignagePoint
        {
            /// <summary>
            /// Proof of space that is valid for this signage point
            /// </summary>
            public string[] proofs { get; set; }

            /// <summary>
            /// The signage point
            /// </summary>
            public FarmerObjects_NS.SignagePoint signage_point { get; set; }

        }
    }

}
