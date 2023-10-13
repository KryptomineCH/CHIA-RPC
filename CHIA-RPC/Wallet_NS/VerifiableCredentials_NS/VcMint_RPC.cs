using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.VerifiableCredentials_NS.VerifiableCredentialsObjects_NS;

namespace CHIA_RPC.Wallet_NS.VerifiableCredentials_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the server response for minting a Verifiable Credential using the assigned DID.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/vc-rpc#vc_mint"/><br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `transactions`: Represents the transactions related to the minting process. Type: <see cref="Transaction_DictMemos"/>[].<br/>
    /// - `vc_record`: Represents the VC record containing all the information of the soon-to-be-confirmed VC. Type: <see cref="VcRecord"/>.<br/>
    /// </remarks>
    /// 
    /// <returns>
    /// - `transactions`: Array of transaction-related memos.<br/>
    /// - `vc_record`: VC record data.
    /// </returns>
    public class VcMint_Response : ResponseTemplate<VcMint_Response>
    {
        /// <summary>
        /// Represents the transactions related to the minting process.
        /// </summary>
        public Transaction_DictMemos[] transactions { get; set; }

        /// <summary>
        /// Represents the VC record containing all the information of the soon-to-be-confirmed VC.
        /// </summary>
        public VcRecord vc_record { get; set; }
    }
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the RPC request for the `vc_mint` command in the Chia RPC API.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/vc-rpc#vc_mint"/><br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `did_id`: The ID of the DID that will be minting the VC. Type: <see cref="string"/>.<br/>
    /// - `target_address`: The address where the VC will be sent upon minting. Type: <see cref="string"/>?.<br/>
    /// - `fee`: An optional blockchain fee, specified in mojos. Type: <see cref="ulong"/>?.<br/>
    /// </remarks>
    /// 
    /// <returns>
    /// <see cref="VcMint_Response"/>
    /// </returns>
    public class VcMint_RPC : RPCTemplate<VcMint_RPC>
    {
        /// <summary>
        /// The ID of the DID that will be minting the VC.
        /// </summary>
        public string did_id { get; set; }

        /// <summary>
        /// The address where the VC will be sent upon minting.<br/>
        /// This is an optional field. If not provided, the VC will be sent to the minting wallet by default.
        /// </summary>
        public string? target_address { get; set; }

        /// <summary>
        /// An optional blockchain fee, specified in mojos.<br/>
        /// This is an optional field. If not provided, the default fee will be used.
        /// </summary>
        public ulong? fee { get; set; }
    }

}
