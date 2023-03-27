using CHIA_RPC.HelperFunctions_NS;
using System.ComponentModel.DataAnnotations;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// Given a public key, message and signature, verify if it is valid.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#verify_signature"/></remarks>
    /// <returns>?</returns>
    public class VerifySignature_RPC : RPCTemplate<VerifySignature_RPC>
    {
        /// <summary>
        /// The public key of the signature to verify
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string pubkey { get; set; }
        /// <summary>
        /// The message to verify
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string message { get; set; }
        /// <summary>
        /// The signature to verify
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string signature { get; set; }
        /// <summary>
        /// The address, which must be derived from pubkey
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string address { get; set; }
    }
}
