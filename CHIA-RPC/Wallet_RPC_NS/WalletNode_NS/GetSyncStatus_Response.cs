using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    /// <summary>
    /// Show whether the current wallet is syncing or synced
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_sync_status"/><br/><br/>
    /// Uses:<br/>the request does not have parameters
    /// </remarks>
    public class GetSyncStatus_Response : ResponseTemplate<GetSyncStatus_Response>
    {
        public bool genesis_initialized { get; set; }
        /// <summary>
        /// indicates wether the node sync has reached the newest (current) block or if it is still behind (synchronizing past blocks)
        /// </summary>
        public bool synced { get; set; }
        /// <summary>
        /// indicates wether the node is currently synchronizing or not
        /// </summary>
        public bool syncing { get; set; }
    }
}
