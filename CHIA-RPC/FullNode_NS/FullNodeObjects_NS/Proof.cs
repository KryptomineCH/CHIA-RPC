using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents the challenge_chain_sp_proof in the JSON object
    /// </summary>
    public class Proof : ObjectTemplate<Proof>
    {
        /// <summary>
        /// Indicates whether the proof is normalized to identity
        /// </summary>
        public bool normalized_to_identity { get; set; }

        /// <summary>
        /// The witness of the proof
        /// </summary>
        public string witness { get; set; }

        /// <summary>
        /// The witness type of the proof
        /// </summary>
        public ulong witness_type { get; set; }
    }
}
