using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Daemon_NS.KeychainServer_NS
{
    /// <summary>
    /// Represents the server response for the get_all_private_keys RPC call.
    /// This RPC lists all private keys, along with their respective entropies.<br/>
    /// Note that this command will fail if the OS key ring is locked.
    /// </summary>
    /// <remarks>
    /// Parameterless request<br/>
    /// <see href="https://docs.chia.net/daemon-rpc#get_all_private_keys"/></remarks>
    public class GetAllPrivateKeys_Response : ResponseTemplate<GetAllPrivateKeys_Response>
    {
        /// <summary>
        /// Array of all the private keys information.
        /// </summary>
        public PrivateKeyInfo[] private_keys { get; set; }
    }
}
