using CHIA_RPC.HelperFunctions_NS;

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
        /// The hexadecimal ID of the store to mirror
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string id { get; set; }

        /// <summary>
        /// A list of URLs where the mirror will reside.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[] urls { get; set; }

        /// <summary>
        /// The number of mojos to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong amount { get; set; }

        /// <summary>
        /// Set the fee for the transaction, in mojos
        /// </summary>
        /// <remares>optional</remares>
        public ulong? fee { get; set; }
    }
}
