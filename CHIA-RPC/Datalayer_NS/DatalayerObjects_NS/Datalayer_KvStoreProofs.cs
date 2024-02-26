using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// Contains the store proofs and the store ID where the proof was generated.
    /// </summary>
    /// <remarks>
    /// used by Datalayer<br/>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_proof"/>
    /// </remarks>
    public class Datalayer_KvStoreProofs : ObjectTemplate<Datalayer_KvStoreProofs>
    {
        /// <summary>
        /// An array of individual proofs for each requested key.
        /// </summary>
        public Datalayer_KvProofDetails[] proofs { get; set; }

        /// <summary>
        /// The store ID to which the proofs pertain.
        /// </summary>
        public string store_id { get; set; }
    }
}
