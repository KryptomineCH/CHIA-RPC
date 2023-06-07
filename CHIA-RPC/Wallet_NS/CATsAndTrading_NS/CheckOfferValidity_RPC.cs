using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Collections.Specialized;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Class to represent a JSON RPC response for checking offer validity.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#check_offer_validity"/><br/><br/>
    /// Uses:<br/><see cref="CheckOfferValidity_RPC"/>
    /// </remarks>
    public class CheckOfferValidity_Response : ResponseTemplate<CheckOfferValidity_Response>
    {
        /// <summary>
        /// the offer ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Indicating whether the offer is valid.<br/><br/>
        /// The offer is considered valid if it is in any of the following states:<br/>
        /// PENDING_ACCEPT, PENDING_CONFIRM, PENDING_CANCEL.<br/><br/>
        /// The offer is no longer valid if it is in any of the following states:<br/>
        /// CANCELLED, CONFIRMED, FAILED.
        /// </summary>
        public bool valid { get; set; }
    }


    /// <summary>
    /// Check if an offer is valid
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#check_offer_validity"/></remarks>
    /// <returns><see cref="CheckOfferValidity_Response"/></returns>
    public class CheckOfferValidity_RPC : RPCTemplate<CheckOfferValidity_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CheckOfferValidity_RPC() { /* for serialisation */ }
        /// <summary>
        /// Check if an offer is valid
        /// </summary>
        /// <param name="offer">The contents of the offer to check.</param>
        public CheckOfferValidity_RPC(string offer)
        {
            this.offer = offer;
        }
        /// <summary>
        /// Check if an offer is valid
        /// </summary>
        /// <param name="offer">The contents of the offer to check.</param>
        public CheckOfferValidity_RPC(OfferFile offer)
        {
            this.offer = offer.offer;
        }

        /// <summary>
        /// The contents of the offer to check.
        /// </summary>
        public string offer { get; set; }
    }

}
