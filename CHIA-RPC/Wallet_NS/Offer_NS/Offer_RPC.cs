using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.Offer_NS
{
    /// <summary>
    /// Creates a new offer.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/offer-rpc#create_offer_for_ids"/>
    /// </remarks>
    /// <returns><see cref="Objects_NS.OfferFile"/></returns>
    public class Offer_RPC : RPCTemplate<Offer_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public Offer_RPC() { /* for serialisation */ }
        /// <summary>
        /// Creates a new offer.
        /// </summary>
        /// <param name="offer_mojos">this dictionary contains your requested additions and substractions, in mojos.</param>
        /// <param name="fee_mojos">An optional fee (in mojos) to include with the offer. Defaults to 0.</param>
        /// <param name="validate_only">Defaults to False. Set to True to verify the validity of a potential offer, rather than actually creating an offer.</param>
        /// <param name="driver_dict">A dictionary [str, Any] containing metadata of the asset being requested, for example an NFT's on-chain metadata</param>
        /// <param name="min_coin_amount_mojos">The minimum coin size to be included in the offer [Default: 0]</param>
        /// <param name="max_coin_amount_mojos">The maximum coin size to be included in the offer [Default: 0]</param>
        /// <param name="solver">Default: None</param>
        public Offer_RPC(
            Dictionary<string, long> offer_mojos, ulong? fee_mojos = null, bool? validate_only = null, 
            Dictionary<string, object>? driver_dict = null, ulong? min_coin_amount_mojos = null, ulong? max_coin_amount_mojos = null, List<KeyValuePair<string, object>>? solver = null)
        {
            this.offer = offer_mojos;
            this.fee = fee_mojos;
            this.validate_only = validate_only;
            this.driver_dict = driver_dict;
            this.min_coin_amount = min_coin_amount_mojos;
            this.max_coin_amount = max_coin_amount_mojos;
            this.solver = solver;
        }
        /// <summary>
        /// Creates a new offer.
        /// </summary>
        /// <param name="offer_xch">this dictionary contains your requested additions and substractions, in xch.</param>
        /// <param name="fee_xch">An optional fee (in xch) to include with the offer. Defaults to 0.</param>
        /// <param name="validate_only">Defaults to False. Set to True to verify the validity of a potential offer, rather than actually creating an offer.</param>
        /// <param name="driver_dict">A dictionary [str, Any] containing metadata of the asset being requested, for example an NFT's on-chain metadata</param>
        /// <param name="min_coin_amount_xch">The minimum coin size to be included in the offer [Default: 0]</param>
        /// <param name="max_coin_amount_xch">The maximum coin size to be included in the offer [Default: 0]</param>
        /// <param name="solver">Default: None</param>
        public Offer_RPC(
            Dictionary<string, decimal> offer_xch, decimal? fee_xch = null, bool? validate_only = null,
            Dictionary<string, object>? driver_dict = null, decimal? min_coin_amount_xch = null, decimal? max_coin_amount_xch = null, List<KeyValuePair<string, object>>? solver = null)
        {
            this.offer_in_xch = offer_xch;
            this.fee_in_xch = fee_xch;
            this.validate_only = validate_only;
            this.driver_dict = driver_dict;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.solver = solver;
        }

        /// <summary>
        /// this dictionary contains your requested additions and substractions, in mojos.<br/>
        /// if you wan to offer an nft for example, use the launcher id such as <br/>
        /// "1": 1000000000000 (offer for 1 xch) <br/>
        /// "cc4138f8debe4fbedf26ccae0f965be19c67a49d525f1416c0749c3c865dxxx", -1 (offer 1 nft)<br/> 
        /// </summary>
        public Dictionary<string, long> offer { get; set; }
        /// <summary>
        /// this dictionary contains your requested additions and substractions, in xch.<br/>
        /// if you want to offer an nft for example, use the launcher id such as <br/>
        /// "1": 1.0 (offer for 1 xch) <br/>
        /// "cc4138f8debe4fbedf26ccae0f965be19c67a49d525f1416c0749c3c865dxxx", -0.0000000000001 (offer one nft)<br/>
        [JsonIgnore]
        public Dictionary<string, decimal> offer_in_xch 
        { 
            get 
            {
                Dictionary<string, decimal> offers = new Dictionary<string, decimal>();
                foreach(KeyValuePair<string, long> off in offer) offers[off.Key] = off.Value/GlobalVar.OneChiaInMojos;
                return offers;
            }
            
            set
            {
                Dictionary<string, long> offers = new Dictionary<string, long>();
                foreach (KeyValuePair<string, decimal> off in value) offers[off.Key] = (long)(off.Value * GlobalVar.OneChiaInMojos);
                offer = offers;
            }
        }

        /// <summary>
        /// An optional fee (in mojos) to include with the offer. Defaults to 0.
        /// </summary>
        public ulong? fee { get; set; } = 0;
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
        /// Defaults to False. Set to True to verify the validity of a potential offer, rather than actually creating an offer.
        /// </summary>
        public bool? validate_only { get; set; } = false;

        /// <summary>
        /// A dictionary [str, Any] containing metadata of the asset being requested, for example an NFT's on-chain metadata
        /// </summary>
        public Dictionary<string, object>? driver_dict { get; set; }

        /// <summary>
        /// The minimum coin size (mojos) to be included in the offer [Default: 0]
        /// </summary>
        public ulong? min_coin_amount { get; set; } = 0;
        /// <summary>
        /// The minimum coin amount in xch to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? min_coin_amount_in_xch
        {
            get { return min_coin_amount / GlobalVar.OneChiaInMojos; }
            set { min_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// The maximum coin size (mojos) to be included in the offer [Default: 0]
        /// </summary>
        public ulong? max_coin_amount { get; set; } = 0;
        /// <summary>
        /// The maximum coin amount in xch to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? max_coin_amount_in_xch
        {
            get { return max_coin_amount / GlobalVar.OneChiaInMojos; }
            set { max_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// Default: None
        /// </summary>
        public List<KeyValuePair<string, object>>? solver { get; set; }
        public static Offer_RPC GenerateOffer_RPC(Nft[] sells, Nft[] buys, long mojoValue)
        {

            Offer_RPC offer_rpc = new Offer_RPC();
            foreach (Nft sell in sells)
            {
                //offer_rpc.offer.Add(sell.launcher_id, -1);
                offer_rpc.offer.Add(sell.launcher_id, -1);
            }
            foreach (Nft buy in buys)
            {
                //offer_rpc.offer.Add(buy.launcher_id, 1);
                offer_rpc.offer.Add(buy.launcher_id, 1);
            }
            // offer_rpc.offer.Add("1", mojoValue);
            offer_rpc.offer.Add("1", mojoValue);
            return offer_rpc;
        }
    }
}
