

using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    /// <summary>
    /// Class representing a JSON RPC request for the create_signed_transaction method.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#create_signed_transaction"/></remarks>
    public class CreateSignedTransaction_RPC : RPCTemplate<CreateSignedTransaction_RPC>
    {
        /// <summary>
        /// The wallet ID for the origin of the transaction.
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// A list of puzzle hashes and amounts to be included.
        /// </summary>
        public string[] additions { get; set; }

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
        /// A list of coins to include.
        /// </summary>
        public string[] coins { get; set; }

        /// <summary>
        /// A list of coins to exclude.
        /// </summary>
        public string[] exclude_coins { get; set; }

        /// <summary>
        /// A list of coin announcements, which includes coin_id, message, and morph_bytes.
        /// </summary>
        public string[] coin_announcements { get; set; }

        /// <summary>
        /// A list of puzzle announcements, which includes puzzle_hash, message, and morph_bytes.
        /// </summary>
        public string[] puzzle_announcements { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        public ulong? fee { get; set; }
    }
}
