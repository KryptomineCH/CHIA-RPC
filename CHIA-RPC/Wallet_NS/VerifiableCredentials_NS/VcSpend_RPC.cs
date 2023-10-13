using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;

namespace CHIA_RPC.Wallet_NS.VerifiableCredentials_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents a request to spend a Verifiable Credential in the Chia blockchain.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/vc-rpc#vc_spend"/><br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `vc_id`: The launcher ID of the Verifiable Credential to spend. Type: <see cref="string"/>.<br/>
    /// - `new_puzhash`: The puzzle hash where the VC will be sent. Type: <see cref="string"/>?.<br/>
    /// - `new_proof_hash`: Can be used to update the vc's proofs. Type: <see cref="string"/>?.<br/>
    /// - `provider_inner_puzhash`: Used to update the vc's proofs by specifying the proof provider's inner puzzle hash. Type: <see cref="string"/>?.<br/>
    /// - `reuse_puzhash`: Flag to send the VC back to the same puzzle hash. Type: <see cref="bool"/>?.<br/>
    /// - `fee`: An optional blockchain fee, expressed in mojos. Type: <see cref="ulong"/>?.<br/>
    /// </remarks>
    /// 
    /// <returns>
    /// <see cref="GetTransactions_Response"/>
    /// </returns>
    public class VcSpend_RPC : RPCTemplate<VcSpend_RPC>
    {
        /// <summary>
        /// The launcher ID of the Verifiable Credential to spend.
        /// </summary>
        public string vc_id { get; set; }

        /// <summary>
        /// The puzzle hash where the VC will be sent. This can be derived from an XCH address.
        /// </summary>
        public string? new_puzhash { get; set; }

        /// <summary>
        /// Can be used to update the vc's proofs by specifying the new root/proof hash.
        /// </summary>
        public string? new_proof_hash { get; set; }

        /// <summary>
        /// Can be used to update the vc's proofs by specifying the proof provider's inner puzzle hash.
        /// </summary>
        public string? provider_inner_puzhash { get; set; }

        /// <summary>
        /// If this flag is set, then send the VC back to the same puzzle hash it came from.
        /// </summary>
        public bool? reuse_puzhash { get; set; }

        /// <summary>
        /// An optional blockchain fee, expressed in mojos.
        /// </summary>
        public ulong? fee { get; set; }
        
    }

}
