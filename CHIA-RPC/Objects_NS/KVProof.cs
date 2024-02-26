using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Represents the detailed structure of the proof including coin ID, inner puzzle hash, and store proofs.
    /// This is used to get a merkle proof of a datalayer store keyvalue pair
    /// </summary>
    /// <remarks>
    /// used by Datalayer<br/>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_proof"/>
    /// </remarks>
    public class KvProof : ObjectTemplate<KvProof>
    {
        /// <summary>
        /// The coin ID for which the proof is provided.
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// The hash of the inner puzzle associated with the coin.
        /// </summary>
        public string inner_puzzle_hash { get; set; }

        /// <summary>
        /// Contains the proofs for the store including each proof's details and the store ID.
        /// </summary>
        public KvStoreProofs store_proofs { get; set; }
    }
    /// <summary>
    /// Contains the store proofs and the store ID where the proof was generated.
    /// </summary>
    public class KvStoreProofs
    {
        /// <summary>
        /// An array of individual proofs for each requested key.
        /// </summary>
        public KvProofDetails[] proofs { get; set; }

        /// <summary>
        /// The store ID to which the proofs pertain.
        /// </summary>
        public string store_id { get; set; }
    }

    /// <summary>
    /// Represents the details of an individual proof including the key and value CLVM hashes,
    /// the node hash, and the layers involved in the proof.
    /// </summary>
    public class KvProofDetails
    {
        /// <summary>
        /// The hash of the CLVM key.
        /// </summary>
        public string key_clvm_hash { get; set; }

        /// <summary>
        /// An array representing the layers involved in the proof.
        /// </summary>
        public string[] layers { get; set; }

        /// <summary>
        /// The hash of the node to which this proof pertains.
        /// </summary>
        public string node_hash { get; set; }

        /// <summary>
        /// The hash of the CLVM value.
        /// </summary>
        public string value_clvm_hash { get; set; }
    }
}
