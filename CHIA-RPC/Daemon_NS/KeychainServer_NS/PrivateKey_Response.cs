using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.KeychainServer_NS
{
    /// <summary>
    /// Represents the server response for the get_first_private_key RPC call.
    /// Obtains the first private key, along with its entropy.
    /// Note that this command will fail if the OS key ring is locked.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/daemon-rpc#get_first_private_key"/>
    /// </remarks>
    public class PrivateKey_Response : ResponseTemplate<PrivateKey_Response>
    {
        /// <summary>
        /// Represents the entropy of the first private key.
        /// </summary>
        public string entropy { get; set; }

        /// <summary>
        /// Represents the private key (pk).
        /// </summary>
        public string pk { get; set; }
    }

}
