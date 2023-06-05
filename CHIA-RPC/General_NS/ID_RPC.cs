using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// an id is a uniqe identifier used for a variety of lookup tasks
    /// </summary>
    public class ID_RPC : RPCTemplate<ID_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serialisation
        /// </summary>
        public ID_RPC() { /* required for serializer */ }
        /// <summary>
        /// an id is a uniqe identifier used for a variety of lookup tasks
        /// </summary>
        /// <param name="id">the unique identifier</param>
        /// <param name="fee">note: this value may only be used for requests which trigger a transaction on the blockchain</param>
        public ID_RPC(string id, ulong? fee = null)
        {
            this.id = id;
            this.fee = fee;
        }
        /// <summary>
        /// the unique identifier
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string id { get; set; }
        /// <summary>
        /// note: this value may only be used for requests which trigger a transaction on the blockchain
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}
