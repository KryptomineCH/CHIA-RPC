using CHIA_RPC.HelperFunctions_NS;
using System.ComponentModel.DataAnnotations;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    /// <summary>
    /// used to send chia to a specific target address
    /// </summary>
    public class SendXCH_RPC : RPCTemplate<SendXCH_RPC>
    {
        /// <summary>
        /// the wallet ID from which you want to send the transaction
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong wallet_id { get; set; }
        /// <summary>
        /// the receiving address to send the mojos to
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string address { get; set; }
        /// <summary>
        /// the amount of mojos to send
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong amount { get; set; }
        /// <summary>
        /// the amount of mojos to set as fee
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong fee { get; set; }
        /// <summary>
        /// memos for self and recipient (publicly readable)
        /// </summary>
        /// <remarks>optional</remarks>
        public string[] memos { get; set; }
    }
}
