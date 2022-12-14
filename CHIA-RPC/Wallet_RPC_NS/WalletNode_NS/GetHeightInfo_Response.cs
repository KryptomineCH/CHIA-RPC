namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    public class GetHeightInfo_Response
    {
        /// <summary>
        /// the currently synced height
        /// </summary>
        public ulong height { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
