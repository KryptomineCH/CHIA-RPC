using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    /// <summary>
    /// Show public and private info about a key
    /// </summary>
    /// <remarks>may be requested with a finger print rpc.</remarks>
    public class GetPrivateKey_Response : ResponseTemplate<GetPrivateKey_Response>
    {
        /// <summary>
        /// Contains PRIVATE info about the currently logged in wallet. WARNING: This info is private!
        /// NEVER share it!
        /// </summary>
        public PrivateKeyInfo private_key { get; set; }
    }
}
