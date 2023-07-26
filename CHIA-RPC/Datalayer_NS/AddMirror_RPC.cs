using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Add a new mirror from a local or remote data store. Triggers a Chia transaction
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#add_mirror"/>
    /// </remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class AddMirror_RPC : RPCTemplate<AddMirror_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public AddMirror_RPC() { /* required for json serialisation */}
        /// <summary>
        /// Add a new mirror from a local or remote data store. Triggers a Chia transaction
        /// </summary>
        /// <param name="id">The hexadecimal ID of the store to mirror</param>
        /// <param name="urls">A list of URLs where the mirror will reside.</param>
        /// <param name="amount">The number of mojos to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized</param>
        /// <param name="fee">Set the fee for the transaction, in mojos</param>
        public AddMirror_RPC(string id, string[] urls, ulong amount, ulong? fee = null)
        {
            this.id = id;
            this.urls = urls;
            this.amount = amount;
            this.fee = fee;
        }
        /// <summary>
        /// Add a new mirror from a local or remote data store. Triggers a Chia transaction
        /// </summary>
        /// <param name="id">The hexadecimal ID of the store to mirror</param>
        /// <param name="urls">A list of URLs where the mirror will reside.</param>
        /// <param name="amount_xch">The number of mojos to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized</param>
        /// <param name="fee_xch">Set the fee for the transaction, in mojos</param>
        public AddMirror_RPC(string id, string[] urls, decimal amount_xch, decimal? fee_xch = null)
        {
            this.id = id;
            this.urls = urls;
            this.amount_in_xch = amount_xch;
            this.fee_in_xch = fee_xch;
        }

        /// <summary>
        /// The hexadecimal ID of the store to mirror
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? id { get; set; }

        /// <summary>
        /// A list of URLs where the mirror will reside.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[]? urls { get; set; }

        /// <summary>
        /// The number of mojos to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized
        /// </summary>
        /// <remarks>mandatory</remarks>
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
        /// Set the fee for the transaction, in mojos
        /// </summary>
        /// <remares>optional</remares>
        public ulong? fee { get; set; }
        /// <summary>
        /// the transaction amount in xch
        /// </summary>
        /// <remarks>This value is derived from the mojos fee_amount</remarks>
        [JsonIgnore]
        public decimal? fee_in_xch
        {
            get { return fee / GlobalVar.OneChiaInMojos; }
            set { fee = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
    }
}
