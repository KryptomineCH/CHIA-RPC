
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
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
        public ulong farmed_amount { get; set; }
        public ulong farmer_reward_amount { get; set; }
        public ulong fee_amount { get; set; }
        public ulong last_height_farmed { get; set; }
        public ulong pool_reward_amount { get; set; }
    }
}
