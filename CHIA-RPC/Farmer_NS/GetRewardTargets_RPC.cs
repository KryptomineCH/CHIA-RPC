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
        /// parameterless constructor, for serializer
        /// </summary>
        public GetRewardTargets_RPC () { /* for serialisation */ }

        /// <summary>
        /// List the payout targets for the farmer (1/8 of the reward) and pool (7/8)
        /// </summary>
        /// <param name="search_for_private_key">List whether the private key (sk) is available for both the farmer and pool keys</param>
        /// <param name="max_ph_to_search">The maximum number of puzzle hashes to search [Default: 500] </param>
        public GetRewardTargets_RPC(bool search_for_private_key, ulong? max_ph_to_search = null)
        {
            this.search_for_private_key = search_for_private_key;
            this.max_ph_to_search = max_ph_to_search;
        }


        /// <summary>
        /// List whether the private key (sk) is available for both the farmer and pool keys
        /// </summary>
        /// The number of entries per page to list.
        public bool search_for_private_key { get; set; }

        /// <summary>
        /// The maximum number of puzzle hashes to search [Default: 500] 
        /// If the wallet's derivation index is large, this number may be insufficient to locate the correct puzzle hashes. In this case, you may need to increase this value
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_ph_to_search { get; set; }
    }
}
