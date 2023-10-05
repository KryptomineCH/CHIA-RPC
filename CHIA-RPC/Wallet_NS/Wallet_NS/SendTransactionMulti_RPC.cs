
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

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
        /// <param name="amount_mojos">The number of mojos to send.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="fee_mojos">An optional blockchain fee, in mojos.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        public SendTransactionMulti_RPC(ulong wallet_id, string address, ulong amount_mojos, string[] additions, ulong? fee_mojos = null, string[]? memos = null)
        {
            this.wallet_id = wallet_id;
            this.address = address;
            this.amount = amount_mojos;
            this.fee = fee_mojos;
            this.memos = memos;
            this.additions = additions;
        }
        /// <summary>
        /// Class representing a JSON RPC request for the send_transaction_multi method.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="address">The destination address.</param>
        /// <param name="amount_mojos">The number of mojos to send.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="fee_mojos">An optional blockchain fee, in mojos.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        public SendTransactionMulti_RPC(WalletID_RPC wallet_id, string address, ulong amount_mojos, string[] additions, ulong? fee_mojos = null, string[]? memos = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.address = address;
            this.amount = amount_mojos;
            this.fee = fee_mojos;
            this.memos = memos;
            this.additions = additions;
        }
        /// <summary>
        /// Class representing a JSON RPC request for the send_transaction_multi method.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="address">The destination address.</param>
        /// <param name="amount_xch">The amount of xch to send.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="fee_xch">An optional blockchain fee, in xch.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        public SendTransactionMulti_RPC(ulong wallet_id, string address, decimal amount_xch, string[] additions, ulong? fee_xch = null, string[]? memos = null)
        {
            this.wallet_id = wallet_id;
            this.address = address;
            this.amount_in_xch = amount_xch;
            this.fee_in_xch = fee_xch;
            this.memos = memos;
            this.additions = additions;
        }
        /// <summary>
        /// Class representing a JSON RPC request for the send_transaction_multi method.
        /// </summary>
        /// <param name="wallet_id">The wallet ID for the origin of the transaction.</param>
        /// <param name="address">The destination address.</param>
        /// <param name="amount_xch">The amount of xch to send.</param>
        /// <param name="additions">A list of puzzle hashes and amounts to be included.</param>
        /// <param name="fee_xch">An optional blockchain fee, in xch.</param>
        /// <param name="memos">An optional array of memos to be sent with the transaction.</param>
        public SendTransactionMulti_RPC(WalletID_RPC wallet_id, string address, decimal amount_xch, string[] additions, ulong? fee_xch = null, string[]? memos = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.address = address;
            this.amount_in_xch = amount_xch;
            this.fee_in_xch = fee_xch;
            this.memos = memos;
            this.additions = additions;
        }

        private ulong? _wallet_id;
        /// <summary>
        /// The wallet ID for the origin of the transaction.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public ulong? wallet_id
        {
            get { return _wallet_id; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("wallet_id must be greater than 0");
                }
                _wallet_id = value;
            }
        }


        /// <summary>
        /// The destination address.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public string? address { get; set; }

        /// <summary>
        /// The number of mojos to send.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public ulong? amount { get; set; }
        /// <summary>
        /// The number of xch to send.
        /// </summary>
        /// <remarks>mantatory</remarks>
        [JsonIgnore]
        public decimal? amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// An optional blockchain fee, in mojos.
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
        /// An optional array of memos to be sent with the transaction.
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? memos { get; set; }

        /// <summary>
        /// A list of puzzle hashes and amounts to be included.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public string[]? additions { get; set; }
    }
}
