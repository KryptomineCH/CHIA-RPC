using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.VerifiableCredentials_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the response for the `vc_get_proofs_for_root` command in the Chia RPC API.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/vc-rpc#vc_get_proofs_for_root"/><br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `proofs`: Dictionary containing the proofs. The keys represent the names of the proofs and the values represent the proof data. Type: <see cref="Dictionary{string, string}"/>.
    /// </remarks>
    /// 
    /// <returns>
    /// - `proofs`: Dictionary containing the proofs.
    /// </returns>
    public class VcGetProofsForRoot_Response : ResponseTemplate<VcGetProofsForRoot_Response>
    {
        /// <summary>
        /// Dictionary containing the proofs. The keys represent the names of the proofs and the values represent the proof data.
        /// </summary>
        public Dictionary<string, string> proofs { get; set; }
    }

    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the request for the `vc_get_proofs_for_root` command in the Chia RPC API.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/vc-rpc#vc_get_proofs_for_root"/><br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `root`: The tree hash of a set of proofs that have been stored in the dictionary. Type: <see cref="string"/>.
    /// </remarks>
    /// 
    /// <returns>
    /// <see cref="VcGetProofsForRoot_Response"/>
    /// </returns>
    public class VcGetProofsForRoot_RPC : RPCTemplate<VcGetProofsForRoot_RPC>
    {
        /// <summary>
        /// The tree hash of a set of proofs that have been stored in the dictionary.
        /// </summary>
        public string root { get; set; }
    }

}
