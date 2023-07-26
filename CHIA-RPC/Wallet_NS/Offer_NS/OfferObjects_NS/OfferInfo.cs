using CHIA_RPC.HelperFunctions_NS;
namespace CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS
{
    /// <summary>
    /// basic information of an offer
    /// </summary>
    public class OfferInfo : ObjectTemplate<OfferInfo>
    {
        /// <summary>
        /// The launcher ID associated with the offer.
        /// </summary>
        public string? launcher_id { get; set; }

        /// <summary>
        /// The launcher PH associated with the offer.
        /// </summary>
        public string? launcher_ph { get; set; }

        /// <summary>
        /// The type of offer.
        /// </summary>
        public string? type { get; set; }

        /// <summary>
        /// the tail information which limits spending/transactions
        /// </summary>
        public string? tail { get; set; }

        /// <summary>
        /// The nested "also" object containing additional information about the offer.
        /// </summary>
        public Also? also { get; set; }
    }
    /// <summary>
    /// further information for the offer 
    /// </summary>
    public class Also
    {
        /// <summary>
        /// The nested "also" object containing ownership and transfer program information.
        /// </summary>
        public Also? also { get; set; }

        /// <summary>
        /// The metadata string associated with the offer.
        /// </summary>
        public string? metadata { get; set; }

        /// <summary>
        /// The type of additional information.
        /// </summary>
        public string? type { get; set; }

        /// <summary>
        /// The updater hash associated with the offer.
        /// </summary>
        public string? updater_hash { get; set; }

        /// <summary>
        /// The owner address associated with the offer.
        /// </summary>
        public string? owner { get; set; }

        /// <summary>
        /// The transfer program object containing royalty information.
        /// </summary>
        public TransferProgram? transfer_program { get; set; }
    }
}
