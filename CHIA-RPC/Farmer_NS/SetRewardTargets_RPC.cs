using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Represents the RPC request to set the farmer and/or pool reward target address(es).
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/farmer-rpc#set_reward_targets"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class SetRewardTargets_RPC : RPCTemplate<SetRewardTargets_RPC>
    {
        /// <summary>
        /// Represents the RPC request to set the farmer and/or pool reward target address(es).
        /// </summary>
        public SetRewardTargets_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents the RPC request to set the farmer and/or pool reward target address(es).
        /// </summary>
        /// <param name="farmer_target">Gets or sets the farmer reward target.</param>
        /// <param name="pool_target"> Gets or sets the pool reward target.</param>
        public SetRewardTargets_RPC(string? farmer_target = null, string? pool_target = null)
        {
            this.farmer_target = farmer_target;
            this.pool_target = pool_target;
        }

        /// <summary>
        /// Gets or sets the farmer reward target.
        /// </summary>
        /// <remarks>optional</remarks>
        public string? farmer_target { get; set; }

        /// <summary>
        /// Gets or sets the pool reward target.
        /// </summary>
        /// <remarks>optional</remarks>
        public string? pool_target { get; set; }
    }
}
