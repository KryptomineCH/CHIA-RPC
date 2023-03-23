using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    /// <summary>
    /// Show all public key fingerprints (primary wallets) stored in the OS keyring. Note that the keyring must be unlocked in order to run this RPC
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_public_keys"/><br/><br/>
    /// Uses:<br/>this request does not have parameters
    /// </remarks>
    public class GetPublicKeys_Response : ResponseTemplate<GetPublicKeys_Response>
    {
        /// <summary>
        /// all public key fingerprints stored in the OS keyring
        /// </summary>
        public ulong[] public_key_fingerprints { get; set; }
    }
}
