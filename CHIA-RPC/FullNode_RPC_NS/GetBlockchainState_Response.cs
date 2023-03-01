
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// represents the server response containing the blockchain state as well as request success information
    /// </summary>
    public class GetBlockchainState_Response : ResponseTemplate<GetBlockchainState_Response>
    {
        public BlockchainState blockchain_state { get; set; }
    }
    /// <summary>
    /// Class representing the blockchain state
    /// </summary>
    public class BlockchainState
    {
        /// <summary>
        /// The difficulty of the blockchain
        /// </summary>
        public ulong difficulty { get; set; }

        /// <summary>
        /// Indicates if the genesis challenge has been initialized
        /// </summary>
        public bool genesis_challenge_initialized { get; set; }

        /// <summary>
        /// The size of the mempool
        /// </summary>
        public ulong mempool_size { get; set; }

        /// <summary>
        /// Information about the peak of the blockchain
        /// </summary>
        public Peak peak { get; set; }

        /// <summary>
        /// The space of the blockchain
        /// </summary>
        public ulong space { get; set; }

        /// <summary>
        /// The number of sub-slot iterations of the blockchain
        /// </summary>
        public ulong sub_slot_iters { get; set; }

        /// <summary>
        /// Information about the sync status of the blockchain
        /// </summary>
        public Sync sync { get; set; }
    }

    /// <summary>
    /// Class representing information about the peak of the blockchain
    /// </summary>
    public class Peak
    {
        /// <summary>
        /// The hash of the challenge block information
        /// </summary>
        public string challenge_block_info_hash { get; set; }

        /// <summary>
        /// The output of the challenge VDF
        /// </summary>
        public ChallengeVdfOutput challenge_vdf_output { get; set; }

        /// <summary>
        /// The deficit of the blockchain
        /// </summary>
        public ulong deficit { get; set; }

        /// <summary>
        /// The hash of the farmer's puzzle
        /// </summary>
        public string farmer_puzzle_hash { get; set; }

        /// <summary>
        /// The fees associated with the blockchain
        /// </summary>
        public object fees { get; set; }

        /// <summary>
        /// The hashes of the finished challenge slots
        /// </summary>
        public object finished_challenge_slot_hashes { get; set; }

        /// <summary>
        /// The hashes of the finished infused challenge slots
        /// </summary>
        public object finished_infused_challenge_slot_hashes { get; set; }

        /// <summary>
        /// The hashes of the finished reward slots
        /// </summary>
        public object finished_reward_slot_hashes { get; set; }

        /// <summary>
        /// The header hash of the blockchain
        /// </summary>
        public string header_hash { get; set; }

        /// <summary>
        /// The height of the blockchain
        /// </summary>
        public ulong height { get; set; }

        /// <summary>
        /// The output of the infused challenge VDF
        /// </summary>
        public object infused_challenge_vdf_output { get; set; }

        /// <summary>
        /// Indicates if there is an overflow in the blockchain
        /// </summary>
        public bool overflow { get; set; }

        /// <summary>
        /// The hash of the pool puzzle
        /// </summary>
        public string pool_puzzle_hash { get; set; }

        /// <summary>
        /// The previous hash of the blockchain
        /// </summary>
        public string prev_hash { get; set; }

        /// <summary>
        /// The hash of the previous transaction block
        /// </summary>
        public object prev_transaction_block_hash { get; set; }

        /// <summary>
        /// The height of the previous transaction block
        /// </summary>
        public ulong prev_transaction_block_height { get; set; }

        /// <summary>
        /// The number of required iterations for the blockchain
        /// </summary>
        public ulong required_iters { get; set; }

        /// <summary>
        /// The reward claims incorporated into the blockchain
        /// </summary>
        public object reward_claims_incorporated { get; set; }

        /// <summary>
        /// The new challenge for the reward infusion
        /// </summary>
        public string reward_infusion_new_challenge { get; set; }

        /// <summary>
        /// The index of the signage point
        /// </summary>
        public ulong signage_point_index { get; set; }

        /// <summary>
        /// Indicates if the sub-epoch summary has been included
        /// </summary>
        public object sub_epoch_summary_included { get; set; }

        /// <summary>
        /// The number of sub-slot iterations of the blockchain
        /// </summary>
        public ulong sub_slot_iters { get; set; }

        /// <summary>
        /// The timestamp of the blockchain
        /// </summary>
        public object timestamp { get; set; }

        /// <summary>
        /// The total number of iterations of the blockchain
        /// </summary>
        public ulong total_iters { get; set; }

        /// <summary>
        /// The weight of the blockchain
        /// </summary>
        public ulong weight { get; set; }
    }

    public class ChallengeVdfOutput
    {
        public string data { get; set; }
    }

    public class Sync
    {
        /// <summary>
        /// indicates wether the wallet is currently syncing or not
        /// </summary>
        public bool sync_mode { get; set; }
        public ulong sync_progress_height { get; set; }
        public ulong sync_tip_height { get; set; }
        /// <summary>
        /// indicates that the node is fully in sync
        /// </summary>
        public bool synced { get; set; }
    }

}
