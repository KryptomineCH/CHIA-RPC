using CHIA_RPC.HelperFunctions_NS;
using System.ComponentModel.DataAnnotations;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// used to send chia (XCH) to a specific target address
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#send_transaction"/></remarks>
    /// <returns><see cref="General_NS.TransactionID_Response"/></returns>
    public class SendTransaction_RPC : RPCTemplate<SendTransaction_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public SendTransaction_RPC() { /* for serialisation*/ }
        /// <summary>
        /// used to send chia (XCH) to a specific target address
        /// </summary>
        /// <param name="wallet_id">the wallet ID from which you want to send the transactionparam>
        /// <param name="address">the receiving address to send the mojos to</param>
        /// <param name="amount_mojos">the amount of mojos to send</param>
        /// <param name="fee_mojos">the amount of mojos to set as fee</param>
        /// <param name="memos">memos for self and recipient (publicly readable)</param>
        /// <param name="min_coin_amount">The minimum coin amount to send [Default: 0]</param>
        /// <param name="max_coin_amount">The maximum coin amount to send [Default: 0]</param>
        /// <param name="exclude_coin_amounts">A list of coin amounts to exclude</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude</param>
        /// <param name="reuse_puzhash">If true, will not generate a new puzzle hash / address for this transaction only</param>
        public SendTransaction_RPC(
            ulong wallet_id, string address, ulong amount_mojos, 
            ulong? fee_mojos = null, string[]? memos = null, ulong? min_coin_amount = null, 
            ulong? max_coin_amount = null, ulong[]? exclude_coin_amounts = null, 
            string? exclude_coin_ids = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.address = address;
            this.amount = amount_mojos;
            this.fee = fee_mojos;
            this.memos = memos;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.exclude_coin_ids = exclude_coin_ids;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// used to send chia (XCH) to a specific target address
        /// </summary>
        /// <param name="wallet_id">the wallet ID from which you want to send the transactionparam>
        /// <param name="address">the receiving address to send the mojos to</param>
        /// <param name="amount_mojos">the amount of mojos to send</param>
        /// <param name="fee_xch">the amount of chia to set as fee</param>
        /// <param name="memos">memos for self and recipient (publicly readable)</param>
        /// <param name="min_coin_amount">The minimum coin amount to send [Default: 0]</param>
        /// <param name="max_coin_amount">The maximum coin amount to send [Default: 0]</param>
        /// <param name="exclude_coin_amounts">A list of coin amounts to exclude</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude</param>
        /// <param name="reuse_puzhash">If true, will not generate a new puzzle hash / address for this transaction only</param>
        public SendTransaction_RPC(
            ulong wallet_id, string address, ulong amount_mojos,
            double? fee_xch = null, string[]? memos = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong[]? exclude_coin_amounts = null,
            string? exclude_coin_ids = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.address = address;
            this.amount = amount;
            this.fee = (ulong)((decimal)fee_xch/ General_NS.GlobalVar.OneChiaInMojos);
            this.memos = memos;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.exclude_coin_ids = exclude_coin_ids;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// used to send chia (XCH) to a specific target address
        /// </summary>
        /// <param name="wallet_id">the wallet ID from which you want to send the transactionparam>
        /// <param name="address">the receiving address to send the mojos to</param>
        /// <param name="amount_xch">the amount of chia to send</param>
        /// <param name="fee_xch">the amount of chia to set as fee</param>
        /// <param name="memos">memos for self and recipient (publicly readable)</param>
        /// <param name="min_coin_amount">The minimum coin amount to send [Default: 0]</param>
        /// <param name="max_coin_amount">The maximum coin amount to send [Default: 0]</param>
        /// <param name="exclude_coin_amounts">A list of coin amounts to exclude</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude</param>
        /// <param name="reuse_puzhash">If true, will not generate a new puzzle hash / address for this transaction only</param>
        public SendTransaction_RPC(
            ulong wallet_id, string address, double amount_xch,
            double? fee_xch = null, string[]? memos = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong[]? exclude_coin_amounts = null,
            string? exclude_coin_ids = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.address = address;
            this.amount = (ulong)((decimal)amount_xch * General_NS.GlobalVar.OneChiaInMojos);
            this.fee = (ulong)((decimal)fee_xch * General_NS.GlobalVar.OneChiaInMojos);
            this.memos = memos;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.exclude_coin_ids = exclude_coin_ids;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// used to send chia (XCH) to a specific target address
        /// </summary>
        /// <param name="wallet_id">the wallet ID from which you want to send the transactionparam>
        /// <param name="address">the receiving address to send the mojos to</param>
        /// <param name="amount_xch">the amount of mojos to send</param>
        /// <param name="fee_mojos">the amount of mojos to set as fee</param>
        /// <param name="memos">memos for self and recipient (publicly readable)</param>
        /// <param name="min_coin_amount">The minimum coin amount to send [Default: 0]</param>
        /// <param name="max_coin_amount">The maximum coin amount to send [Default: 0]</param>
        /// <param name="exclude_coin_amounts">A list of coin amounts to exclude</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude</param>
        /// <param name="reuse_puzhash">If true, will not generate a new puzzle hash / address for this transaction only</param>
        public SendTransaction_RPC(
            ulong wallet_id, string address, double amount_xch,
            ulong? fee_mojos = null, string[]? memos = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong[]? exclude_coin_amounts = null,
            string? exclude_coin_ids = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.address = address;
            this.amount = (ulong)((decimal)amount_xch * General_NS.GlobalVar.OneChiaInMojos);
            this.fee = fee_mojos;
            this.memos = memos;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.exclude_coin_ids = exclude_coin_ids;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// the wallet ID from which you want to send the transaction
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// the receiving address to send the mojos to
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string address { get; set; }
        /// <summary>
        /// the amount of mojos to send
        /// </summary>
        /// <remarks>mandatory</remarks>
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
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// The maximum coin amount to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; } = 0;
        /// <summary>
        /// A list of coin amounts to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong[]? exclude_coin_amounts { get; set; }
        /// <summary>
        /// A list of coin IDs to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public string? exclude_coin_ids { get; set; }
        /// <summary>
        /// If true, will not generate a new puzzle hash / address for this transaction only. 
        /// Note that setting this parameter to true will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
