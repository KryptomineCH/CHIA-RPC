using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// a notification to a specified puzzle hash
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#send_notification"/><br/><br/>
    /// Uses:<br/><see cref="SendNotification_RPC"/>
    /// </remarks>
    public class SendNotification_Response : ResponseTemplate<SendNotification_Response>
    {
        public Transaction_DictMemos tx { get; set; }
    }
    /// <summary>
    /// Send a notification to a specified puzzle hash
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#send_notification"/></remarks>
    /// <returns><see cref="SendNotification_Response"/></returns>
    public class SendNotification_RPC : RPCTemplate<SendNotification_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public SendNotification_RPC() { /* for serialisation */ }
        /// <summary>
        /// Send a notification to a specified puzzle hash
        /// </summary>
        /// <param name="target">The puzzle hash you would like to send a message to</param>
        /// <param name="message">The hex-encoded message you would like to send</param>
        /// <param name="amount_mojos">The number of mojos to include with this message</param>
        /// <param name="fee_mojos">An optional blockchain fee, in mojos</param>
        public SendNotification_RPC(string target, string message, ulong amount_mojos, ulong? fee_mojos = null)
        {
            this.target = target;
            this.message = message;
            this.amount = amount_mojos;
            this.fee = fee_mojos;
        }
        /// <summary>
        /// Send a notification to a specified puzzle hash
        /// </summary>
        /// <param name="target">The puzzle hash you would like to send a message to</param>
        /// <param name="message">The hex-encoded message you would like to send</param>
        /// <param name="amount_xch">The amount of xchto include with this message</param>
        /// <param name="fee_xch">An optional blockchain fee, in xch</param>
        public SendNotification_RPC(string target, string message, decimal amount_xch, decimal? fee_xch = null)
        {
            this.target = target;
            this.message = message;
            this.amount_in_xch = amount_xch;
            this.fee_in_xch = fee_xch;
        }

        /// <summary>
        /// The puzzle hash you would like to send a message to
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string target { get; set; }
        /// <summary>
        /// The hex-encoded message you would like to send
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string message { get; set; }
        /// <summary>
        /// The number of mojos to include with this message
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong amount { get; set; }
        /// <summary>
        /// The number of mojos to include with this message
        /// </summary>
        /// <remarks>mandatory</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// An optional blockchain fee, in mojos
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
    }
}
