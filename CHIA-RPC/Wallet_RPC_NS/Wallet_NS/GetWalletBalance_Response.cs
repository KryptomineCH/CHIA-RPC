using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class GetWalletBalance_Response : ResponseTemplate<GetWalletBalance_Response>
    {
        public WalletBalanceInfo wallet_balance { get; set; }
    }
    public class WalletBalanceInfo
    {
        public ulong confirmed_wallet_balance { get; set; }
        public ulong fingerprint { get; set; }
        public ulong max_send_amount { get; set; }
        public ulong pending_change { get; set; }
        public ulong pending_coin_removal_count { get; set; }
        public ulong spendable_balance { get; set; }
        public ulong unconfirmed_wallet_balance { get; set; }
        public ulong unspent_coin_count { get; set; }
        public ulong wallet_id { get; set; }
        public WalletType wallet_type { get; set; }
    }
}
