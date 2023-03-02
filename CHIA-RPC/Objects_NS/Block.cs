
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Class representing a Block object
    /// </summary>
    public class Block : ObjectTemplate<Block>
    {
        /// <summary>
        /// The challenge_chain_ip_proof for the block
        /// </summary>
        public Proof challenge_chain_ip_proof { get; set; }

        /// <summary>
        /// The challenge_chain_sp_proof for the block
        /// </summary>
        public object challenge_chain_sp_proof { get; set; }

        /// <summary>
        /// The finished_sub_slots for the block
        /// </summary>
        public List<object> finished_sub_slots { get; set; }

        /// <summary>
        /// The foliage data for the block
        /// </summary>
        public Foliage foliage { get; set; }

        /// <summary>
        /// The foliage_transaction_block for the block
        /// </summary>
        public object foliage_transaction_block { get; set; }

        /// <summary>
        /// The infused_challenge_chain_ip_proof for the block
        /// </summary>
        public object infused_challenge_chain_ip_proof { get; set; }

        /// <summary>
        /// The reward_chain_block for the block
        /// </summary>
        public RewardChainBlock reward_chain_block { get; set; }

        /// <summary>
        /// The reward_chain_ip_proof for the block
        /// </summary>
        public Proof reward_chain_ip_proof { get; set; }

        /// <summary>
        /// The reward_chain_sp_proof for the block
        /// </summary>
        public object reward_chain_sp_proof { get; set; }

        /// <summary>
        /// The transactions_generator for the block
        /// </summary>
        public object transactions_generator { get; set; }

        /// <summary>
        /// The transactions_generator_ref_list for the block
        /// </summary>
        public List<object> transactions_generator_ref_list { get; set; }

        /// <summary>
        /// The transactions_info for the block
        /// </summary>
        public object transactions_info { get; set; }
    }
}