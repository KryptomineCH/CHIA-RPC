using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS.FarmerObjects_NS
{
    /// <summary>
    /// Details of a signage point
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/farmer-rpc#get_signage_point"/></remarks>
    public class SignagePoint : ObjectTemplate<SignagePoint>
    {
        /// <summary>
        /// The challenge chain sub-block hash associated with this signage point
        /// </summary>
        public string challenge_chain_sp { get; set; }

        /// <summary>
        /// The hash of the previous block in the sub-slot this block is in
        /// </summary>
        public string challenge_hash { get; set; }

        /// <summary>
        /// The iteration count when this signage point was created
        /// </summary>
        public ulong difficulty { get; set; }

        /// <summary>
        /// The reward chain sub-block hash associated with this signage point
        /// </summary>
        public string reward_chain_sp { get; set; }

        /// <summary>
        /// The index of this signage point within the sub-slot
        /// </summary>
        public ulong signage_point_index { get; set; }

        /// <summary>
        /// The number of iterations for each signage point
        /// </summary>
        public ulong sub_slot_iters { get; set; }
    }
}
