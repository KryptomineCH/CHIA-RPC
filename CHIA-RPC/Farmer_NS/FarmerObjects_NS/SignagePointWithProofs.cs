using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS.FarmerObjects_NS
{
    /// <summary>
    /// Details of a signage point
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/farmer-rpc#get_signage_points"/></remarks>
    public class SignagePointWithProofs : ResponseTemplate<SignagePointWithProofs>
    {
        /// <summary>
        /// Proof of space that is valid for this signage point
        /// </summary>
        public string[] proofs { get; set; }

        /// <summary>
        /// The signage point
        /// </summary>
        public SignagePoint signage_point { get; set; }
    }
}
