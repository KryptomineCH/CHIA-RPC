using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Given an offer's unique identifier, return that offer's details.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/offer-rpc#get_offer"/></remarks>
    /// <returns><see cref="Objects_NS.OfferFile"/></returns>
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
