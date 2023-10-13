using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the RPC request to remove a passphrase from the keyring.
    /// </summary>
    ///
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#remove_keyring_passphrase"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Use this RPC call to remove a passphrase from the keyring.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `current_passphrase`: The current passphrase to be removed from the keyring. Type: <see cref="string"/>.
    /// </remarks>
    ///
    /// <returns>
    /// <see cref="Success_Response"/>
    /// </returns>

    public class RemoveKeyringPassphrase_RPC : RPCTemplate<RemoveKeyringPassphrase_RPC>
    {
        /// <summary>
        /// The current passphrase; if entered correctly, it will be removed from the keyring.
        /// <br/>
        /// This is a mandatory field.
        /// </summary>
        public string current_passphrase { get; set; }
    }

}
