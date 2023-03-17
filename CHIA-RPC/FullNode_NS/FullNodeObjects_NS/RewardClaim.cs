using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// A class to represent a reward claim
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block_record_by_height"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block_record"/>
    /// </remarks>
    public class RewardClaim : ObjectTemplate<RewardClaim>
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
