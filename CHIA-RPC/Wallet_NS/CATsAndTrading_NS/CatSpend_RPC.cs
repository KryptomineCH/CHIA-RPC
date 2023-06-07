using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Security.Cryptography.X509Certificates;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Represents the response of the "cat_spend" command, which sends CAT funds to another wallet.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#cat_spend"/><br/><br/>
    /// Uses:<br/><see cref="CatSpend_RPC"/>
    /// </remarks>
    public class CatSpend_Response : ResponseTemplate<CatSpend_Response>
    {
        public Transaction_DictMemos transaction { get; set; }
        public string transaction_id { get; set; }
    }
    /// <summary>
    /// Send CAT funds to another wallet.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#cat_spend"/></remarks>
    /// <returns><see cref="CatSpend_Response"/></returns>
    public class CatSpend_RPC : RPCTemplate<CatSpend_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CatSpend_RPC() { /* for serialisation */ }

        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(ulong wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, string[] exclude_coin_ids, 
             string[]? memos = null, string[]? coins = null, ulong? min_coin_amount = null, 
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null, 
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            this.coins = coins;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.exclude_coin_ids = exclude_coin_ids;
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(WalletID_RPC wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, string[] exclude_coin_ids,
             string[]? memos = null, string[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            this.coins = coins;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.exclude_coin_ids = exclude_coin_ids;
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(WalletID_Response wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, string[] exclude_coin_ids,
             string[]? memos = null, string[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            this.coins = coins;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.exclude_coin_ids = exclude_coin_ids;
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(ulong wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, string[] exclude_coin_ids,
             string[]? memos = null, Coin[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            List<string> coin_list = new List<string>();
            foreach (Coin coin in coins) { coin_list.Add(coin.puzzle_hash); } 
            this.coins = coin_list.ToArray();
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.exclude_coin_ids = exclude_coin_ids;
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(WalletID_RPC wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, string[] exclude_coin_ids,
             string[]? memos = null, Coin[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            List<string> coin_list = new List<string>();
            foreach (Coin coin in coins) { coin_list.Add(coin.puzzle_hash); }
            this.coins = coin_list.ToArray();
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.exclude_coin_ids = exclude_coin_ids;
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(WalletID_Response wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, string[] exclude_coin_ids,
            string[]? memos = null, Coin[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            List<string> coin_list = new List<string>();
            foreach (Coin coin in coins) { coin_list.Add(coin.puzzle_hash); }
            this.coins = coin_list.ToArray();
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.exclude_coin_ids = exclude_coin_ids;
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(WalletID_Response wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, Coin[] exclude_coin_ids,
            string[]? memos = null, Coin[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            List<string> coin_list = new List<string>();
            foreach (Coin coin in coins) { coin_list.Add(coin.puzzle_hash); }
            this.coins = coin_list.ToArray();
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            List<string> exclude_coin_list = new List<string>();
            foreach (Coin coin in exclude_coin_ids) { exclude_coin_list.Add(coin.puzzle_hash); }
            this.exclude_coin_ids = exclude_coin_list.ToArray();
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(WalletID_Response wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, Coin[] exclude_coin_ids,
            string[]? memos = null, string[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            this.coins = coins;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            List<string> exclude_coin_list = new List<string>();
            foreach (Coin coin in exclude_coin_ids) { exclude_coin_list.Add(coin.puzzle_hash); }
            this.exclude_coin_ids = exclude_coin_list.ToArray();
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(WalletID_RPC wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, Coin[] exclude_coin_ids,
            string[]? memos = null, string[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            this.coins = coins;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            List<string> exclude_coin_list = new List<string>();
            foreach (Coin coin in exclude_coin_ids) { exclude_coin_list.Add(coin.puzzle_hash); }
            this.exclude_coin_ids = exclude_coin_list.ToArray();
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(WalletID_RPC wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, Coin[] exclude_coin_ids,
            string[]? memos = null, Coin[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            List<string> coin_list = new List<string>();
            foreach (Coin coin in coins) { coin_list.Add(coin.puzzle_hash); }
            this.coins = coin_list.ToArray();
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            List<string> exclude_coin_list = new List<string>();
            foreach (Coin coin in exclude_coin_ids) { exclude_coin_list.Add(coin.puzzle_hash); }
            this.exclude_coin_ids = exclude_coin_list.ToArray();
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(ulong wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, Coin[] exclude_coin_ids,
            string[]? memos = null, Coin[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            List<string> coin_list = new List<string>();
            foreach (Coin coin in coins) { coin_list.Add(coin.puzzle_hash); }
            this.coins = coin_list.ToArray();
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            List<string> exclude_coin_list = new List<string>();
            foreach (Coin coin in exclude_coin_ids) { exclude_coin_list.Add(coin.puzzle_hash); }
            this.exclude_coin_ids = exclude_coin_list.ToArray();
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// Send CAT funds to another wallet.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="amount">The number of mojos to send.<br/></param>
        /// <param name="inner_address">The destination address.</param>
        /// <param name="exclude_coin_amounts"> A list of coin amounts to exclude.</param>
        /// <param name="exclude_coin_ids">A list of coin IDs to exclude.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        /// <param name="coins">A list of coins to include in the spend</param>
        /// <param name="min_coin_amount">The minimum coin amount to send (default: 0).</param>
        /// <param name="max_coin_amount">The maximum coin amount to send (default: 0).</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="extra_delta">The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified</param>
        /// <param name="tail_reveal">The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified</param>
        /// <param name="tail_solution">The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CatSpend_RPC(ulong wallet_id, string[]? additions, ulong? amount, string inner_address, ulong[] exclude_coin_amounts, Coin[] exclude_coin_ids,
            string[]? memos = null, string[]? coins = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong? fee = null, string? extra_delta = null, string? tail_reveal = null,
            string? tail_solution = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.additions = additions;
            this.amount = amount;
            this.inner_address = inner_address;
            this.memos = memos;
            this.coins = coins;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            List<string> exclude_coin_list = new List<string>();
            foreach (Coin coin in exclude_coin_ids) { exclude_coin_list.Add(coin.puzzle_hash); }
            this.exclude_coin_ids = exclude_coin_list.ToArray();
            this.fee = fee;
            this.extra_delta = extra_delta;
            this.tail_reveal = tail_reveal;
            this.tail_solution = tail_solution;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// The wallet ID for the origin of the transaction.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// A list of puzzle hashes and amounts to be included.<br/>
        /// Must include either additions or amount.
        /// </summary>
        /// <remarks>conditional mandatory</remarks>
        public string[]? additions { get; set; }

        /// <summary>
        /// The number of mojos to send.<br/>
        /// Must include either additions or amount.
        /// </summary>
        /// <remarks>conditional mandatory</remarks>
        public ulong? amount { get; set; }

        /// <summary>
        /// The destination address.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string inner_address { get; set; }

        /// <summary>
        /// An optional array of memos to be sent with the transaction.
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? memos { get; set; }

        /// <summary>
        /// A list of coins to include in the spend
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? coins { get; set; }

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
        public ulong[] exclude_coin_amounts { get; set; }

        /// <summary>
        /// A list of coin IDs to exclude.
        /// </summary>
        /// <remarks>optional</remarks>
        public string[] exclude_coin_ids { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }

        /// <summary>
        /// The CAT's `extra_delta` parameter; *If specified, then `tail_reveal` and `tail_solution` must also be specified
        /// </summary>
        /// <remarks>optional</remarks>
        public string? extra_delta { get; set; }

        /// <summary>
        /// The CAT's `tail_reveal` parameter; *If specified, then `extra_delta` and `tail_solution` must also be specified
        /// </summary>
        /// <remarks>optional</remarks>
        public string? tail_reveal { get; set; }

        /// <summary>
        /// The CAT's `tail_solution` parameter; *If specified, then `extra_delta` and `tail_reveal` must also be specified
        /// </summary>
        /// <remarks>optional</remarks>
        public string? tail_solution { get; set; }

        /// <summary>
        ///  If `true`, will not generate a new puzzle hash / address for this transaction only. <br/>
        ///  Note that setting this parameter to `true` will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
