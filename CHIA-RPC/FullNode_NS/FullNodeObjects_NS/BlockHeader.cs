using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_unfinished_block_headers"/>
    /// </remarks>
    public class BlockHeader : ObjectTemplate<BlockHeader>
    {
        public Proof challenge_chain_sp_proof { get; set; }
        public object[] finished_sub_slots { get; set; }
        /// <summary>
        /// Represents the foliage in the JSON object
        /// </summary>
        public Foliage foliage { get; set; }
        public FoliageTransactionBlock foliage_transaction_block { get; set; }
        public RewardChainBlock reward_chain_block { get; set; }
        public Proof reward_chain_sp_proof { get; set; }
        public string transactions_filter { get; set; }


    }
}
