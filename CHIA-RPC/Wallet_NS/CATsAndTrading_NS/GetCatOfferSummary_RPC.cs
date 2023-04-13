using CHIA_RPC.HelperFunctions_NS;
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
        /// The offer for which to retrieve a summary.
        /// </summary>
        public string offer { get; set; }

        /// <summary>
        /// Set to true to show a detailed summary. Default: false.
        /// </summary>
        public bool? advanced { get; set; }
    }
}
