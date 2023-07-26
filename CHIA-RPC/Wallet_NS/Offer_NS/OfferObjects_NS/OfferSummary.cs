using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS
{
    /// <summary>
    /// This class provides a summary of the CAT (Chia Asset Tokens) offer. It is used to summarize the fees, 
    /// information, offered amounts, and requested amounts associated with the CAT offer. The amounts are provided 
    /// in both the base unit (mojos) and the human-readable unit (XCH). It inherits from the generic class 
    /// ObjectTemplate with itself as the type parameter.
    /// </summary>
    public class CatOfferSummary : ObjectTemplate<CatOfferSummary>
    {
        /// <summary>
        /// The fees associated with the offer, represented in the base unit (mojos).
        /// </summary>
        public ulong fees { get; set; }
        /// <summary>
        /// The fees associated with the offer, represented in the human-readable unit (XCH). 
        /// Conversion between mojos and XCH is handled automatically by the getter and setter.
        /// This property is not serialized into JSON when the object is serialized.
        /// </summary>
        [JsonIgnore]
        public decimal fees_in_xch
        {
            get { return fees / GlobalVar.OneChiaInMojos; }
            set { fees = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// A dictionary containing additional information about the offer. The keys and values are both strings.
        /// This property is nullable, and will be null if no additional information is provided.
        /// </summary>
        public Dictionary<string, OfferInfo>? infos { get; set; }

        /// <summary>
        /// A dictionary containing the amounts offered for each asset, represented in the base unit (mojos). 
        /// The keys are the asset names, and the values are the offered amounts.
        /// This property is nullable, and will be null if no offers are made.
        /// </summary>
        public Dictionary<string, ulong>? offered { get; set; }

        /// <summary>
        /// A dictionary containing the amounts offered for each asset, represented in the human-readable unit (XCH).
        /// Conversion between mojos and XCH is handled automatically by the getter and setter.
        /// This property is not serialized into JSON when the object is serialized.
        /// </summary>
        [JsonIgnore]
        public Dictionary<string, decimal>? offered_in_xch
        {
            get
            {
                if (offered == null) return null;
                Dictionary<string, decimal> offers = new Dictionary<string, decimal>();
                foreach (KeyValuePair<string, ulong> off in offered) offers[off.Key] = off.Value / GlobalVar.OneChiaInMojos;
                return offers;
            }

            set
            {
                if (value == null)
                {
                    offered = null;
                    return;
                }
                Dictionary<string, ulong> offers = new Dictionary<string, ulong>();
                foreach (KeyValuePair<string, decimal> off in value) offers[off.Key] = (ulong)(off.Value * GlobalVar.OneChiaInMojos);
                offered = offers;
            }
        }

        /// <summary>
        /// A dictionary containing the amounts requested for each asset, represented in the base unit (mojos). 
        /// The keys are the asset names, and the values are the requested amounts.
        /// This property is nullable, and will be null if no requests are made.
        /// </summary>
        public Dictionary<string, ulong>? requested { get; set; }

        /// <summary>
        /// A dictionary containing the amounts requested for each asset, represented in the human-readable unit (XCH).
        /// Conversion between mojos and XCH is handled automatically by the getter and setter.
        /// This property is not serialized into JSON when the object is serialized.
        /// </summary>
        [JsonIgnore]
        public Dictionary<string, decimal>? requested_in_xch
        {
            get
            {
                if (requested == null) return null;
                Dictionary<string, decimal> requests = new Dictionary<string, decimal>();
                foreach (KeyValuePair<string, ulong> off in requested) requests[off.Key] = off.Value / GlobalVar.OneChiaInMojos;
                return requests;
            }

            set
            {
                if (value == null)
                {
                    requested = null; 
                    return;
                }
                Dictionary<string, ulong> requests = new Dictionary<string, ulong>();
                foreach (KeyValuePair<string, decimal> off in value) requests[off.Key] = (ulong)(off.Value * GlobalVar.OneChiaInMojos);
                requested = requests;
            }
        }
    }
}
