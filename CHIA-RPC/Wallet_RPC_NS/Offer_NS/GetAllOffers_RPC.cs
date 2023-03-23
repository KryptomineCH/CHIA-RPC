using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Get the details of an Offer
    /// Usage: chia rpc wallet [OPTIONS] get_offer [REQUEST]
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/offer-rpc#get_all_offers"/><br/><br/>
    /// Uses:<br/><see cref="GetAllOffers_RPC"/>
    /// </remarks>
    public class GetAllOffers_Response : ResponseTemplate<GetAllOffers_Response>
    {
        /// <summary>
        /// The offer details
        /// </summary>
        public OfferFile[] offer { get; set; }

        /// <summary>
        /// The trade record associated with the offer
        /// </summary>
        public TradeRecord[] trade_records { get; set; }
    }
    /// <summary>
    /// Represents a JSON RPC request for the `get_all_offers` function of the Chia RPC wallet server.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/offer-rpc#get_all_offers"/></remarks>
    /// <returns><see cref="GetAllOffers_Response"/></returns>
    public class GetAllOffers_RPC : RPCTemplate<GetAllOffers_RPC>
    {
        /// <summary>
        /// The first Offer to display, inclusive [Default: 0]
        /// </summary>
        public ulong? start { get; set; }

        /// <summary>
        /// The last Offer to display, exclusive [Default: 10]
        /// </summary>
        public ulong? end { get; set; }

        /// <summary>
        /// If true, don't show offers that originated from this wallet [Default: false]
        /// </summary>
        public bool? exclude_my_offers { get; set; }

        /// <summary>
        /// If true, don't show any offers with a status of CONFIRMED [Default: false]
        /// </summary>
        public bool? exclude_taken_offers { get; set; }

        /// <summary>
        /// If true, show completed offers [Default: false]
        /// </summary>
        public bool? include_completed { get; set; }

        /// <summary>
        /// Optionally change the sort order of the results [Default: none]
        /// </summary>
        public string? sort_key { get; set; }

        /// <summary>
        /// If true, reverse the results [Default: false]
        /// </summary>
        public bool? reverse { get; set; }

        /// <summary>
        /// If true, return a summary for the offer. If false, only return the offer's basic metadata [Default: false]
        /// </summary>
        public bool? file_contents { get; set; }
    }

}
