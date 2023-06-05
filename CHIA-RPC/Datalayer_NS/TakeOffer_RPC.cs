using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Accept an offer to create one or more keys in exchange for the Maker creating one or more keys. Triggers a Chia transaction
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#take_offer"/></remarks>
    /// <returns><see cref="General_NS.TradeID_Response"/></returns>
    public class TakeOffer_RPC : RPCTemplate<TakeOffer_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public TakeOffer_RPC() { /* for serialisation */ }
        /// <summary>
        /// Accept an offer to create one or more keys in exchange for the Maker creating one or more keys. Triggers a Chia transaction
        /// </summary>
        /// <param name="offer">The offer, in JSON format (the output from the make_offer RPC). Includes Maker and Taker information</param>
        /// <param name="fee">Set the fee for the offer, in mojos</param>
        public TakeOffer_RPC(string offer, ulong? fee = null)
        {
            this.offer = offer;
            this.fee = fee;
        }

        /// <summary>
        /// The offer, in JSON format (the output from the make_offer RPC). Includes Maker and Taker information
        /// </summary>
        /// <remarks>mandartory</remarks>
        public string offer { get; set; }

        /// <summary>
        /// Set the fee for the offer, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}
