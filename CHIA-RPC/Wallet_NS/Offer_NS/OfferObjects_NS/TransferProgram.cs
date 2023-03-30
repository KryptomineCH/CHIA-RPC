using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS
{
    public class TransferProgram : ObjectTemplate<TransferProgram>
    {
        // The launcher ID associated with the transfer program.
        public string launcher_id { get; set; }

        // The royalty address associated with the transfer program.
        public string royalty_address { get; set; }

        // The royalty percentage associated with the transfer program.
        public string royalty_percentage { get; set; }

        // The type of transfer program.
        public string type { get; set; }
    }
}
