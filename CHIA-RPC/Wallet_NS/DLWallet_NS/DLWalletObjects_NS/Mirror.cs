using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS
{
    /// <summary>
    /// Represents a mirror in the response.
    /// </summary>
    public class Mirror : ObjectTemplate<Mirror>
    {
        /// <summary>
        /// The amount (mojos) associated with the mirror.
        /// </summary>
        public ulong amount { get; set; }

        /// <summary>
        /// the transaction amount in full chia
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// The coin ID associated with the mirror.
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// The launcher ID associated with the mirror.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// Indicates if the mirror is owned by us.
        /// </summary>
        public bool ours { get; set; }

        /// <summary>
        /// An array of URLs associated with the mirror.
        /// </summary>
        public string[] urls { get; set; }
    }
}
