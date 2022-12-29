
namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class GetFarmedAmount_Response
    {
        public ulong farmed_amount { get; set; }
        public ulong farmer_reward_amount { get; set; }
        public ulong fee_amount { get; set; }
        public ulong last_height_farmed { get; set; }
        public ulong pool_reward_amount { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
