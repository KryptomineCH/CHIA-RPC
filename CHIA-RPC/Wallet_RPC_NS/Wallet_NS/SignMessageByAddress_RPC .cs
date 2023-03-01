using CHIA_RPC.HelperFunctions_NS;
using System.ComponentModel.DataAnnotations;
namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class SignMessage_Response : ResponseTemplate<SignMessage_Response>
    {
        public string pubkey { get; set; }
        public string signature { get; set; }
    }
    public class SignMessageByAddress_RPC : RPCTemplate<SignMessageByAddress_RPC>
    {
        /// <summary>
        /// The address to use for signing.Must possess the key for this address
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string address { get; set; }
        /// <summary>
        /// The message to include with the signature
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string message { get; set; }
    }
}
