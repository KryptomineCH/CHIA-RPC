
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// Show the total amount that has been farmed
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#get_farmed_amount"/><br/><br/>
    /// Uses:<br/>This request does not have any Parameters
    /// </remarks>
    public class GetFarmedAmount_Response : ResponseTemplate<GetFarmedAmount_Response>
    {
        /// <summary>
        /// the total amount farmed, in mojos
        /// </summary>
        public ulong farmed_amount { get; set; }
        /// <summary>
        /// the total amount farmed, in xch
        /// </summary>
        [JsonIgnore]
        public decimal farmed_amount_in_xch
        {
            get { return farmed_amount / GlobalVar.OneChiaInMojos; }
            set { farmed_amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// the farmed block reward amount (newly created chia), in mojos
        /// </summary>
        public ulong farmer_reward_amount { get; set; }
        /// <summary>
        /// the farmed block reward amount (newly created chia), in xch
        /// </summary>
        [JsonIgnore]
        public decimal farmer_reward_amount_in_xch
        {
            get { return farmer_reward_amount / GlobalVar.OneChiaInMojos; }
            set { farmer_reward_amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// the amount of earned fees, in mojos
        /// </summary>
        public ulong fee_amount { get; set; }
        /// <summary>
        /// the amount of earned fees, in xch
        /// </summary>
        [JsonIgnore]
        public decimal fee_amount_in_xch
        {
            get { return fee_amount / GlobalVar.OneChiaInMojos; }
            set { fee_amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// the last block height where you found a block
        /// </summary>
        public ulong last_height_farmed { get; set; }
        /// <summary>
        /// the amount farmed through a pool, in mojos
        /// </summary>
        public ulong pool_reward_amount { get; set; }
        /// <summary>
        /// the amount farmed through a pool, in xch
        /// </summary>
        [JsonIgnore]
        public decimal pool_reward_amount_in_xch
        {
            get { return pool_reward_amount / GlobalVar.OneChiaInMojos; }
            set { pool_reward_amount_in_xch = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
    }
}
