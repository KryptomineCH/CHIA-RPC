using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS.FarmerObjects_NS
{
    /// <summary>
    /// Represents the state of the pool.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/farmer-rpc#get_pool_state"/></remarks>
    public class PoolState : ObjectTemplate<PoolState>
    {
        /// <summary>
        /// The time in seconds until the authentication token expires.
        /// </summary>
        public uint authentication_token_timeout { get; set; }

        /// <summary>
        /// The current difficulty.
        /// </summary>
        public ulong current_difficulty { get; set; }

        /// <summary>
        /// The current points.
        /// </summary>
        public ulong current_points { get; set; }

        /// <summary>
        /// The time in seconds until the next farmer update.
        /// </summary>
        public double next_farmer_update { get; set; }

        /// <summary>
        /// The time in seconds until the next pool info update.
        /// </summary>
        public double next_pool_info_update { get; set; }

        /// <summary>
        /// The puzzle hash of the pool wallet.
        /// </summary>
        public string p2_singleton_puzzle_hash { get; set; }

        /// <summary>
        /// The number of plots owned by the pool.
        /// </summary>
        public ulong plot_count { get; set; }

        /// <summary>
        /// The points acknowledged in the past 24 hours.
        /// </summary>
        public ulong[] points_acknowledged_24h { get; set; }

        /// <summary>
        /// The total points acknowledged since the start of the pool.
        /// </summary>
        public ulong points_acknowledged_since_start { get; set; }

        /// <summary>
        /// The points found in the past 24 hours.
        /// </summary>
        public ulong[] points_found_24h { get; set; }

        /// <summary>
        /// The total points found since the start of the pool.
        /// </summary>
        public ulong points_found_since_start { get; set; }

        /// <summary>
        /// The configuration of the pool.
        /// </summary>
        public PoolConfig pool_config { get; set; }

        /// <summary>
        /// The errors that occurred in the past 24 hours.
        /// </summary>
        public PoolError[] pool_errors_24h { get; set; }
    }
}
