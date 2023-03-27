using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Offer_NS
{
    /// <summary>
    /// MyClass_Response represents a response from the check_offer_validity server method.
    /// Functionality: Checks whether a specific offer is valid (see below for definitions).
    /// Usage: chia rpc wallet [OPTIONS] check_offer_validity [REQUEST].
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/offer-rpc#check_offer_validity"/><br/><br/>
    /// Uses:<br/><see cref="CheckOfferValidity_RPC"/>
    /// </remarks>
    public class CheckOfferValidity_Response : ResponseTemplate<CheckOfferValidity_Response>
    {
        /// <summary>
        /// Gets or sets the ID of the response.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether the offer is valid.<br/><br/>
        /// The offer is considered valid if it is in any of the following states:<br/>
        /// PENDING_ACCEPT, PENDING_CONFIRM, PENDING_CANCEL.<br/><br/>
        /// The offer is no longer valid if it is in any of the following states:<br/>
        /// CANCELLED, CONFIRMED, FAILED.
        /// </summary>
        public bool valid { get; set; }
    }

    /// <summary>
    /// Checks whether a specific offer is valid.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/offer-rpc#check_offer_validity"/></remarks>
    /// <returns><see cref="CheckOfferValidity_Response"/></returns>
    public class CheckOfferValidity_RPC : RPCTemplate<CheckOfferValidity_RPC>
    {
        /// <summary>
        /// The offer to check. The offer is considered valid if it is in any of the following states:
        /// PENDING_ACCEPT
        /// PENDING_CONFIRM
        /// PENDING_CANCEL
        /// The offer is no longer valid if it is in any of the following states:
        /// CANCELLED
        /// CONFIRMED
        /// FAILED
        /// </summary>
        public string[] offer { get; set; }
    }
}
