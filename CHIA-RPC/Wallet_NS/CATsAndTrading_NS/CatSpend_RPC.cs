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
        public ulong wallet_id { get; set; }

        /// <summary>
        /// A list of puzzle hashes and amounts to be included.
        /// Must include either additions or amount.
        /// </summary>
        public string[] additions { get; set; }

        /// <summary>
        /// The number of mojos to send.
        /// Must include either additions or amount.
        /// </summary>
        public ulong? amount { get; set; }

        /// <summary>
        /// The destination address.
        /// </summary>

        public string inner_address { get; set; }

        /// <summary>
        /// An optional array of memos to be sent with the transaction.
        /// </summary>
        public string[] memos { get; set; }

        /// <summary>
        /// The minimum coin amount to send (default: 0).
        /// </summary>
        public ulong? min_coin_amount { get; set; }

        /// <summary>
        /// The maximum coin amount to send (default: 0).
        /// </summary>
        public ulong? max_coin_amount { get; set; }

        /// <summary>
        /// A list of coin amounts to exclude.
        /// </summary>
        public ulong[] exclude_coin_amounts { get; set; }

        /// <summary>
        /// A list of coin IDs to exclude.
        /// </summary>
        public string[] exclude_coin_ids { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        public ulong? fee { get; set; }
    }
}
