using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.KeyManagement
{
    /// <summary>
    /// Show public and private info about a key
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_private_key"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.FingerPrint_RPC"/>
    /// </remarks>
    public class GetPrivateKey_Response : ResponseTemplate<GetPrivateKey_Response>
    {
        /// <summary>
        /// Contains PRIVATE info about the currently logged in wallet. WARNING: This info is private!
        /// NEVER share it!
        /// </summary>
        public PrivateKeyInfo? private_key { get; set; }
    }
}
