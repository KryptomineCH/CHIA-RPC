
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Create a new offer
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#create_offer_for_ids"/></remarks>
    /// <returns>?</returns>
    public class CreateOfferForIds_RPC : RPCTemplate<CreateOfferForIds_RPC>
    {
        /// <summary>
        /// The offer to create
        /// </summary>
        public string offer { get; set; }

        /// <summary>
        /// Only validate the offer instead of creating it [Default: false]
        /// </summary>
        public bool? validate_only { get; set; }

        /// <summary>
        /// A dictionary of keys and values associated with the offer
        /// </summary>
        public Dictionary<string, object> driver_dict { get; set; }

        /// <summary>
        /// The minimum coin amount to select for the offer [Default: none]
        /// </summary>
        public ulong? min_coin_amount { get; set; }

        /// <summary>
        /// The maximum coin amount to select for the offer [Default: none]
        /// </summary>
        public ulong? max_coin_amount { get; set; }

        /// <summary>
        /// A marshalled solver
        /// </summary>
        public string? solver { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong? fee { get; set; }
    }

}
