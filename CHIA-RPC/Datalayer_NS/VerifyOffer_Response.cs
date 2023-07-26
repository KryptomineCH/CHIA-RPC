using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{

    /// <summary>
    /// Represents the response of the 'verify_offer' function in the Chia Datalayer RPC API.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#verify_offer"/><br/><br/>
    /// Uses:<br/><see cref="DatalayerObjects_NS.Datalayer_OfferFile"/>
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
        public bool? valid { get; set; }
    }
    /// <summary>
    /// Represents the request of the 'verify_offer' function in the Chia Datalayer RPC API.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#verify_offer"/></remarks>
    /// <returns><see cref="VerifyOffer_Response"/></returns>
    public class VerifyOffer_RPC : RPCTemplate<VerifyOffer_RPC>
    {
        /// <summary>
        /// the OfferString
        /// </summary>
        public string? offer { get; set; }
    }
}