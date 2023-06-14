using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS
{
    public class CatOfferSummary : ObjectTemplate<CatOfferSummary>
    {
        /// <summary>
        /// The fees (in mojos) associated with the offer.
        /// </summary>
        public ulong fees { get; set; }
        /// <summary>
        /// The fees (in xch) associated with the offer.
        /// </summary>
        [JsonIgnore]
        public decimal fees_in_xch
        {
            get { return fees / GlobalVar.OneChiaInMojos; }
            set { fees = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// A dictionary containing information about the offer.
        /// </summary>
        public Dictionary<string, OfferInfo> infos { get; set; }

        /// <summary>
        /// A dictionary containing the offered amounts (in mojos) with their corresponding keys.
        /// </summary>
        public Dictionary<string, ulong> offered { get; set; }
        /// <summary>
        /// A dictionary containing the offered amounts (in xch) with their corresponding keys.
        /// </summary>
        [JsonIgnore]
        public Dictionary<string, decimal> offered_in_xch
        {
            get
            {
                Dictionary<string, decimal> offers = new Dictionary<string, decimal>();
                foreach (KeyValuePair<string, ulong> off in offered) offers[off.Key] = off.Value / GlobalVar.OneChiaInMojos;
                return offers;
            }

            set
            {
                Dictionary<string, ulong> offers = new Dictionary<string, ulong>();
                foreach (KeyValuePair<string, decimal> off in value) offers[off.Key] = (ulong)(off.Value * GlobalVar.OneChiaInMojos);
                offered = offers;
            }
        }

        /// <summary>
        /// A dictionary containing the requested amounts (in mojos) with their corresponding keys.
        /// </summary>
        public Dictionary<string, ulong> requested { get; set; }
        /// <summary>
        /// A dictionary containing the requested amounts (in xch) with their corresponding keys.
        /// </summary>
        [JsonIgnore]
        public Dictionary<string, decimal> requested_in_xch
        {
            get
            {
                Dictionary<string, decimal> requests = new Dictionary<string, decimal>();
                foreach (KeyValuePair<string, ulong> off in requested) requests[off.Key] = off.Value / GlobalVar.OneChiaInMojos;
                return requests;
            }

            set
            {
                Dictionary<string, ulong> requests = new Dictionary<string, ulong>();
                foreach (KeyValuePair<string, decimal> off in value) requests[off.Key] = (ulong)(off.Value * GlobalVar.OneChiaInMojos);
                requested = requests;
            }
        }
    }
}
