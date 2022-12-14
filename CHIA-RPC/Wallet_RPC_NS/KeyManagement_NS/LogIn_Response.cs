namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    public class LogIn_Response
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
