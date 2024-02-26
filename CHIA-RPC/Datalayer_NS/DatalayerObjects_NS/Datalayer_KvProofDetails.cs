using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// Represents the details of an individual proof including the key and value CLVM hashes,
    /// the node hash, and the layers involved in the proof.
    /// </summary>
    /// <remarks>
    /// used by Datalayer<br/>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_proof"/>
    /// </remarks>
    public class Datalayer_KvProofDetails : ObjectTemplate<Datalayer_KvProofDetails>
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
