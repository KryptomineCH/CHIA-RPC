using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Represents the response of the 'verify_offer' function in the Chia DataLayer RPC API.
    /// </summary>
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