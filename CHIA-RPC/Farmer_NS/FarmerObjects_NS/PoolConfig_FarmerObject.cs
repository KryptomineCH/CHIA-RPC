using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS.FarmerObjects_NS
{
    /// <summary>
    /// Represents the configuration of the pool.
    /// </summary>
    public class PoolConfig_FarmerObject : ObjectTemplate<PoolConfig_FarmerObject>
    {
        /// <summary>
        /// The launcher ID of the pool.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// The public key of the pool owner.
        /// </summary>
        public string owner_public_key { get; set; }

        /// <summary>
        /// The puzzle hash of the pool wallet.
        /// </summary>
        public string p2_singleton_puzzle_hash { get; set; }

        /// <summary>
        /// The payout instructions of the pool.
        /// </summary>
        public string payout_instructions { get; set; }

        /// <summary>
        /// The URL of the pool.
        /// </summary>
        public string pool_url { get; set; }

        /// <summary>
        /// The target puzzle hash of the pool.
        /// </summary>
        public string target_puzzle_hash { get; set; }
    }
}
