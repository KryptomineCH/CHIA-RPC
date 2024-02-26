using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Datalayer_NS
{
    // TODO: Xunit Test

    /// <summary>
    /// Represents the server response for a request to obtain a merkle proof of inclusion for a given key.
    /// This class provides the necessary structure to deserialize the JSON response from a chia RPC call
    /// that fetches proofs for keys in a specified data layer store. The response contains details about
    /// the proof including coin ID, inner puzzle hash, and the proofs themselves with their respective
    /// hashes and layers, indicating a given key, value pair's inclusion in the data layer store.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_proof"/><br/><br/>
    /// Uses:<br/><see cref="GetProof_RPC"/>
    /// </remarks>
    public class GetProof_Response : ResponseTemplate<GetProof_Response>
    {
        /// <summary>
        /// The main proof object containing details about the coin, inner puzzle hash, and store proofs.
        /// </summary>
        public KvProof proof { get; set; }
    }

    /// <summary>
    /// Represents a JSON RPC request for obtaining a merkle proof of inclusion for a given key.
    /// This class is designed to be used with a chia RPC to get proofs for keys in a specified data layer store.
    /// The proof is a demonstration that a given key, value pair is included in the specified data layer store
    /// by chaining the Merkle hashes up to the published on-chain root hash. It supports generating proofs for
    /// multiple key, value pairs in the same datastore.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc/#get_proof"/></remarks>
    /// <returns><see cref="GetProof_Response"/></returns>
    public class GetProof_RPC : RPCTemplate<GetProof_RPC>
    {
        /// <summary>
        /// The hexadecimal store ID where the key, value pairs are stored.
        /// This property is required for the RPC request.
        /// </summary>
        public string store_id { get; set; }

        /// <summary>
        /// An array of keys for which to retrieve proofs. Each key should be a string representing
        /// the key for which the proof of inclusion is requested. This property is required for the
        /// RPC request.
        /// </summary>
        public string[] keys { get; set; }

        // Constructors are omitted as per the user's request.
    }

}
