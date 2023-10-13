using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.VerifiableCredentials_NS.VerifiableCredentialsObjects_NS
{
    /// <summary>
    /// Represents the Verifiable Credential record.
    /// </summary>
    public class VcRecord : ObjectTemplate<VcRecord>
    {
        /// <summary>
        /// The height at which the record was confirmed.
        /// </summary>
        public ulong confirmed_at_height { get; set; }

        /// <summary>
        /// Details of the Verifiable Credential.
        /// </summary>
        public Vc vc { get; set; }
    }
}
