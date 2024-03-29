﻿
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
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
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only.</param>
        /// <param name="min_height">The height at which the offer becomes valid</param>
        /// <param name="max_height">The height at which the offer becomes invalid</param>
        /// <param name="min_time_dateTime">The rough time at which the offer becomes valid</param>
        /// <param name="max_time_dateTime">The rough time at which the offer becomes invalid</param>
        public CreateOfferForIds_RPC(
            Dictionary<string, long> offer, Dictionary<string, object> driver_dict, 
            bool? validate_only = null, ulong? min_coin_amount = null, ulong? max_coin_amount = null, string? solver = null, ulong? fee = null, bool? reuse_puzhash = null,
            ulong? min_height = null, ulong? max_height = null, DateTime? min_time_dateTime = null, DateTime? max_time_dateTime = null)
        {
            this.offer = offer;
            this.validate_only = validate_only;
            this.driver_dict = driver_dict;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.solver = solver;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
            this.min_height = min_height;
            this.max_height = max_height;
            this.min_time_DateTime = min_time_dateTime;
            this.max_time_DateTime = max_time_dateTime;
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
        /// <param name="reuse_puzhash">If `true`, will not generate a new puzzle hash / address for this transaction only.</param>
        /// <param name="min_height">The height at which the offer becomes valid</param>
        /// <param name="max_height">The height at which the offer becomes invalid</param>
        /// <param name="min_time_dateTime">The rough time at which the offer becomes valid</param>
        /// <param name="max_time_dateTime">The rough time at which the offer becomes invalid</param>
        public CreateOfferForIds_RPC(
            Dictionary<string, decimal> offer_xch, Dictionary<string, object> driver_dict,
            bool? validate_only = null, decimal? min_coin_amount_xch = null, decimal? max_coin_amount_xch = null, string? solver = null, decimal? fee_xch = null, bool? reuse_puzhash = null,
            ulong? min_height = null, ulong? max_height = null, DateTime? min_time_dateTime = null, DateTime? max_time_dateTime = null)
        {
            this.offer_in_xch = offer_xch;
            this.validate_only = validate_only;
            this.driver_dict = driver_dict;
            min_coin_amount_in_xch = min_coin_amount_xch;
            max_coin_amount_in_xch = max_coin_amount_xch;
            this.solver = solver;
            fee_in_xch = fee_xch;
            this.reuse_puzhash = reuse_puzhash;
            this.min_height = min_height;
            this.max_height = max_height;
            this.min_time_DateTime = min_time_dateTime;
            this.max_time_DateTime= max_time_dateTime;
        }

        /// <summary>
        /// The offer (additions and removals) to create <br/>
        /// string (key) is the asset ID and long (amount) the amount of mojos<br/>
        /// the asset id 1 equals xch.<br/>
        /// a negative mojo amount means you give something away<br/>
        /// a positive mojo amount means you are asking for something
        /// </summary>
        /// <remarks>mandatory</remarks>
        public Dictionary<string, long> offer { get; set; } = new Dictionary<string, long>();
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
        [JsonIgnore]
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
        /// <summary>
        /// adds a new element (xch or cat), buy or sell to the offer.<br/>
        /// This function is generic for xch and chia, for nfts or specific cat files, use the specific parameters
        /// </summary>
        /// <remarks>WARNING: NOT Suitable for NFTs! Use the extensionmethod which takes an NFT instead!</remarks>
        /// <param name="assetId">the ID of the asset to offer (1 for chia)</param>
        /// <param name="value">represents the total decimal amount (automatically converted to mojos)</param>
        public void AddOfferPosition(string assetId, decimal value)
        {
            if (offer == null) offer = new Dictionary<string, long>();
            if (assetId == "1")
            {
                offer.Add(assetId, (long)(value * GlobalVar.OneChiaInMojos));
            }
            else
            {
                offer.Add(assetId, (long)(value * GlobalVar.OneCatInMojos));
            }
        }
        /// <summary>
        /// add chia value to the offer
        /// </summary>
        /// <param name="value">the amount of chia to offer (decimal)</param>
        public void AddOfferPosition(decimal value)
        {
            if (offer == null) offer = new Dictionary<string, long>();
            offer.Add("1", (long)(value * GlobalVar.OneChiaInMojos));
        }
        /// <summary>
        /// add cat to the offer
        /// </summary>
        /// <param name="cat">the cat to offer</param>
        /// <param name="value">the value of the cat to offer (decimal)</param>
        public void AddOfferPosition(GetCatList_Response.CatItem cat,decimal value)
        {
            if (offer == null) offer = new Dictionary<string, long>();
            offer.Add(cat.asset_id, (long)(value * GlobalVar.OneCatInMojos));
        }
        /// <summary>
        /// add cat to the offer
        /// </summary>
        /// <param name="cat">the cat to offer</param>
        /// <param name="value">the value of the cat to offer (decimal)</param>
        public void AddOfferPosition(CatGetAssetId_Response cat, decimal value)
        {
            if (offer == null) offer = new Dictionary<string, long>();
            offer.Add(cat.asset_id, (long)(value * GlobalVar.OneCatInMojos));
        }
        /// <summary>
        /// add cat to the offer
        /// </summary>
        /// <param name="nft">the nft to add to the offer</param>
        /// <param name="amount">the count of this nft to offer (usually -1 or 1)</param>
        public void AddOfferPosition(Nft nft, long amount = 1)
        {
            if (offer == null) offer = new Dictionary<string, long>();
            offer.Add(nft.launcher_id, amount);
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
        public Dictionary<string, object>? driver_dict { get; set; }

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
        /// The minimum block height that must be reached before this Offer becomes valid [Default: `null` (not used)]
        /// </summary>
        public ulong? min_height { get; set; }
        /// <summary>
        /// The minimum UNIX timestamp that must be reached before this Offer becomes valid [Default: `null` (not used)]
        /// </summary>
        public ulong? min_time { get; set; }
        /// <summary>
        /// The maximum block height where this Offer is still considered valid, aka the expiry height [Default: `null` (not used)]
        /// </summary>
        /// // DateTime getters & setters for min_time and max_time
        [JsonIgnore]
        public DateTime? min_time_DateTime
        {
            get
            {
                if (min_time.HasValue)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)min_time.Value);
                    return dateTimeOffset.DateTime;
                }
                return null;
            }
            set {
                if (value.HasValue)
                {
                    
                    min_time = (ulong?)new DateTimeOffset((DateTime)value).ToUnixTimeSeconds();
                }
                else
                {
                    min_time = null;
                }
            }
        }
        public ulong? max_height { get; set; }
        /// <summary>
        /// The maximum UNIX timestamp where this Offer is stil considered valid, aka the expiry timestamp [Default: `null` (not used)] 
        /// </summary>
        public ulong? max_time { get; set; }
        [JsonIgnore]
        public DateTime? max_time_DateTime
        {
            get
            {
                if (max_time.HasValue)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)max_time.Value);
                    return dateTimeOffset.DateTime;
                }
                return null;
            }
            set
            {
                if (value.HasValue)
                {

                    max_time = (ulong?)new DateTimeOffset((DateTime)value).ToUnixTimeSeconds();
                }
                else
                {
                    max_time = null;
                }
            }
        }

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
