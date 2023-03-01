using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    public class GetPrivateKey_Response : ResponseTemplate<GetPrivateKey_Response>
    {
        public PrivateKeyInfo private_key { get; set; }
    }
}
