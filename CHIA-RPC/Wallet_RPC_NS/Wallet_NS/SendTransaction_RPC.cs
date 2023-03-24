using CHIA_RPC.HelperFunctions_NS;
using System.ComponentModel.DataAnnotations;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    /// <summary>
    /// used to send chia (XCH) to a specific target address
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#send_transaction"/></remarks>
    /// <returns><see cref="General_NS.TransactionID_Response"/></returns>
    public class SendTransaction_RPC : RPCTemplate<SendTransaction_RPC>
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
        public ulong? fee { get; set; }
        /// <summary>
        /// memos for self and recipient (publicly readable)
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? memos { get; set; }
        /// <summary>
        /// The minimum coin amount to send [Default: 0]
        /// </summary>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// The maximum coin amount to send [Default: 0]
        /// </summary>
        public ulong? max_coin_amount { get; set; } = 0;
        /// <summary>
        /// A list of coin amounts to exclude
        /// </summary>
        public ulong[]? exclude_coin_amounts { get; set; }
        /// <summary>
        /// A list of coin IDs to exclude
        /// </summary>
        public string? exclude_coin_ids { get; set; }
        /// <summary>
        /// If true, will not generate a new puzzle hash / address for this transaction only. 
        /// Note that setting this parameter to true will override the global default setting from config.yaml
        /// </summary>
        public bool? reuse_puzhash { get; set; }
    }
}
