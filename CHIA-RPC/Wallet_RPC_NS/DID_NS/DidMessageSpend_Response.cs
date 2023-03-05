using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    /// <summary>
    /// Represents the response for the `did_message_spend` RPC.
    /// </summary>
    /// <remarks>
    /// Uses a WalletID_RPC
    /// </remarks>
    public class DidMessageSpend_Response : ResponseTemplate<DidMessageSpend_Response>
    {
        /// <summary>
        /// The spend bundle to send a message.
        /// </summary>
        public SpendBundle spend_bundle { get; set; }
    }
}
