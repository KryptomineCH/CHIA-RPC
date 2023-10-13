

using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.VerifiableCredentials_NS.VerifiableCredentialsObjects_NS
{
    /// <summary>
    /// Represents the details of the Verifiable Credential.
    /// </summary>
    public class Vc : ObjectTemplate<Vc>
    {
        /// <summary>
        /// Coin details.
        /// </summary>
        public Coin coin { get; set; }

        /// <summary>
        /// EML lineage proof details.
        /// </summary>
        public VcProof eml_lineage_proof { get; set; }

        /// <summary>
        /// Inner puzzle hash.
        /// </summary>
        public string inner_puzzle_hash { get; set; }

        /// <summary>
        /// Launcher ID.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// Proof hash.
        /// </summary>
        public string? proof_hash { get; set; }

        /// <summary>
        /// Proof provider.
        /// </summary>
        public string proof_provider { get; set; }

        /// <summary>
        /// Singleton lineage proof.
        /// </summary>
        public VcProof singleton_lineage_proof { get; set; }
    }
}
