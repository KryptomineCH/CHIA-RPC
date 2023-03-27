using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Represents the response for the `did_message_spend` RPC.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_message_spend"/><br/><br/>
    /// Uses:<br/> <see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class DidMessageSpend_Response : ResponseTemplate<DidMessageSpend_Response>
    {
        /// <summary>
        /// The spend bundle to send a message.
        /// </summary>
        public SpendBundle spend_bundle { get; set; }
    }
}
