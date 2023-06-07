

using CHIA_RPC.HelperFunctions_NS;

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
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="exclude_coin_amounts">A list of coin amounts to exclude.</param>
        /// <param name="coin_announcements">A list of coin announcements, which includes coin_id, message, and morph_bytes.</param>
        /// <param name="puzzle_announcements">A list of puzzle announcements, which includes puzzle_hash, message, and morph_bytes.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public CreateSignedTransaction_RPC(ulong wallet_id, string[] additions, 
            string[] coins, string[] exclude_coins,
            ulong? min_coin_amount, ulong? max_coin_amount, ulong[]? exclude_coin_amounts,
            string[]? coin_announcements, string[]? puzzle_announcements, ulong? fee)
        {
            this.wallet_id = wallet_id;
            this.additions = additions;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
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
        public string[] additions { get; set; }

        /// <summary>
        /// The minimum coin amount to send (default: 0).
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }

        /// <summary>
        /// The maximum coin amount to send (default: 0).
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; }

        /// <summary>
        /// A list of coin amounts to exclude.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong[]? exclude_coin_amounts { get; set; }

        /// <summary>
        /// A list of coins to include.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[] coins { get; set; }

        /// <summary>
        /// A list of coins to exclude.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[] exclude_coins { get; set; }

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
    }
}
