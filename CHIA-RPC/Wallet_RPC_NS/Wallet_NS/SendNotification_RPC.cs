using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.ComponentModel.DataAnnotations;
namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class SendNotification_Response : ResponseTemplate<SendNotification_Response>
    {
        public Transaction tx { get; set; }
    }
    public class SendNotification_RPC : RPCTemplate<SendNotification_RPC>
    {
        /// <summary>
        /// The puzzle hash you would like to send a message to
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string target { get; set; }
        /// <summary>
        /// The hex-encoded message you would like to send
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string message { get; set; }
        /// <summary>
        /// The number of mojos to include with this message
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong amount { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong fee { get; set; }
    }
}
