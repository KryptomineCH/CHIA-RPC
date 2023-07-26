

using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// Class representing a JSON RPC request for the create_signed_transaction method.<br/>
    /// WARNING: could not be validated due to incomplete documentation
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#create_signed_transaction"/></remarks>
    public class CreateSignedTransaction_RPC : RPCTemplate<CreateSignedTransaction_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CreateSignedTransaction_RPC() { /* for serialisation */ }
        /// <summary>
        /// Class representing a JSON RPC request for the create_signed_transaction method.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="coins">A list of coins to include.</param>
        /// <param name="exclude_coins">A list of coins to exclude.</param>
        /// <param name="min_coin_amount_mojos">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount_mojos">The maximum coin amount to send (default: 0).</param>
        /// <param name="exclude_coin_amounts_mojos">A list of coin amounts to exclude.</param>
        /// <param name="coin_announcements">A list of coin announcements, which includes coin_id, message, and morph_bytes.</param>
        /// <param name="puzzle_announcements">A list of puzzle announcements, which includes puzzle_hash, message, and morph_bytes.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public CreateSignedTransaction_RPC(ulong wallet_id, string[] additions, 
            string[] coins, string[] exclude_coins,
            ulong? min_coin_amount_mojos, ulong? max_coin_amount_mojos, ulong[]? exclude_coin_amounts_mojos,
            string[]? coin_announcements, string[]? puzzle_announcements, ulong? fee)
        {
            this.wallet_id = wallet_id;
            this.additions = additions;
            this.min_coin_amount = min_coin_amount_mojos;
            this.max_coin_amount = max_coin_amount_mojos;
            this.exclude_coin_amounts = exclude_coin_amounts_mojos;
            this.coins = coins;
            this.exclude_coins = exclude_coins;
            this.coin_announcements = coin_announcements;
            this.puzzle_announcements = puzzle_announcements;
            this.fee = fee;
        }
        /// <summary>
        /// Class representing a JSON RPC request for the create_signed_transaction method.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="coins">A list of coins to include.</param>
        /// <param name="exclude_coins">A list of coins to exclude.</param>
        /// <param name="min_coin_amount_mojos">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount_mojos">The maximum coin amount to send (default: 0).</param>
        /// <param name="exclude_coin_amounts_mojos">A list of coin amounts to exclude.</param>
        /// <param name="coin_announcements">A list of coin announcements, which includes coin_id, message, and morph_bytes.</param>
        /// <param name="puzzle_announcements">A list of puzzle announcements, which includes puzzle_hash, message, and morph_bytes.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public CreateSignedTransaction_RPC(WalletID_RPC wallet_id, string[] additions,
            string[] coins, string[] exclude_coins,
            ulong? min_coin_amount_mojos, ulong? max_coin_amount_mojos, ulong[]? exclude_coin_amounts_mojos,
            string[]? coin_announcements, string[]? puzzle_announcements, ulong? fee)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.additions = additions;
            this.min_coin_amount = min_coin_amount_mojos;
            this.max_coin_amount = max_coin_amount_mojos;
            this.exclude_coin_amounts = exclude_coin_amounts_mojos;
            this.coins = coins;
            this.exclude_coins = exclude_coins;
            this.coin_announcements = coin_announcements;
            this.puzzle_announcements = puzzle_announcements;
            this.fee = fee;
        }
        /// <summary>
        /// Class representing a JSON RPC request for the create_signed_transaction method.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="coins">A list of coins to include.</param>
        /// <param name="exclude_coins">A list of coins to exclude.</param>
        /// <param name="min_coin_amount_xch">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount_xch">The maximum coin amount to send (default: 0).</param>
        /// <param name="exclude_coin_amounts_xch">A list of coin amounts to exclude.</param>
        /// <param name="coin_announcements">A list of coin announcements, which includes coin_id, message, and morph_bytes.</param>
        /// <param name="puzzle_announcements">A list of puzzle announcements, which includes puzzle_hash, message, and morph_bytes.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public CreateSignedTransaction_RPC(ulong wallet_id, string[] additions,
            string[] coins, string[] exclude_coins,
            decimal? min_coin_amount_xch, decimal? max_coin_amount_xch, decimal[]? exclude_coin_amounts_xch,
            string[]? coin_announcements, string[]? puzzle_announcements, ulong? fee)
        {
            this.wallet_id = wallet_id;
            this.additions = additions;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.exclude_coin_amounts_in_xch = exclude_coin_amounts_xch;
            this.coins = coins;
            this.exclude_coins = exclude_coins;
            this.coin_announcements = coin_announcements;
            this.puzzle_announcements = puzzle_announcements;
            this.fee = fee;
        }
        /// <summary>
        /// Class representing a JSON RPC request for the create_signed_transaction method.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="coins">A list of coins to include.</param>
        /// <param name="exclude_coins">A list of coins to exclude.</param>
        /// <param name="min_coin_amount_xch">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount_xch">The maximum coin amount to send (default: 0).</param>
        /// <param name="exclude_coin_amounts_xch">A list of coin amounts to exclude.</param>
        /// <param name="coin_announcements">A list of coin announcements, which includes coin_id, message, and morph_bytes.</param>
        /// <param name="puzzle_announcements">A list of puzzle announcements, which includes puzzle_hash, message, and morph_bytes.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public CreateSignedTransaction_RPC(WalletID_RPC wallet_id, string[] additions,
            string[] coins, string[] exclude_coins,
            decimal? min_coin_amount_xch, decimal? max_coin_amount_xch, decimal[]? exclude_coin_amounts_xch,
            string[]? coin_announcements, string[]? puzzle_announcements, ulong? fee)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.additions = additions;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.exclude_coin_amounts_in_xch = exclude_coin_amounts_xch;
            this.coins = coins;
            this.exclude_coins = exclude_coins;
            this.coin_announcements = coin_announcements;
            this.puzzle_announcements = puzzle_announcements;
            this.fee = fee;
        }

        /// <summary>
        /// The wallet ID for the origin of the transaction.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// A list of puzzle hashes and amounts to be included.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[]? additions { get; set; }

        /// <summary>
        /// The minimum coin amount (mojos) to send (default: 0).
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
        /// The maximum coin amount (mojos) to send (default: 0).
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; }

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
        /// A list of coin amounts (mojos) to exclude.
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
        /// A list of coins to include.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[]? coins { get; set; }

        /// <summary>
        /// A list of coins to exclude.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[]? exclude_coins { get; set; }

        /// <summary>
        /// A list of coin announcements, which includes coin_id, message, and morph_bytes.
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? coin_announcements { get; set; }

        /// <summary>
        /// A list of puzzle announcements, which includes puzzle_hash, message, and morph_bytes.
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? puzzle_announcements { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
        /// <summary>
        /// the transaction fee in xch
        /// </summary>
        /// <remarks>This value is derived from the mojos fee_amount</remarks>
        [JsonIgnore]
        public decimal? fee_in_xch { 
            get { return fee / GlobalVar.OneChiaInMojos; } 
            set { fee = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

    }
}
