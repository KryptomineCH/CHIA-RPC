using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the RPC request for sending a key (password) to unlock the keyring.
    /// </summary>
    ///
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#unlock_keyring"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Used to unlock the keyring by providing a key.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `key`: The key to unlock. Optional. Type: <see cref="string"/>?
    /// </remarks>
    ///
    /// <returns><see cref="Success_Response"/></returns>

    public class UnlockKeyring_RPC : RPCTemplate<UnlockKeyring_RPC>
    {
        /// <summary>
        /// The key to unlock. Default is None.
        /// </summary>
        public string? key { get; set; }
    }

}
