namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    public class GenerateMnemonic_Response
    {
        /// <summary>
        /// 24 word mnemonic passphrase for the wallet
        /// </summary>
        public string[] mnemonic { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
