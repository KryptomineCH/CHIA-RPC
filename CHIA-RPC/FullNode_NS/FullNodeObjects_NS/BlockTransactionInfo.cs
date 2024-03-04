
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents the details of a Transaction within a forged Block.
    /// </summary>
    public class BlockTransactionInfo : ObjectTemplate<BlockTransactionInfo>
    {
        /// <summary>
        /// The aggregated signature for the block, representing a combination of multiple signatures into a single one for efficiency.
        /// </summary>
        public string aggregated_signature { get; set; }

        /// <summary>
        /// The total cost of the block in terms of computational effort required to produce it.
        /// </summary>
        public ulong cost { get; set; }

        /// <summary>
        /// The total fees included in the block, paid for transactions included in this block.
        /// </summary>
        public ulong fees { get; set; }

        /// <summary>
        /// The root of the generator references, representing a summary of all the generators referenced by this block.
        /// </summary>
        public string generator_refs_root { get; set; }

        /// <summary>
        /// The root of the generator, summarizing the computation that produced this block.
        /// </summary>
        public string generator_root { get; set; }

        /// <summary>
        /// An array of reward claims incorporated in the block, detailing the rewards claimed by this block's transactions.
        /// </summary>
        public RewardClaim[] reward_claims_incorporated { get; set; }
    }
}
