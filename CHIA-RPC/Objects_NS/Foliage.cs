using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Class to represent the foliage object in the JSON
    /// </summary>
    public class Foliage : ObjectTemplate<Foliage>
    {
        /// <summary>
        /// Foliage block data object
        /// </summary>
        public FoliageBlockData foliage_block_data { get; set; }

        /// <summary>
        /// Foliage block data signature string
        /// </summary>
        public string foliage_block_data_signature { get; set; }

        /// <summary>
        /// Foliage transaction block hash string
        /// </summary>
        public string foliage_transaction_block_hash { get; set; }

        /// <summary>
        /// Foliage transaction block signature string
        /// </summary>
        public string foliage_transaction_block_signature { get; set; }

        /// <summary>
        /// Previous block hash string
        /// </summary>
        public string prev_block_hash { get; set; }

        /// <summary>
        /// Reward block hash string
        /// </summary>
        public string reward_block_hash { get; set; }
    }

    /// <summary>
    /// Class to represent the Foliage Block Data.
    /// </summary>
    public class FoliageBlockData : ObjectTemplate<FoliageBlockData>
    {
        /// <summary>
        /// Gets or sets the extension data.
        /// </summary>
        public string extension_data { get; set; }

        /// <summary>
        /// Gets or sets the farmer reward puzzle hash.
        /// </summary>
        public string farmer_reward_puzzle_hash { get; set; }

        /// <summary>
        /// Gets or sets the pool signature.
        /// </summary>
        public string pool_signature { get; set; }

        /// <summary>
        /// Gets or sets the pool target.
        /// </summary>
        public PoolTarget pool_target { get; set; }

        /// <summary>
        /// Gets or sets the unfinished reward block hash.
        /// </summary>
        public string unfinished_reward_block_hash { get; set; }
    }

    /// <summary>
    /// Class to represent the pool target.
    /// </summary>
    public class PoolTarget : ObjectTemplate<PoolTarget>
    {
        /// <summary>
        /// Gets or sets the maximum height.
        /// </summary>
        public ulong max_height { get; set; }

        /// <summary>
        /// Gets or sets the puzzle hash.
        /// </summary>
        public string puzzle_hash { get; set; }
    }
    /// <summary>
    /// Class to represent the Foliage Transaction Block.
    /// </summary>
    public class FoliageTransactionBlock : ObjectTemplate<FoliageTransactionBlock>
    {
        /// <summary>
        /// Gets or sets the additions root.
        /// </summary>
        public string additions_root { get; set; }

        /// <summary>
        /// Gets or sets the filter hash.
        /// </summary>
        public string filter_hash { get; set; }

        /// <summary>
        /// Gets or sets the previous transaction block hash.
        /// </summary>
        public string prev_transaction_block_hash { get; set; }

        /// <summary>
        /// Gets or sets the removals root.
        /// </summary>
        public string removals_root { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        public ulong timestamp { get; set; }

        /// <summary>
        /// Gets or sets the transactions info hash.
        /// </summary>
        public string transactions_info_hash { get; set; }
    }
}
