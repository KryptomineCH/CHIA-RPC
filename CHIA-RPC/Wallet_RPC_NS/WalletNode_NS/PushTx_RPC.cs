using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    /// <summary>
    /// Push a spend bundle (transaction) to the blockchain
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#push_tx"/>
    /// </remarks>
    public class PushTx_RPC : RPCTemplate<PushTx_RPC>
    {
        /// <summary>
        /// The spend bundle (transaction) to push
        /// </summary>
        public SpendBundle spend_bundle { get; set; }
    }
}
