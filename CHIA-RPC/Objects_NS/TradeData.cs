using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    public class TradeData : ObjectTemplate<TradeData>
    {
        /// <summary>
        /// Address of the trading party
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// The amount (in mojos) of fungible asset to be traded
        /// </summary>
        public ulong amount { get; set; }

        /// <summary>
        /// The amount (in xch) of fungible asset to be traded
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// The fungible asset to be traded
        /// </summary>
        public string asset { get; set; }
    }
}
