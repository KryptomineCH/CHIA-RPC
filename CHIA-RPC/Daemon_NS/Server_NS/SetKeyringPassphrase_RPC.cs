using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the RPC request for setting a new keyring passphrase.
    /// </summary>
    ///
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#set_keyring_passphrase"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Use this RPC request to set or update the passphrase for the keyring.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `current_passphrase`: The current passphrase. Use an empty string if none is set. Type: <see cref="string"/>.<br/>
    /// - `new_passphrase`: The new passphrase to set. Must be at least 8 characters long. Type: <see cref="string"/>.<br/>
    /// - `passphrase_hint`: An optional hint for the new passphrase. Type: <see cref="string"/>?.<br/>
    /// - `save_passphrase`: Optional flag to save the new passphrase to the system's secure credential store. Type: <see cref="bool"/>?.<br/>
    /// </remarks>
    ///
    /// <returns>
    /// <see cref="Success_Response"/>
    /// </returns>
    public class SetKeyringPassphrase_RPC : RPCTemplate<SetKeyringPassphrase_RPC>
    {
        /// <summary>
        /// The current passphrase. Use an empty string if none is set.
        /// </summary>
        public string current_passphrase { get; set; }

        /// <summary>
        /// The new passphrase to set. Must be at least 8 characters long by default.
        /// </summary>
        public string new_passphrase { get; set; }

        /// <summary>
        /// An optional hint for the new passphrase.
        /// </summary>
        public string? passphrase_hint { get; set; }

        /// <summary>
        /// Optional flag to save the new passphrase to the system's secure credential store.
        /// <br/>
        /// Default is False.
        /// </summary>
        public bool? save_passphrase { get; set; }
    }
}
