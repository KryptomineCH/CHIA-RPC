using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Class representing information about the peak of the blockchain
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/></remarks>
    public class Peak : ObjectTemplate<Peak>
    {
        /// <summary>
        /// The hash of the challenge block information
        /// </summary>
        public string? challenge_block_info_hash { get; set; }

        /// <summary>
        /// The output of the challenge VDF
        /// </summary>
        public ChallengeVdfOutput? challenge_vdf_output { get; set; }

        /// <summary>
        /// The deficit of the blockchain
        /// </summary>
        public ulong? deficit { get; set; }

        /// <summary>
        /// The hash of the farmer's puzzle
        /// </summary>
        public string? farmer_puzzle_hash { get; set; }

        /// <summary>
        /// The fees associated with the blockchain
        /// </summary>
        public object? fees { get; set; }

        /// <summary>
        /// The hashes of the finished challenge slots
        /// </summary>
        public object? finished_challenge_slot_hashes { get; set; }

        /// <summary>
        /// The hashes of the finished infused challenge slots
        /// </summary>
        public object? finished_infused_challenge_slot_hashes { get; set; }

        /// <summary>
        /// The hashes of the finished reward slots
        /// </summary>
        public object? finished_reward_slot_hashes { get; set; }

        /// <summary>
        /// The header hash of the blockchain
        /// </summary>
        public string? header_hash { get; set; }

        /// <summary>
        /// The height of the blockchain
        /// </summary>
        public ulong? height { get; set; }

        /// <summary>
        /// The output of the infused challenge VDF
        /// </summary>
        public object? infused_challenge_vdf_output { get; set; }

        /// <summary>
        /// Indicates if there is an overflow in the blockchain
        /// </summary>
        public bool? overflow { get; set; }

        /// <summary>
        /// The hash of the pool puzzle
        /// </summary>
        public string? pool_puzzle_hash { get; set; }

        /// <summary>
        /// The previous hash of the blockchain
        /// </summary>
        public string? prev_hash { get; set; }

        /// <summary>
        /// The hash of the previous transaction block
        /// </summary>
        public object? prev_transaction_block_hash { get; set; }

        /// <summary>
        /// The height of the previous transaction block
        /// </summary>
        public ulong? prev_transaction_block_height { get; set; }

        /// <summary>
        /// The number of required iterations for the blockchain
        /// </summary>
        public ulong? required_iters { get; set; }

        /// <summary>
        /// The reward claims incorporated into the blockchain
        /// </summary>
        public object? reward_claims_incorporated { get; set; }

        /// <summary>
        /// The new challenge for the reward infusion
        /// </summary>
        public string? reward_infusion_new_challenge { get; set; }

        /// <summary>
        /// The index of the signage point
        /// </summary>
        public ulong? signage_point_index { get; set; }

        /// <summary>
        /// Indicates if the sub-epoch summary has been included
        /// </summary>
        public object? sub_epoch_summary_included { get; set; }

        /// <summary>
        /// The number of sub-slot iterations of the blockchain
        /// </summary>
        public ulong? sub_slot_iters { get; set; }

        /// <summary>
        /// The timestamp of the blockchain
        /// </summary>
        public object? timestamp { get; set; }

        /// <summary>
        /// The total number of iterations of the blockchain
        /// </summary>
        public ulong? total_iters { get; set; }

        /// <summary>
        /// The weight of the blockchain
        /// </summary>
        public ulong? weight { get; set; }
    }
}
