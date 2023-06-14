
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS;
using System.Text.Json.Serialization;

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
        /// <param name="min_coin_amount_mojos">the minimum coin amount to select for taking the offer.</param>
        /// <param name="max_coin_amount_mojos">the maximum coin amount to select for taking the offer.</param>
        /// <param name="solver">A marshalled solver</param>
        /// <param name="fee_mojos">A optional blockchain fee, in mojos.</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public TakeCatOffer_RPC(string offer, ulong? min_coin_amount_mojos = null, ulong? max_coin_amount_mojos = null, string? solver = null, ulong? fee_mojos = null, bool? reuse_puzhash = null)
        {
            this.offer = offer;
            this.min_coin_amount = min_coin_amount_mojos;
            this.max_coin_amount = max_coin_amount_mojos;
            this.solver = solver;
            this.fee = fee_mojos;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// takes (accepts) a cat offer
        /// </summary>
        /// <param name="offer">the offer to create.</param>
        /// <param name="min_coin_amount_xch">the minimum coin amount to select for taking the offer.</param>
        /// <param name="max_coin_amount_xch">the maximum coin amount to select for taking the offer.</param>
        /// <param name="solver">A marshalled solver</param>
        /// <param name="fee_xch">A optional blockchain fee, in mojos.</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public TakeCatOffer_RPC(string offer, decimal? min_coin_amount_xch = null, decimal? max_coin_amount_xch = null, string? solver = null, decimal? fee_xch = null, bool? reuse_puzhash = null)
        {
            this.offer = offer;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.solver = solver;
            this.fee_in_xch = fee_xch;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// takes (accepts) a cat offer
        /// </summary>
        /// <param name="offer">the offer to create.</param>
        /// <param name="min_coin_amount_mojos">the minimum coin amount to select for taking the offer.</param>
        /// <param name="max_coin_amount_mojos">the maximum coin amount to select for taking the offer.</param>
        /// <param name="solver">A marshalled solver</param>
        /// <param name="fee_mojos">A optional blockchain fee, in mojos.</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public TakeCatOffer_RPC(OfferFile offer, ulong? min_coin_amount_mojos = null, ulong? max_coin_amount_mojos = null, string? solver = null, ulong? fee_mojos = null, bool? reuse_puzhash = null)
        {
            this.offer = offer.offer;
            this.min_coin_amount = min_coin_amount_mojos;
            this.max_coin_amount = max_coin_amount_mojos;
            this.solver = solver;
            this.fee = fee_mojos;
            this.reuse_puzhash = reuse_puzhash;
        }
        /// <summary>
        /// takes (accepts) a cat offer
        /// </summary>
        /// <param name="offer">the offer to create.</param>
        /// <param name="min_coin_amount_xch">the minimum coin amount to select for taking the offer.</param>
        /// <param name="max_coin_amount_xch">the maximum coin amount to select for taking the offer.</param>
        /// <param name="solver">A marshalled solver</param>
        /// <param name="fee_xch">A optional blockchain fee, in mojos.</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public TakeCatOffer_RPC(OfferFile offer, decimal? min_coin_amount_xch = null, decimal? max_coin_amount_xch = null, string? solver = null, decimal? fee_xch = null, bool? reuse_puzhash = null)
        {
            this.offer = offer.offer;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.solver = solver;
            this.fee_in_xch = fee_xch;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// the offer to take.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string offer { get; set; }

        /// <summary>
        /// the minimum coin amount (mojos) to select for taking the offer.<br/>
        /// Default: none
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// the minimum coin amount (xch) to select for taking the offer.<br/>
        /// Default: none
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? min_coin_amount_in_xch
        {
            get { return min_coin_amount / GlobalVar.OneChiaInMojos; }
            set { min_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// the maximum coin amount (mojos) to select for taking the offer.<br/>
        /// Default: none
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; }
        /// <summary>
        /// the maximum coin amount (xch) to select for taking the offer.<br/>
        /// Default: none
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? max_coin_amount_in_xch
        {
            get { return max_coin_amount / GlobalVar.OneChiaInMojos; }
            set { max_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

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
        /// the amount of xch to set as fee
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? fee_in_xch
        {
            get { return fee / GlobalVar.OneChiaInMojos; }
            set { fee = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        ///  If `true`, will not generate a new puzzle hash / address for this transaction only. <br/>
        ///  Note that setting this parameter to `true` will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
