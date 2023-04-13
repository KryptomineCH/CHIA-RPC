using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS
{
    public class CatOfferSummary : ObjectTemplate<CatOfferSummary>
    {
        // The fees associated with the offer.
        public ulong fees { get; set; }

        // A dictionary containing information about the offer.
        public Dictionary<string, OfferInfo> infos { get; set; }

        // A dictionary containing the offered amounts with their corresponding keys.
        public Dictionary<string, ulong> offered { get; set; }

        // A dictionary containing the requested amounts with their corresponding keys.
        public Dictionary<string, ulong> requested { get; set; }
    }
}
