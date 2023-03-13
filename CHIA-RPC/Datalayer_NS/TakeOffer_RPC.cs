using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Accept an offer to create one or more keys in exchange for the Maker creating one or more keys. Triggers a Chia transaction
    /// </summary>
    public class TakeOffer_RPC : RPCTemplate<TakeOffer_RPC>
    {
        /// <summary>
        /// The offer, in JSON format (the output from the make_offer RPC). Includes Maker and Taker information
        /// </summary>
        public OfferFile_DataLayer offer { get; set; }

        /// <summary>
        /// Set the fee for the offer, in mojos
        /// </summary>
        public ulong? fee { get; set; }
    }
}
