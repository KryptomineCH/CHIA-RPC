using CHIA_RPC.HelperFunctions_NS;
namespace CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS
{
    public class OfferInfo : ObjectTemplate<OfferInfo>
    {
        // The launcher ID associated with the offer.
        public string launcher_id { get; set; }

        // The launcher PH associated with the offer.
        public string launcher_ph { get; set; }

        // The type of offer.
        public string type { get; set; }

        public string tail { get; set; }

        // The nested "also" object containing additional information about the offer.
        public Also also { get; set; }
    }

    public class Also
    {
        // The nested "also" object containing ownership and transfer program information.
        public Also also { get; set; }

        // The metadata string associated with the offer.
        public string metadata { get; set; }

        // The type of additional information.
        public string type { get; set; }

        // The updater hash associated with the offer.
        public string updater_hash { get; set; }

        // The owner address associated with the offer.
        public string owner { get; set; }

        // The transfer program object containing royalty information.
        public TransferProgram transfer_program { get; set; }
    }
}
