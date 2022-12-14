namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    public class GetNetworkInfo_Response
    {
        /// <summary>
        /// eg mainnet or testnet
        /// </summary>
        public string network_name { get; set; }
        /// <summary>
        /// eg xch or txch
        /// </summary>
        public string network_prefix { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
