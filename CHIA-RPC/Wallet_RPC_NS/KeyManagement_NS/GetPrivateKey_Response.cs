using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    public class GetPrivateKey_Response
    {
        public PrivateKeyInfo private_key { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
