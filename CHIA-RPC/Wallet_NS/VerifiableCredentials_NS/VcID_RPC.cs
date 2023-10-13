using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.VerifiableCredentials_NS.VerifiableCredentialsObjects_NS;

namespace CHIA_RPC.Wallet_NS.VerifiableCredentials_NS
{
    /// <summary>
    /// Represents the server response for the `vc_get` RPC call.
    /// </summary>
    /// <remarks>
    /// This RPC returns the vc_record representing the specified Verifiable Credential.
    /// <see href="https://docs.chia.net/wallet-rpc#vc_get"/>
    /// </remarks>
    public class VcGet_Response : ResponseTemplate<VcGet_Response>
    {
        /// <summary>
        /// Represents the Verifiable Credential record.
        /// </summary>
        public VcRecord vc_record { get; set; }
    }
    /// <summary>
    /// Represents a request to get the Verifiable Credential given a launcher ID.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#vc_get"/>
    /// This RPC returns the vc_record representing the specified Verifiable Credential.
    /// </remarks>
    public class VcID_RPC : RPCTemplate<VcID_RPC>
    {
        /// <summary>
        /// The launcher ID of a Verifiable Credential.
        /// </summary>
        public string vc_id { get; set; }
    }

}
