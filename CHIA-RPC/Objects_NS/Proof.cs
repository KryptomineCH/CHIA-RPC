using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Represents a cryptographic proof in the context of challenge_chain_sp_proof in the JSON object. 
    /// A proof demonstrates that a certain amount of computational work has been performed and it can be verified by others in the network.
    /// </summary>
    /// <remarks>
    /// used by full node and Datalayer<br/>
    /// In the context of Chia, a proof is often related to Proof of Space and Proof of Time. 
    /// Proofs are essential for maintaining the security and integrity of the network by ensuring that participants have followed the protocol rules.<br/>
    /// The Proof class contains information about whether the proof is normalized to identity, the witness, and the witness type.<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_blocks"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_recent_signage_point_or_eos"/>
    /// </remarks>
    public class Proof : ObjectTemplate<Proof>
    {
        /// <summary>
        /// Indicates whether the proof is normalized to identity
        /// </summary>
        public bool normalized_to_identity { get; set; }

        /// <summary>
        /// The witness of the proof, which is a piece of data that can be used to verify the proof's validity
        /// </summary>
        public string witness { get; set; }

        /// <summary>
        /// The witness type of the proof, which defines the specific verification method or algorithm use
        /// </summary>
        public ulong witness_type { get; set; }
    }
}
