using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Datalayer_NS
{
    // TODO: Xunit Test

    /// <summary>
    /// Represents the response from verifying a Merkle proof of inclusion.
    /// <br/>Functionality: Indicates whether the proof of inclusion for a given coin ID and inner puzzle hash is valid.
    /// <br/>Usage: Result of chia rpc data_layer verify_proof [REQUEST].
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#verify_proof"/><br/><br/>
    /// Uses:<br/><see cref="VerifyProof_RPC"/>
    /// </remarks>
    public class VerifyProof_Response : ResponseTemplate<VerifyProof_Response>
    {
        /// <summary>
        /// Indicates if the data chains to the current published root. True means the data would be present if synced.
        /// <br/>Type: BOOLEAN.
        /// <br/>Required: True.
        /// </summary>
        public bool current_root { get; set; }

        /// <summary>
        /// Contains the verified CLVM hashes including 'key_clvm_hash' and 'value_clvm_hash' within 'inclusions', and 'store_id'.
        /// <br/>Type: Object.
        /// <br/>Required: True.
        /// </summary>
        public Datalayer_VerifiedClvmHashes verified_clvm_hashes { get; set; }
    }

    /// <summary>
    /// Represents a request to verify a Merkle proof of inclusion for a given coin ID and inner puzzle hash.
    /// <br/>Functionality: Verifies a Merkle proof of inclusion.
    /// <br/>Usage: chia rpc data_layer verify_proof [REQUEST].
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc/#verify_proof"/></remarks>
    /// <returns><see cref="VerifyProof_Response"/></returns>
    public class VerifyProof_RPC : RPCTemplate<VerifyProof_RPC>
    {
        /// <summary>
        /// The proof to verify; requires a 'proofs' parameter, which must contain the following parameters: 
        /// 'key_clvm_hash', 'value_clvm_hash', 'node_hash', 'layers'. 
        /// <br/>Type: STRING.
        /// <br/>Required: True.
        /// </summary>
        public string store_proofs { get; set; }

        /// <summary>
        /// The ID of the coin to retrieve.
        /// <br/>Type: STRING.
        /// <br/>Required: True.
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// The proof's inner puzzle hash.
        /// <br/>Type: STRING.
        /// <br/>Required: True.
        /// </summary>
        public string inner_puzzle_hash { get; set; }
    }
}
