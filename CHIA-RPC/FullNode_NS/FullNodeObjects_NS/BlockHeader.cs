using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents a block header in the Chia blockchain.
    /// This class holds the fundamental data related to a block in the blockchain, without including the actual transactions.
    /// </summary>
    /// <remarks>
    /// A block header in Chia contains several components including proofs, sub slots, foliage, reward chain block, and transactions filter.
    /// The detailed information can be found at: <see href="https://docs.chia.net/full-node-rpc#get_unfinished_block_headers"/>.
    /// </remarks>
    public class BlockHeader : ObjectTemplate<BlockHeader>
    {
        /// <summary>
        /// The proof of space for the challenge chain in the block.
        /// This is used to prove that a significant amount of space was allocated by the node that created the block, which helps secure the blockchain.
        /// </summary>
        public Proof? challenge_chain_sp_proof { get; set; }

        /// <summary>
        /// The finished sub slots for the block.
        /// Sub slots in Chia are periods of time in which blocks can be added to the blockchain. 
        /// Finished sub slots refer to the ones that are complete and have been added to the blockchain.
        /// </summary>
        public object[]? finished_sub_slots { get; set; }

        /// <summary>
        /// Represents the foliage in the JSON object.
        /// Foliage in the context of Chia refers to a part of the block structure that includes the transaction information, 
        /// but does not include the proofs and signatures.
        /// </summary>
        public Foliage? foliage { get; set; }

        /// <summary>
        /// The foliage transaction block which includes the transaction information of the block.
        /// This block is a part of the block structure that is created once the transactions for the block are known.
        /// </summary>
        public FoliageTransactionBlock? foliage_transaction_block { get; set; }

        /// <summary>
        /// The reward chain block of the block header.
        /// The reward chain is a part of the Chia block structure that is responsible for distributing farming rewards.
        /// </summary>
        public RewardChainBlock? reward_chain_block { get; set; }

        /// <summary>
        /// The proof of space for the reward chain in the block.
        /// This proof is used to ensure that a significant amount of space was allocated by the node that created the block,
        /// specifically for the reward chain part of the block structure.
        /// </summary>
        public Proof? reward_chain_sp_proof { get; set; }

        /// <summary>
        /// The transactions filter of the block.
        /// This is used to quickly check if a transaction is included in the block without having to download the entire block.
        /// </summary>
        public string? transactions_filter { get; set; }
    }

}
