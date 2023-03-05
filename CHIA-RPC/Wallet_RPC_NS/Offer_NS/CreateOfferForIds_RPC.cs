using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Creates a new offer.
    /// </summary>
    public class CreateOfferForIds_RPC : RPCTemplate<CreateOfferForIds_RPC>
    {
        /// <summary>
        /// A dictionary of the offer to create.
        /// </summary>
        public Dictionary<ulong, int> offer { get; set; }

        /// <summary>
        /// An optional fee (in mojos) to include with the offer. Defaults to 0.
        /// </summary>
        public ulong fee { get; set; } = 0;

        /// <summary>
        /// Defaults to False. Set to True to verify the validity of a potential offer, rather than actually creating an offer.
        /// </summary>
        public bool validate_only { get; set; } = false;
    }
}
