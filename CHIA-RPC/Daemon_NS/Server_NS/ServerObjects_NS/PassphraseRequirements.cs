using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS.ServerObjects_NS
{
    /// <summary>
    /// Represents the requirements for the passphrase in the keyring status.
    /// </summary>
    public class PassphraseRequirements : ObjectTemplate<PassphraseRequirements>
    {
        /// <summary>
        /// Indicates if the passphrase is optional.
        /// </summary>
        public bool is_optional { get; set; }

        /// <summary>
        /// Specifies the minimum length for the passphrase.
        /// </summary>
        public ulong min_length { get; set; }
    }
}
