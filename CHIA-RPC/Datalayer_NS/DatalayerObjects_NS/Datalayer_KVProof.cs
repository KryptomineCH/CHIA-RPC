using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// Represents the detailed structure of the proof including coin ID, inner puzzle hash, and store proofs.
    /// This is used to get a merkle proof of a datalayer store keyvalue pair
    /// </summary>
    /// <remarks>
    /// used by Datalayer<br/>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_proof"/>
    /// </remarks>
    public class Datalayer_KvProof : ObjectTemplate<Datalayer_KvProof>
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
        public Datalayer_KvStoreProofs store_proofs { get; set; }
    }
}
