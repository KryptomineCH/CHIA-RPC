
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.WalletManagement_NS
{
    public class CreateNewWallet_Response
    {
        public string asset_id { get; set; }
        public bool success { get; set; }
        public WalletType type { get; set; }
        public ulong wallet_id { get; set; }
        public string error { get; set; }
    }
}
