using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Accept an offer to create one or more keys in exchange for the Maker creating one or more keys. Triggers a Chia transaction
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#take_offer"/>
    /// </remarks>
    /// <returns>
    /// <see cref="General_NS.TradeID_Response"/>
    /// </returns>
    public class TakeOffer_RPC : RPCTemplate<TakeOffer_RPC>
    {
        /// <summary>
        /// The offer, in JSON format (the output from the make_offer RPC). Includes Maker and Taker information
        /// </summary>
        public OfferFile_Datalayer offer { get; set; }

        /// <summary>
        /// Set the fee for the offer, in mojos
        /// </summary>
        public ulong? fee { get; set; }
    }
}
