using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Represents the response of the 'verify_offer' function in the Chia Datalayer RPC API.
    /// </summary>
    /// <remarks>
    /// an <see cref="DatalayerObjects_NS.OfferFile_Datalayer"/> has to be sent to the endpoint<br/>
    /// <see href="https://docs.chia.net/datalayer-rpc#verify_offer"/>
    /// </remarks>
    public class VerifyOffer_Response : ResponseTemplate<VerifyOffer_Response>
    {
        /// <summary>
        /// the fee associated with the offer verification.
        /// </summary>
        public ulong? fee { get; set; }

        /// <summary>
        /// indicating whether the offer verification was successful or not.
        /// </summary>
        public bool valid { get; set; }
    }
}