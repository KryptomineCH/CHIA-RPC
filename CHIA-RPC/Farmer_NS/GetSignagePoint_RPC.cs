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
        /// parameterless constructor, for serializer
        /// </summary>
        public GetSignagePoint_RPC() { /* for serialisation */ }
        /// <summary>
        /// Given a signage point's hash, list the details of that signage point
        /// </summary>
        /// <param name="sp_hash">The hash of a signage point, listed as pos_ss_cc_challenge_hash in the block details</param>
        public GetSignagePoint_RPC(string sp_hash)
        {
            this.sp_hash = sp_hash;
        }

        /// <summary>
        /// The hash of a signage point, listed as pos_ss_cc_challenge_hash in the block details
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string sp_hash { get; set; }
    }
}
