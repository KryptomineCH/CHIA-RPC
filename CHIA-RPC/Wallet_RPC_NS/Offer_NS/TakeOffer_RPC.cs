using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Takes (accepts) a specific offer, with a given fee.
    /// </summary>
    public class TakeOffer_RPC : RPCTemplate<TakeOffer_RPC>
    {
        /// <summary>
        /// The offer to accept. Must be in the PENDING_ACCEPT state.
        /// </summary>
        public string offer { get; set; }

        /// <summary>
        /// An optional fee (in mojos) to include with the offer. Defaults to 0.
        /// </summary>
        public ulong fee { get; set; } = 0;
    }
}
