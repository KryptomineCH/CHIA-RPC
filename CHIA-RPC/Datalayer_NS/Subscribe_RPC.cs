using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Subscribe to a store ID
    /// </summary>
    /// <remarks>request returns a success response</remarks>
    public class Subscribe_RPC : RPCTemplate<Subscribe_RPC>
    {
        /// <summary>
        /// The hexadecimal store ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// A list of URLs where the data store resides. This list can be left blank
        /// </summary>
        public string[] urls { get; set; } = new string[] { };
    }
}
