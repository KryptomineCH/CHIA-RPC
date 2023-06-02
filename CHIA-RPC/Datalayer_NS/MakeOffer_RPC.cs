using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Datalayer_NS
{
    public class MakeOffer_Response : ResponseTemplate<MakeOffer_Response>
    {
        public Datalayer_OfferFile offer { get; set; }
    }
    /// <summary>
    /// Make an offer to include one or more keys in exchange for a Taker including one or more keys
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#make_offer"/></remarks>
    /// <returns><see cref="DatalayerObjects_NS.Datalayer_OfferFile"/></returns>
    public class MakeOffer_RPC : RPCTemplate<MakeOffer_RPC>
    {
        public MakeOffer_RPC() { /* for serialisation */}
        /// <summary>
        /// Make an offer to include one or more keys in exchange for a Taker including one or more keys
        /// </summary>
        /// <param name="maker">The hexadecimal ID of the store for which to list mirrors (??)</param>
        /// <param name="taker">(??)</param>
        /// <param name="fee">Set the fee for the offer, in mojos</param>
        public MakeOffer_RPC(DealParticipant[] maker, DealParticipant[] taker, ulong? fee = null)
        {
            this.maker = maker;
            this.taker = taker;
            this.fee = fee;
        }

        /// <summary>
        /// The hexadecimal ID of the store for which to list mirrors
        /// </summary>
        public DealParticipant[] maker { get; set; }

        /// <summary>
        /// The hexadecimal ID of the store for which to list mirrors
        /// </summary>
        public DealParticipant[] taker { get; set; }

        /// <summary>
        /// Set the fee for the offer, in mojos
        /// </summary
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }

        /// <summary>
        /// The maker's data
        /// </summary>
        /// <remarks><see href="https://docs.chia.net/datalayer-rpc#make_offer"/></remarks>
        public class DealParticipant : ObjectTemplate<DealParticipant>
        {
            /// <summary>
            /// The hexadecimal store ID
            /// </summary>
            public string store_id { get; set; }

            /// <summary>
            /// The list of key-value pairs
            /// </summary>
            public KeyValueString[] inclusions { get; set; }
        }
    }
}
