using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.VerifiableCredentials_NS.VerifiableCredentialsObjects_NS
{
    /// <summary>
    /// Represents the proof object in a Verifiable Credential.
    /// </summary>
    public class VcProof : ObjectTemplate<VcProof>
    {
        /// <summary>
        /// Amount associated with the Verifiable Credential proof.
        /// </summary>
        public ulong amount { get; set; }

        /// <summary>
        /// Inner puzzle hash.
        /// </summary>
        public string? inner_puzzle_hash { get; set; }

        /// <summary>
        /// Parent name, usually a hash string.
        /// </summary>
        public string parent_name { get; set; }

        /// <summary>
        /// Parent proof hash.
        /// </summary>
        public string? parent_proof_hash { get; set; }
    }

}
