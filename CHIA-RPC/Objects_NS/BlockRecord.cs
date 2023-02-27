
namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// A class to represent the block record information
    /// </summary>
    public class BlockRecord
    {
        /// <summary>
        /// The challenge block information hash
        /// </summary>
        public string challenge_block_info_hash { get; set; }

        /// <summary>
        /// An object that contains the challenge VDF output data
        /// </summary>
        public VdfOutput challenge_vdf_output { get; set; }

        /// <summary>
        /// The deficit value
        /// </summary>
        public ulong deficit { get; set; }

        /// <summary>
        /// The farmer puzzle hash
        /// </summary>
        public string farmer_puzzle_hash { get; set; }

        /// <summary>
        /// The fees, if the block is a transaction block
        /// </summary>
        public ulong fees { get; set; }

        /// <summary>
        /// The finished challenge slot hashes, if the block is the first block in a sub slot
        /// </summary>
        public object finished_challenge_slot_hashes { get; set; }

        /// <summary>
        /// The finished infused challenge slot hashes, if the block is the first block in a sub slot
        /// </summary>
        public object finished_infused_challenge_slot_hashes { get; set; }

        /// <summary>
        /// The finished reward slot hashes, if the block is the first block in a sub slot
        /// </summary>
        public object finished_reward_slot_hashes { get; set; }

        /// <summary>
        /// The header hash
        /// </summary>
        public string header_hash { get; set; }

        /// <summary>
        /// The block height
        /// </summary>
        public ulong height { get; set; }

        /// <summary>
        /// An object that contains the infused challenge VDF output data, if the deficit is less than 16
        /// </summary>
        public VdfOutput infused_challenge_vdf_output { get; set; }

        /// <summary>
        /// A boolean value indicating whether there is an overflow
        /// </summary>
        public bool overflow { get; set; }

        /// <summary>
        /// The pool puzzle hash
        /// </summary>
        public string pool_puzzle_hash { get; set; }

        /// <summary>
        /// The previous block hash
        /// </summary>
        public string prev_hash { get; set; }

        /// <summary>
        /// The previous transaction block hash, if the block is a transaction block
        /// </summary>
        public string prev_transaction_block_hash { get; set; }

        /// <summary>
        /// The previous transaction block height, if the block is a transaction block
        /// </summary>
        public ulong prev_transaction_block_height { get; set; }

        /// <summary>
        /// The required number of iterations
        /// </summary>
        public ulong required_iters { get; set; }
        /// <summary>
        /// A list of reward claims incorporated, if the block is a transaction block
        /// </summary>
        public List<RewardClaim> reward_claims_incorporated { get; set; }

        /// <summary>
        /// The reward infusion new challenge
        /// </summary>
        public string reward_infusion_new_challenge { get; set; }

        /// <summary>
        /// The signage point index
        /// </summary>
        public ulong signage_point_index { get; set; }

        /// <summary>
        /// The sub epoch summary included, if the block is the first block in a sub epoch
        /// </summary>
        public object sub_epoch_summary_included { get; set; }

        /// <summary>
        /// The number of sub slot iterations
        /// </summary>
        public ulong sub_slot_iters { get; set; }

        /// <summary>
        /// The timestamp, if the block is a transaction block
        /// </summary>
        public ulong timestamp { get; set; }

        /// <summary>
        /// The total number of iterations
        /// </summary>
        public ulong total_iters { get; set; }

        /// <summary>
        /// The weight
        /// </summary>
        public ulong weight { get; set; }
    }

    /// <summary>
    /// An object that contains the challenge VDF output data
    /// </summary>
    public class VdfOutput
    {
        /// <summary>
        /// The data value
        /// </summary>
        public string data { get; set; }
    }

    /// <summary>
    /// A class to represent a reward claim
    /// </summary>
    public class RewardClaim
    {
        /// <summary>
        /// The amount of the reward claim
        /// </summary>
        public ulong amount { get; set; }

        /// <summary>
        /// The parent coin information
        /// </summary>
        public string parent_coin_info { get; set; }

        /// <summary>
        /// The puzzle hash
        /// </summary>
        public string puzzle_hash { get; set; }
    }
}
