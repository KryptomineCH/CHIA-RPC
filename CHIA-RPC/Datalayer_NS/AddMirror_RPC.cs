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
        /// The hexadecimal ID of the store to mirror
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// A list of URLs where the mirror will reside. Can be empty
        /// </summary>
        public string[] urls { get; set; }

        /// <summary>
        /// The number of mojos to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized
        /// </summary>
        public ulong amount { get; set; }

        /// <summary>
        /// Set the fee for the transaction, in mojos
        /// </summary>
        /// <remares>optional</remares>
        public ulong? fee { get; set; }
    }
}
