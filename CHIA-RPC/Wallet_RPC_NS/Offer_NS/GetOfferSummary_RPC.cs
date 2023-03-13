using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Returns the summary of a specific offer. Works for offers in any state.
    /// </summary>
    public class GetOfferSummary_RPC : RPCTemplate<GetOfferSummary_RPC>
    {
        /// <summary>
        /// The offer to summarize.
        /// </summary>
        public string offer { get; set; }
    }
}
