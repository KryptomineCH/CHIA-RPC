using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.WalletNode_NS
{
    /// <summary>
    /// Represents a JSON RPC request for the "set_wallet_resync_on_startup" command in the Chia wallet.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#set_wallet_resync_on_startup"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class SetWalletResyncOnStartup_RPC : RPCTemplate<SetWalletResyncOnStartup_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public SetWalletResyncOnStartup_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents a JSON RPC request for the "set_wallet_resync_on_startup" command in the Chia wallet.
        /// </summary>
        /// <param name="enable">Set to true to enable resync. Defaults to true if not provided.</param>
        public SetWalletResyncOnStartup_RPC(bool? enable)
        {
            this.enable = enable;
        }

        /// <summary>
        /// Set to true to enable resync. Defaults to true if not provided.
        /// </summary>
        public bool? enable { get; set; }
    }
}
