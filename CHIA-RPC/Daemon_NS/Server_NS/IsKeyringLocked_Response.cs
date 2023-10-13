using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the response received from the server to indicate the locked status of the keyring in a blockchain network.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#is_keyring_locked"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Serves as the response for the `is_keyring_locked` functionality.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - the request is parameterless<br/>
    /// </remarks>
    /// <returns>
    /// <see cref="is_keyring_locked"/>: Indicates whether the keyring is locked. Type: <see cref="bool"/>.
    /// </returns>
    public class IsKeyringLocked_Response : ResponseTemplate<IsKeyringLocked_Response>
    {
        /// <summary>
        /// Indicates whether the keyring is locked. <br/>
        /// <c>true</c> if the keyring is locked; otherwise, <c>false</c>.
        /// </summary>
        public bool is_keyring_locked { get; set; }
    }
}
