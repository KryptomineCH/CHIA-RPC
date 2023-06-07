
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
        /// parameterless constructor, for serializer
        /// </summary>
        public SendTransactionMulti_RPC() { /* for serrialisation */ }
        /// <summary>
        /// Class representing a JSON RPC request for the send_transaction_multi method.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="address">The destination address.</param>
        /// <param name="amount">The number of mojos to send.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        public SendTransactionMulti_RPC(ulong wallet_id, string address, ulong amount, string[] additions, ulong? fee = null, string[]? memos = null)
        {
            this.wallet_id = wallet_id;
            this.address = address;
            this.amount = amount;
            this.fee = fee;
            this.memos = memos;
            this.additions = additions;
        }

        /// <summary>
        /// The wallet ID for the origin of the transaction.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The destination address.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public string address { get; set; }

        /// <summary>
        /// The number of mojos to send.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public ulong amount { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }

        /// <summary>
        /// An optional array of memos to be sent with the transaction.
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? memos { get; set; }

        /// <summary>
        /// A list of puzzle hashes and amounts to be included.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public string[] additions { get; set; }
    }
}
