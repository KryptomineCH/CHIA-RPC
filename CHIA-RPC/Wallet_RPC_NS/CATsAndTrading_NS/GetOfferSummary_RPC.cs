

using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.CATsAndTrading_NS
{
    /// <summary>
    /// A summary of the offer including fees, information, offered, and requested amounts.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#get_offer_summary"/><br/><br/>
    /// Uses:<see cref="GetOfferSummary_RPC"/>
    /// </remarks>
    public class GetOfferSummary_Response : ResponseTemplate<GetOfferSummary_Response>
    {
        public OfferSummary summary { get; set; }

        public class OfferSummary
        {
            /// <summary>
            /// The fees associated with the offer.
            /// </summary>
            public ulong fees { get; set; }

            /// <summary>
            /// A dictionary containing information about the offer.
            /// </summary>
            public Dictionary<string, OfferInfo> infos { get; set; }

            /// <summary>
            /// A dictionary containing the offered amounts with their corresponding keys.
            /// </summary>
            public Dictionary<string, ulong> offered { get; set; }

            /// <summary>
            /// A dictionary containing the requested amounts with their corresponding keys.
            /// </summary>
            public Dictionary<string, ulong> requested { get; set; }
        }

        public class OfferInfo : ObjectTemplate<OfferInfo> 
        {
            /// <summary>
            /// The tail property associated with the offer.
            /// </summary>
            public string tail { get; set; }

            /// <summary>
            /// The type of offer.
            /// </summary>
            public string type { get; set; }
        }
    }
    /// <summary>
    /// A summary of the offer including fees, information, offered, and requested amounts.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#get_offer_summary"/></remarks>
    /// <returns><see cref="GetOfferSummary_Response"/></returns>
    public class GetOfferSummary_RPC : RPCTemplate<GetOfferSummary_RPC>
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
