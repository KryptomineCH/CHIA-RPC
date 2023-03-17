using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Given a signage point's hash, list the details of that signage point
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/farmer-rpc#get_signage_point"/></remarks>
    /// <returns><see cref="SignagePointWithProofs"/></returns>
    public class GetSignagePoint_RPC : RPCTemplate<GetSignagePoint_RPC>
    {
        /// <summary>
        /// The hash of a signage point, listed as pos_ss_cc_challenge_hash in the block details
        /// </summary>
        public string sp_hash { get; set; }
    }
}
