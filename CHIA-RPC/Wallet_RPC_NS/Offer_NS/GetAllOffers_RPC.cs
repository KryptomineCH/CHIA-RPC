using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Gets all offers for the current wallet. Includes offers in every state.
    /// </summary>
    public class GetAllOffers_RPC : RPCTemplate<GetAllOffers_RPC>
    {
        /// <summary>
        /// Set to True to return a summary for the offer. Defaults to False, which only returns the offer's basic metadata.
        /// </summary>
        public bool file_contents { get; set; } = false;
    }
}
