using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Response for getting payout targets for the farmer and pool
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/farmer-rpc#get_reward_targets"/><br/><br/>
    /// Uses:<br/><see cref="GetRewardTargets_RPC"/>
    /// </remarks>
    public class GetRewardTargets_Response : ResponseTemplate<GetRewardTargets_Response>
    {
        /// <summary>
        /// Payout target for the farmer (1/8 of the reward)
        /// </summary>
        public string farmer_target { get; set; }

        /// <summary>
        /// Payout target for the pool (7/8 of the reward)
        /// </summary>
        public string pool_target { get; set; }
    }
    /// <summary>
    /// List the payout targets for the farmer (1/8 of the reward) and pool (7/8)
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/farmer-rpc#get_reward_targets"/></remarks>
    /// <returns><see cref="GetRewardTargets_Response"/></returns>
    public class GetRewardTargets_RPC : RPCTemplate<GetRewardTargets_RPC>
    {
        /// <summary>
        /// List whether the private key (sk) is available for both the farmer and pool keys
        /// </summary>
        public bool search_for_private_key { get; set; }

        /// <summary>
        /// The maximum number of puzzle hashes to search [Default: 500] 
        /// If the wallet's derivation index is large, this number may be insufficient to locate the correct puzzle hashes. In this case, you may need to increase this value
        /// </summary>
        public ulong? max_ph_to_search { get; set; }
    }
}
