using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    /// <summary>
    /// Push multiple transactions to the blockchain
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#push_transactions"/>
    /// </remarks>
    public class PushTransactions_RPC : RPCTemplate<PushTransactions_RPC>
    {
        /// <summary>
        /// A list of SpendBundles (transactions) to push
        /// </summary>
        public SpendBundle[] transactions { get; set; }
    }
}
