using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents a Reward Chain Block in the Chia blockchain, which is a component of a Full Block.
    /// The Reward Chain Block contains information about the Proof of Space and the VDFs (Verifiable Delay Functions)
    /// that are used to ensure the randomness and security of the blockchain.
    /// </summary>
    /// <remarks>
    /// More info:
    /// <see href="https://docs.chia.net/full-node-rpc#get_block"/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_blocks"/>
    /// </remarks>
    public class RewardChainBlock : ObjectTemplate<RewardChainBlock>
    {
        /// <summary>
        /// Represents the VDF (Verifiable Delay Function) for the challenge chain at the Infused Proof of Space level.
        /// This ensures a certain amount of time has passed since the last block, creating a delay between blocks.
        /// </summary>
        public Vdf? challenge_chain_ip_vdf { get; set; }

        /// <summary>
        /// The signature on the signage point by the farmer on the challenge chain.
        /// </summary>
        public string? challenge_chain_sp_signature { get; set; }

        /// <summary>
        /// The VDF (Verifiable Delay Function) for the challenge chain at the Signage Point level.
        /// </summary>
        public Vdf? challenge_chain_sp_vdf { get; set; }

        /// <summary>
        /// The height of this block in the blockchain, which is the number of blocks preceding it in the chain.
        /// </summary>
        public ulong? height { get; set; }

        /// <summary>
        /// Represents the VDF (Verifiable Delay Function) for the infused challenge chain at the Infused Proof of Space level.
        /// This also creates a delay between blocks and is used to incorporate more randomness into the process.
        /// </summary>
        public Vdf? infused_challenge_chain_ip_vdf { get; set; }

        /// <summary>
        /// Indicates whether this block is a transaction block, which contains spend transactions.
        /// </summary>
        public bool? is_transaction_block { get; set; }

        /// <summary>
        /// The challenge hash for the Proof of Space and Challenge Chain at the Signage Point level.
        /// </summary>
        public string? pos_ss_cc_challenge_hash { get; set; }

        /// <summary>
        /// The Proof of Space for this block, which is the proof that the farmer has allocated space for farming.
        /// </summary>
        public ProofOfSpace? proof_of_space { get; set; }

        /// <summary>
        /// Represents the VDF (Verifiable Delay Function) for the reward chain at the Infused Proof of Space level.
        /// </summary>
        public Vdf? reward_chain_ip_vdf { get; set; }

        /// <summary>
        /// The signature on the signage point by the farmer on the reward chain.
        /// </summary>
        public string? reward_chain_sp_signature { get; set; }

        /// <summary>
        /// The VDF (Verifiable Delay Function) for the reward chain at the Signage Point level.
        /// </summary>
        public Vdf? reward_chain_sp_vdf { get; set; }

        /// <summary>
        /// The index of the Signage Point, which is a point in time where farmers can create proofs of space.
        /// </summary>
        public ulong? signage_point_index { get; set; }

        /// <summary>
        /// The total number of iterations in the VDFs since the start of the blockchain.
        /// </summary>
        public ulong? total_iters { get; set; }

        /// <summary>
        /// The weight of this block, which is a measure of the total amount of time and resources required to reach this block in the blockchain.
        /// </summary>
        public ulong? weight { get; set; }
    }

}
