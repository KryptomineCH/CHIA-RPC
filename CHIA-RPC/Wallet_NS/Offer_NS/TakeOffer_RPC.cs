using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.Offer_NS
{

    /// <summary>
    /// Takes (accepts) a specific offer, with a given fee.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/offer-rpc#take_offer"/></remarks>
    /// <returns><see cref="General_NS.TradeRecord_Response"/></returns>
    public class TakeOffer_RPC : RPCTemplate<TakeOffer_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public TakeOffer_RPC() { /* for serialisation */ }
        /// <summary>
        /// Takes (accepts) a specific offer, with a given fee.
        /// </summary>
        /// <param name="offer">The offer to accept. Must be in the PENDING_ACCEPT state.</param>
        /// <param name="fee">An optional fee (in mojos) to include with the offer. Defaults to 0.</param>
        public TakeOffer_RPC(string offer, ulong? fee = null)
        {
            this.offer = offer;
            this.fee = fee;
        }
        /// <summary>
        /// Takes (accepts) a specific offer, with a given fee.
        /// </summary>
        /// <param name="offerFile">The offer to accept. Must be in the PENDING_ACCEPT state.</param>
        /// <param name="fee">An optional fee (in mojos) to include with the offer. Defaults to 0.</param>
        public TakeOffer_RPC(OfferFile offerFile, ulong? fee = null)
        {
            this.offer = offerFile.offer;
            this.fee = fee;
        }

        /// <summary>
        /// The offer to accept. Must be in the PENDING_ACCEPT state.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? offer { get; set; }

        /// <summary>
        /// An optional fee (in mojos) to include with the offer. Defaults to 0.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; } = 0;
    }
}
