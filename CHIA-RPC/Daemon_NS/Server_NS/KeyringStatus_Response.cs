using CHIA_RPC.Daemon_NS.Server_NS.ServerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the server response for the 'keyring_status' RPC command.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#keyring_status"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Provides detailed information about the keyring status.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - the request is parameterless
    /// </remarks>
    /// 
    /// <returns>
    /// - `can_save_passphrase`: Indicates if the keyring can save the passphrase. Type: <see cref="bool"/><br/>
    /// - `can_set_passphrase_hint`: Indicates if the keyring can set the passphrase hint. Type: <see cref="bool"/><br/>
    /// - `is_keyring_locked`: Indicates if the keyring is locked. Type: <see cref="bool"/><br/>
    /// - `passphrase_hint`: Provides the passphrase hint, if any. Type: <see cref="string"/>?<br/>
    /// - `passphrase_requirements`: Details about the passphrase requirements. Type: <see cref="PassphraseRequirements"/><br/>
    /// - `user_passphrase_is_set`: Indicates if the user passphrase is set. Type: <see cref="bool"/><br/>
    /// </returns>
    public class KeyringStatus_Response : ResponseTemplate<KeyringStatus_Response>
    {
        /// <summary>
        /// Indicates if the keyring can save the passphrase.
        /// </summary>
        public bool can_save_passphrase { get; set; }

        /// <summary>
        /// Indicates if the keyring can set the passphrase hint.
        /// </summary>
        public bool can_set_passphrase_hint { get; set; }

        /// <summary>
        /// Indicates if the keyring is locked.
        /// </summary>
        public bool is_keyring_locked { get; set; }

        /// <summary>
        /// Provides the passphrase hint, if any.
        /// </summary>
        public string? passphrase_hint { get; set; }

        /// <summary>
        /// Details about the passphrase requirements.
        /// </summary>
        public PassphraseRequirements passphrase_requirements { get; set; }

        /// <summary>
        /// Indicates if the user passphrase is set.
        /// </summary>
        public bool user_passphrase_is_set { get; set; }
    }
}
