namespace CHIA_RPC.Objects_NS
{
    public class ProofOfSpace
    {
        public string challenge { get; set; }
        public string plot_public_key { get; set; }
        public string pool_contract_puzzle_hash { get; set; }
        public object pool_public_key { get; set; }
        public string proof { get; set; }
        public ulong size { get; set; }
    }
    /// <summary>
    /// Represents the challenge_chain_sp_proof in the JSON object
    /// </summary>
    public class Proof
    {
        /// <summary>
        /// Indicates whether the proof is normalized to identity
        /// </summary>
        public bool normalized_to_identity;

        /// <summary>
        /// The witness of the proof
        /// </summary>
        public string witness;

        /// <summary>
        /// The witness type of the proof
        /// </summary>
        public int witness_type;
    }
}
