using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Add a new mirror from a local or remote data store. Triggers a Chia transaction
    /// </summary>
    /// <remarks>Request returns a success_response</remarks>
    public class GetSignagePoint_RPC : RPCTemplate<GetSignagePoint_RPC>
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
