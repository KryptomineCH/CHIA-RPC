using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Contains the end of slot data for the response.
    /// </summary>
    /// <remarks>
    /// "the end of slot data" refers to the information or data associated with the end of a slot in a blockchain or distributed ledger system.
    /// Slots are generally considered as a unit of time or a period during which specific events occur in a blockchain network, such as block proposals, verifications, or finalizations.
    /// <br/><br/>
    /// The "end of slot data" may include various pieces of information like the VDF(Verifiable Delay Function) and the final state of the slot, 
    /// which can be used to verify the correctness and validity of the actions that took place during the slot.
    /// <br/><br/>
    /// In the given code snippet, the end_of_slot_vdf property in the RewardChain class represents the VDF object associated with the end of a slot.
    /// The VDF is a cryptographic primitive that requires a specific amount of time to compute but can be quickly verified by others.
    /// It is useful for proving that a certain amount of time has passed since a particular event, which is important for maintaining the integrity and security of the blockchain.
    /// <br/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_recent_signage_point_or_eos"/>
    /// </remarks>
    public class Eos
    {
        /// <summary>
        /// Challenge chain data.
        /// </summary>
        public ChallengeChain? challenge_chain { get; set; }

        /// <summary>
        /// Infused challenge chain data.
        /// </summary>
        public InfusedChallengeChain? infused_challenge_chain { get; set; }

        /// <summary>
        /// Dictionary containing proofs.
        /// </summary>
        public Dictionary<string, Proof> proofs { get; set; } = new Dictionary<string, Proof>();

        /// <summary>
        /// Reward chain data.
        /// </summary>
        public RewardChain? reward_chain { get; set; }

        /// <summary>
        /// Represents the challenge chain end of slot data.
        /// </summary>
        public class ChallengeChain
        {
            /// <summary>
            /// VDF data for the challenge chain end of slot.
            /// </summary>
            public Vdf? challenge_chain_end_of_slot_vdf { get; set; }

            /// <summary>
            /// Infused challenge chain sub slot hash.
            /// </summary>
            public string? infused_challenge_chain_sub_slot_hash { get; set; }

            /// <summary>
            /// New difficulty value, if any.
            /// </summary>
            public ulong? new_difficulty { get; set; }

            /// <summary>
            /// New sub slot iterations value, if any.
            /// </summary>
            public ulong? new_sub_slot_iters { get; set; }

            /// <summary>
            /// Subepoch summary hash.
            /// </summary>
            public string? subepoch_summary_hash { get; set; }
        }

        /// <summary>
        /// Represents the infused challenge chain end of slot data.
        /// </summary>
        public class InfusedChallengeChain
        {
            /// <summary>
            /// VDF data for the infused challenge chain end of slot.
            /// </summary>
            public Vdf? infused_challenge_chain_end_of_slot_vdf { get; set; }
        }

        /// <summary>
        /// Represents the reward chain end of slot data.
        /// </summary>
        public class RewardChain
        {
            /// <summary>
            /// The hash of the challenge chain sub-slot associated with the reward chain
            /// </summary>
            public string? challenge_chain_sub_slot_hash { get; set; }

            /// <summary>
            /// The deficit value in the reward chain
            /// </summary>
            public int? deficit { get; set; }

            /// <summary>
            /// The VDF (Verifiable Delay Function) object representing the end of the slot
            /// </summary>
            public Vdf? end_of_slot_vdf { get; set; }

            /// <summary>
            /// The hash of the infused challenge chain sub-slot associated with the reward chain
            /// </summary>
            public string? infused_challenge_chain_sub_slot_hash { get; set; }
        }
    }
}
