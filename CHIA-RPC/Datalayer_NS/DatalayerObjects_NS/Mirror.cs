using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// Represents a mirror object.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_mirrors"/>
    /// </remarks>
    public class Mirror : ObjectTemplate<Mirror>
    {
        /// <summary>
        /// the value in mojos
        /// </summary>
        public ulong amount { get; set; }
        /// <summary>
        /// the value in xch
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// Gets or sets the coin ID.
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// Gets or sets the launcher ID.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this mirror is ours.
        /// </summary>
        public bool ours { get; set; }

        /// <summary>
        /// Gets or sets the URLs.
        /// </summary>
        public string[] urls { get; set; }
    }
}
