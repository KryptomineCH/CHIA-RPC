using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    public class Notification : ObjectTemplate<Notification>
    {
        /// <summary>
        /// the notification value in mojos
        /// </summary>
        public ulong amount { get; set; }
        /// <summary>
        /// the notification amount in xch
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        public string id { get; set; }
        public string message { get; set; }
    }
}
