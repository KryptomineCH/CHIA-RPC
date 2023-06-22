
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

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
        public CreateOfferForIds_RPC() {
            /* for serialisation */
            offer = new Dictionary<string, long>();
        }

        /// <summary>
        /// Create a new offer
        /// </summary>
        /// <param name="offer">
        /// The offer (additions and removals) to create <br/>
        /// string (key) is the asset ID and long (amount) the amount of mojos<br/>
        /// the asset id 1 equals xch.<br/>
        /// a negative mojo amount means you give something away<br/>
        /// a positive mojo amount means you are asking for something
        /// </param>
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
        /// Create a new offer
        /// </summary>
        /// <param name="offer_xch">
        /// The offer (additions and removals) to create <br/>
        /// string (key) is the asset ID and decimal (amount) the amount in full xch<br/>
        /// the asset id 1 equals xch.<br/>
        /// a negative amount means you give something away<br/>
        /// a positive amount means you are asking for something<br/>
        /// note that for nfts and cats is recommended to use the long (mojo) entity since 1 nft = 1 mojo and 1 cat = 1000 mojo
        /// </param>
        /// <param name="driver_dict">A dictionary of keys and values associated with the offer</param>
        /// <param name="validate_only">Only validate the offer instead of creating it [Default: false]</param>
        /// <param name="min_coin_amount_xch">The minimum coin amount to select for the offer [Default: none]</param>
        /// <param name="max_coin_amount_xch">The maximum coin amount to select for the offer [Default: none]</param>
        /// <param name="solver">A marshalled solver</param>
        /// <param name="fee_xch">An optional blockchain fee, in mojos</param>
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public CreateOfferForIds_RPC(
            Dictionary<string, decimal> offer_xch, Dictionary<string, object> driver_dict,
            bool? validate_only = null, decimal? min_coin_amount_xch = null, decimal? max_coin_amount_xch = null, string? solver = null, decimal? fee_xch = null, bool? reuse_puzhash = null)
        {
            this.offer_in_xch = offer_xch;
            this.validate_only = validate_only;
            this.driver_dict = driver_dict;
            min_coin_amount_in_xch = min_coin_amount_xch;
            max_coin_amount_in_xch = max_coin_amount_xch;
            this.solver = solver;
            fee_in_xch = fee_xch;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// The offer (additions and removals) to create <br/>
        /// string (key) is the asset ID and long (amount) the amount of mojos<br/>
        /// the asset id 1 equals xch.<br/>
        /// a negative mojo amount means you give something away<br/>
        /// a positive mojo amount means you are asking for something
        /// </summary>
        /// <remarks>mandatory</remarks>
        public Dictionary<string,long> offer { get; set; }
        /// <summary>
        /// The offer (additions and removals) to create <br/>
        /// string (key) is the asset ID and decimal (amount) the amount to trade<br/>
        /// the asset id 1 equals xch.<br/>
        /// a negative amount means you give something away<br/>
        /// a positive amount means you are asking for something<br/>
        /// note that for nfts and cats is recommended to use the long (mojo) entity since 1 nft = 1 mojo and 1 cat = 1000 mojo
        /// </summary>
        /// <remarks>
        /// DO NOT Modify directly offer_in_xch.Add(value)<br/>
        /// use AddOfferPosition instead!
        /// mandatory</remarks> 

        public Dictionary<string,decimal> offer_in_xch
        {
            get
            {
                Dictionary<string, decimal> convertedOffers = new Dictionary<string, decimal>();
                foreach(KeyValuePair<string, long> position in offer) convertedOffers[position.Key] = (position.Value/GlobalVar.OneChiaInMojos);
                return convertedOffers;
            }
            set
            {
                Dictionary<string, long> convertedOffers = new Dictionary<string, long>();
                foreach (KeyValuePair<string, decimal> position in value) convertedOffers[position.Key] = (long)(position.Value * GlobalVar.OneChiaInMojos);
                offer = convertedOffers;
            }
        }
        public void AddOfferPosition(string key, decimal value)
        {
            offer.Add(key, (long)(value * GlobalVar.OneChiaInMojos));
        }

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
        /// The minimum coin amount (mojos) to select for the offer [Default: none]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// The minimum coin amount (xch) to select for the offer [Default: none]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? min_coin_amount_in_xch
        {
            get { return min_coin_amount / GlobalVar.OneChiaInMojos; }
            set { min_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// The maximum coin amount (mojos) to select for the offer [Default: none]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; }
        /// <summary>
        /// The maximum coin amount (xch) to select for the offer [Default: none]
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
        /// An optional blockchain fee, in mojos
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
        ///  If `true`, will not generate a new puzzle hash / address for this transaction only. 
        ///  Note that setting this parameter to `true` will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
