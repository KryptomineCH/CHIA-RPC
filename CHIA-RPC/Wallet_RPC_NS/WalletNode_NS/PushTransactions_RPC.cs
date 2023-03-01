using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    public class PushTransactions_RPC : RPCTemplate<PushTransactions_RPC>
    {
        public SpendBundle[] transactions { get; set; }
    }
}
