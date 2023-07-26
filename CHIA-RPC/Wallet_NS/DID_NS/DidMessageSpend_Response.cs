using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Represents the response for the `did_message_spend` RPC.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_message_spend"/><br/><br/>
    /// Uses:<br/> <see cref="DidMessageSpend_RPC"/>
    /// </remarks>
    public class DidMessageSpend_Response : ResponseTemplate<DidMessageSpend_Response>
    {
        /// <summary>
        /// The spend bundle to send a message.
        /// </summary>
        public SpendBundle? spend_bundle { get; set; }
    }
    /// <summary>
    /// Represents the request for the `did_message_spend` RPC.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_message_spend"/></remarks>
    /// <returns><see cref="General_NS.WalletID_RPC"/></returns>
    public class DidMessageSpend_RPC : RPCTemplate<DidMessageSpend_RPC>
    {
        /// <summary>
        /// The Wallet ID of the DID wallet from which to spend the message
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// A list of coin announcements to include with the spend
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? coin_announcements { get; set; }
        /// <summary>
        /// A list of puzzle announcements to include with the spend
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? puzzle_announcements { get; set; }
    }
}
