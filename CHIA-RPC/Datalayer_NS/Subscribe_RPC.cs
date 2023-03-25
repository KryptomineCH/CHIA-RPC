using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Subscribe to a store ID
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#subscribe"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
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
