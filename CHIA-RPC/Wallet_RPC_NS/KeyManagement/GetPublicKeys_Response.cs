namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    public class GetPublicKeys_Response
    {
        public ulong[] public_key_fingerprints { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
