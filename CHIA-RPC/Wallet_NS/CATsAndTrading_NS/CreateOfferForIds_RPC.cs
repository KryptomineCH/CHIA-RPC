
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Create a new offer
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#create_offer_for_ids"/></remarks>
    /// <returns>?</returns>
    public class CreateOfferForIds_RPC : RPCTemplate<CreateOfferForIds_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CreateOfferForIds_RPC() { /* for serialisation */ }

        /// <summary>
        /// Create a new offer
        /// </summary>
        /// <param name="offer">The offer to create</param>
        /// <param name="driver_dict">A dictionary of keys and values associated with the offer</param>
        /// <param name="validate_only">Only validate the offer instead of creating it [Default: false]</param>
        /// <param name="min_coin_amount">The minimum coin amount to select for the offer [Default: none]</param>
        /// <param name="max_coin_amount">The maximum coin amount to select for the offer [Default: none]</param>
        /// <param name="solver">A marshalled solver</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CreateOfferForIds_RPC(
            Dictionary<string, long> offer, Dictionary<string, object> driver_dict, 
            bool? validate_only = null, ulong? min_coin_amount = null, ulong? max_coin_amount = null, string? solver = null, ulong? fee = null, bool? reuse_puzhash = null)
        {
            this.offer = offer;
            this.validate_only = validate_only;
            this.driver_dict = driver_dict;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.solver = solver;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
        }




        /// <summary>
        /// The offer to create
        /// </summary>
        /// <remarks>mandatory</remarks>
        public Dictionary<string,long> offer { get; set; }

        /// <summary>
        /// Only validate the offer instead of creating it [Default: false]
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? validate_only { get; set; }

        /// <summary>
        /// A dictionary of keys and values associated with the offer
        /// </summary>
        /// <remarks>mandatory</remarks>
        public Dictionary<string, object> driver_dict { get; set; }

        /// <summary>
        /// The minimum coin amount to select for the offer [Default: none]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }

        /// <summary>
        /// The maximum coin amount to select for the offer [Default: none]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; }

        /// <summary>
        /// A marshalled solver
        /// </summary>
        /// <remarks>optional</remarks>
        public string? solver { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }

        /// <summary>
        ///  If `true`, will not generate a new puzzle hash / address for this transaction only. 
        ///  Note that setting this parameter to `true` will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
