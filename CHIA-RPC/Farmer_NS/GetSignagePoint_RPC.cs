using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Response object for the 'get_signage_point' API call
    /// </summary>
    public class GetSignagePoint_Response : ResponseTemplate<GetSignagePoint_Response>
    {
        /// <summary>
        /// The details of the signage point
        /// </summary>
        public SignagePoint signage_point { get; set; }

        /// <summary>
        /// Empty list of proofs
        /// </summary>
        public ulong[] proofs { get; set; }
    }


    /// <summary>
    /// Given a signage point's hash, list the details of that signage point
    /// </summary>
    public class GetSignagePoint_RPC : RPCTemplate<GetSignagePoint_RPC>
    {
        /// <summary>
        /// The hash of a signage point, listed as pos_ss_cc_challenge_hash in the block details
        /// </summary>
        public string sp_hash { get; set; }
    }
}
