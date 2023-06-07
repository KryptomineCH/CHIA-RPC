
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// takes (accepts) a cat offer
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#take_offer"/></remarks>
    /// <returns><see cref="General_NS.TradeRecord_Response"/></returns>
    public class TakeCatOffer_RPC : RPCTemplate<TakeCatOffer_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public TakeCatOffer_RPC() { /* for serialisation */ }

        /// <summary>
        /// takes (accepts) a cat offer
        /// </summary>
        /// <param name="offer">the offer to create.</param>
        /// <param name="min_coin_amount">the minimum coin amount to select for taking the offer.</param>
        /// <param name="max_coin_amount">the maximum coin amount to select for taking the offer.</param>
        /// <param name="solver">A marshalled solver</param>
        /// <param name="fee">A optional blockchain fee, in mojos.</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public TakeCatOffer_RPC(string offer, ulong? min_coin_amount = null, ulong? max_coin_amount = null, string? solver = null, ulong? fee = null, bool? reuse_puzhash = null)
        {
            this.offer = offer;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.solver = solver;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// takes (accepts) a cat offer
        /// </summary>
        /// <param name="offer">the offer to create.</param>
        /// <param name="min_coin_amount">the minimum coin amount to select for taking the offer.</param>
        /// <param name="max_coin_amount">the maximum coin amount to select for taking the offer.</param>
        /// <param name="solver">A marshalled solver</param>
        /// <param name="fee">A optional blockchain fee, in mojos.</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public TakeCatOffer_RPC(OfferFile offer, ulong? min_coin_amount = null, ulong? max_coin_amount = null, string? solver = null, ulong? fee = null, bool? reuse_puzhash = null)
        {
            this.offer = offer.offer;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.solver = solver;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// the offer to take.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string offer { get; set; }

        /// <summary>
        /// the minimum coin amount to select for taking the offer.<br/>
        /// Default: none
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }

        /// <summary>
        /// the maximum coin amount to select for taking the offer.<br/>
        /// Default: none
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; }

        /// <summary>
        /// A marshalled solver
        /// </summary>
        /// <remarks>optional</remarks>
        public string? solver { get; set; }

        /// <summary>
        /// a optional blockchain fee, in mojos.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }

        /// <summary>
        ///  If `true`, will not generate a new puzzle hash / address for this transaction only. <br/>
        ///  Note that setting this parameter to `true` will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
