using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Get the details of an Offer
    /// Usage: chia rpc wallet [OPTIONS] get_offer [REQUEST]
    /// </summary>
    public class GetOffer_Response : ResponseTemplate<GetOffer_Response>
    {
        /// <summary>
        /// The offer details
        /// </summary>
        public OfferFile offer { get; set; }

        /// <summary>
        /// The trade record associated with the offer
        /// </summary>
        public TradeRecord trade_record { get; set; }
    }
    /// <summary>
    /// Given an offer's unique identifier, return that offer's details.
    /// </summary>
    public class GetOffer_RPC : RPCTemplate<GetOffer_RPC>
    {
        /// <summary>
        /// The ID of the offer to examine. Can be retrieved from an offer file by calling cdv inspect spendbundles <offer_file>.
        /// </summary>
        public string trade_id { get; set; }

        /// <summary>
        /// Set to True to return a summary for the offer. Defaults to False, which only returns the offer's basic metadata.
        /// </summary>
        public bool file_contents { get; set; } = false;
    }
}
