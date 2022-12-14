namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    public class GetSyncStatus_Response
    {
        public bool genesis_initialized { get; set; }
        public bool synced { get; set; }
        public bool syncing { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
