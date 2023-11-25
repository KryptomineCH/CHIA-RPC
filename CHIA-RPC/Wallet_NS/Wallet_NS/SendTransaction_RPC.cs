using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

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
        /// <param name="wallet_id">the wallet ID from which you want to send the transaction</param>
        /// <param name="address">the receiving address to send the mojos to</param>
        /// <param name="amount_mojos">the amount of mojos to send (max: 1867747965986)</param>
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
        /// <param name="wallet_id">the wallet ID from which you want to send the transaction</param>
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
            WalletID_RPC walletID_RPC, string address, ulong amount_mojos,
            ulong? fee_mojos = null, string[]? memos = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong[]? exclude_coin_amounts = null,
            string? exclude_coin_ids = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = walletID_RPC.wallet_id;
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
        /// <param name="wallet_id">the wallet ID from which you want to send the transaction</param>
        /// <param name="address">the receiving address to send the mojos to</param>
        /// <param name="amount_xch">the amount of mojos to send</param>
        /// <param name="fee_xch">the amount of mojos to set as fee</param>
        /// <param name="memos">memos for self and recipient (publicly readable)</param>
        /// <param name="min_coin_amount_xch">The minimum coin amount to send [Default: 0]</param>
        /// <param name="max_coin_amount_xch">The maximum coin amount to send [Default: 0]</param>
        /// <param name="exclude_coin_amounts_xch">A list of coin amounts to exclude</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude</param>
        /// <param name="reuse_puzhash">If true, will not generate a new puzzle hash / address for this transaction only</param>
        public SendTransaction_RPC(
            ulong wallet_id, string address, decimal amount_xch,
            decimal? fee_xch = null, string[]? memos = null, decimal? min_coin_amount_xch = null,
            decimal? max_coin_amount_xch = null, decimal[]? exclude_coin_amounts_xch = null,
            string? exclude_coin_ids = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.address = address;
            this.amount_in_xch = amount_xch;
            this.fee_in_xch = fee_xch;
            this.memos = memos;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.exclude_coin_amounts_in_xch = exclude_coin_amounts_xch;
            this.exclude_coin_ids = exclude_coin_ids;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// used to send chia (XCH) to a specific target address
        /// </summary>
        /// <param name="wallet_id">the wallet ID from which you want to send the transaction</param>
        /// <param name="address">the receiving address to send the mojos to</param>
        /// <param name="amount_xch">the amount of mojos to send</param>
        /// <param name="fee_xch">the amount of mojos to set as fee</param>
        /// <param name="memos">memos for self and recipient (publicly readable)</param>
        /// <param name="min_coin_amount_xch">The minimum coin amount to send [Default: 0]</param>
        /// <param name="max_coin_amount_xch">The maximum coin amount to send [Default: 0]</param>
        /// <param name="exclude_coin_amounts_xch">A list of coin amounts to exclude</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude</param>
        /// <param name="reuse_puzhash">If true, will not generate a new puzzle hash / address for this transaction only</param>
        public SendTransaction_RPC(
            WalletID_RPC walletID_RPC, string address, decimal amount_xch,
            decimal? fee_xch = null, string[]? memos = null, decimal? min_coin_amount_xch = null,
            decimal? max_coin_amount_xch = null, decimal[]? exclude_coin_amounts_xch = null,
            string? exclude_coin_ids = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = walletID_RPC.wallet_id;
            this.address = address;
            this.amount_in_xch = amount_xch;
            this.fee_in_xch = fee_xch;
            this.memos = memos;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.exclude_coin_amounts_in_xch = exclude_coin_amounts_xch;
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
        public string? address { get; set; }
        /// <summary>
        /// the amount of mojos to send
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong amount { get; set; }
        /// <summary>
        /// the amount of xch to send
        /// </summary>
        /// <remarks>mandatory</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// the amount of mojos to set as fee
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
        /// <summary>
        /// the amount of xch to set as fee
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? fee_in_xch
        {
            get { return fee / GlobalVar.OneChiaInMojos; }
            set { fee = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// memos for self and recipient (publicly readable)
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? memos { get; set; }
        /// <summary>
        /// The minimum coin amount in mojos to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// The minimum coin amount in xch to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? min_coin_amount_in_xch
        {
            get { return min_coin_amount / GlobalVar.OneChiaInMojos; }
            set { min_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// The maximum coin amount in mojos to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; } = 0;
        /// <summary>
        /// The maximum coin amount in xch to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? max_coin_amount_in_xch
        {
            get { return max_coin_amount / GlobalVar.OneChiaInMojos; }
            set { max_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// A list of coin amounts (in mojos) to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong[]? exclude_coin_amounts { get; set; }
        /// <summary>
        /// A list of coin amounts (in xch) to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal[]? exclude_coin_amounts_in_xch
        {
            get
            {
                if (exclude_coin_amounts == null) return null;
                decimal[] ex = new decimal[exclude_coin_amounts.Length];
                for (int i = 0; i < exclude_coin_amounts.Length; i++) ex[i] = (exclude_coin_amounts[i] / GlobalVar.OneChiaInMojos);
                return ex; 
            }
            set
            {
                if (value == null)
                {
                    exclude_coin_amounts = null;
                    return;
                }
                ulong[] ex = new ulong[value.Length];
                for (int i = 0; i < value.Length; i++) ex[i] = (ulong)(value[i] * GlobalVar.OneChiaInMojos);
                exclude_coin_amounts = ex;
            }
        }
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
