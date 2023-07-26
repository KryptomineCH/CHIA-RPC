using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Class to represent the Foliage Block Data.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_block"/></remarks>
    public class FoliageBlockData : ObjectTemplate<FoliageBlockData>
    {
        /// <summary>
        /// Gets or sets the extension data.
        /// </summary>
        public string? extension_data { get; set; }

        /// <summary>
        /// Gets or sets the farmer reward puzzle hash.
        /// </summary>
        public string? farmer_reward_puzzle_hash { get; set; }

        /// <summary>
        /// Gets or sets the pool signature.
        /// </summary>
        public string? pool_signature { get; set; }

        /// <summary>
        /// Gets or sets the pool target.
        /// </summary>
        public PoolTarget? pool_target { get; set; }

        /// <summary>
        /// Gets or sets the unfinished reward block hash.
        /// </summary>
        public string? unfinished_reward_block_hash { get; set; }
    }
}
