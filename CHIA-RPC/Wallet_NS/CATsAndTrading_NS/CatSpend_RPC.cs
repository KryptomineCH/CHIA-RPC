using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

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
        /// The wallet ID for the origin of the transaction.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// A list of puzzle hashes and amounts to be included.
        /// </summary>
        /// <remarks>Must include either additions or amount.</remarks>
        public string[] additions { get; set; }

        /// <summary>
        /// The number of mojos to send.
        /// </summary>
        /// <remarks>Must include either additions or amount.</remarks>
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
        public string? coins { get; set; }

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
        ///  If `true`, will not generate a new puzzle hash / address for this transaction only. 
        ///  Note that setting this parameter to `true` will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
