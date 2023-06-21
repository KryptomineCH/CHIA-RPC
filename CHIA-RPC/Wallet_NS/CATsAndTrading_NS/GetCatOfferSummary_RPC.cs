using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// A summary of the offer including fees, information, offered, and requested amounts.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#get_offer_summary"/><br/><br/>
    /// Uses:<see cref="GetOfferSummary_RPC"/>
    /// </remarks>
    public class GetCatOfferSummary_Response : ResponseTemplate<GetCatOfferSummary_Response>
    {
        public string id { get; set; }
        public CatOfferSummary summary { get; set; }
    }
    /// <summary>
    /// A summary of the offer including fees, information, offered, and requested amounts.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#get_offer_summary"/></remarks>
    /// <returns><see cref="GetOfferSummary_Response"/></returns>
    public class GetCatOfferSummary_RPC : RPCTemplate<GetCatOfferSummary_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public GetCatOfferSummary_RPC() { /* for serialisation */ }

        /// <summary>
        /// A summary of the offer including fees, information, offered, and requested amounts.
        /// </summary>
        /// <param name="offer">The offer for which to retrieve a summary.</param>
        /// <param name="advanced">Set to true to show a detailed summary.</param>
        public GetCatOfferSummary_RPC(string offer, bool? advanced = null)
        {
            this.offer = offer;
            this.advanced = advanced;
        }

        /// <summary>
        /// A summary of the offer including fees, information, offered, and requested amounts.
        /// </summary>
        /// <param name="offer">The offer for which to retrieve a summary.</param>
        /// <param name="advanced">Set to true to show a detailed summary.</param>
        public GetCatOfferSummary_RPC(OfferFile offer, bool? advanced = null)
        {
            this.offer = offer.offer;
            this.advanced = advanced;
        }

        /// <summary>
        /// The offer for which to retrieve a summary.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string offer { get; set; }

        /// <summary>
        /// Set to true to show a detailed summary. <br/>
        /// Default: false.
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? advanced { get; set; }
        /// <summary>
        /// automatically converts an offer file to this request
        /// </summary>
        /// <param name="offerFile"></param>
        public static implicit operator GetCatOfferSummary_RPC(OfferFile offerFile)
        {
            return new GetCatOfferSummary_RPC(offerFile.offer);
        }
    }
}
