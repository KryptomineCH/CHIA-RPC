
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// Class representing a JSON RPC request for the send_transaction_multi method.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#send_transaction_multi"/></remarks>
    public class SendTransactionMulti_RPC : RPCTemplate<SendTransactionMulti_RPC>
    {
        /// <summary>
        /// The wallet ID for the origin of the transaction.
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The destination address.
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// The number of mojos to send.
        /// </summary>
        public ulong amount { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        public ulong? fee { get; set; }

        /// <summary>
        /// An optional array of memos to be sent with the transaction.
        /// </summary>
        public string[] memos { get; set; }

        /// <summary>
        /// A list of puzzle hashes and amounts to be included.
        /// </summary>
        public string[] additions { get; set; }
    }
}
