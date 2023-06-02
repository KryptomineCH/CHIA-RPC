using CHIA_RPC.General_NS;
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
        public Subscribe_RPC() { /* for serialisation */ }
        /// <summary>
        /// Subscribe to a store ID
        /// </summary>
        /// <param name="id">The hexadecimal store ID</param>
        /// <param name="urls">A list of URLs where the data store resides. This list can be left blank</param>
        public Subscribe_RPC(string id, string[]? urls = null)
        {
            this.id = id;
            if (urls != null)
            {
                this.urls = urls;
            }
        }

        /// <summary>
        /// The hexadecimal store ID
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string id { get; set; }

        /// <summary>
        /// A list of URLs where the data store resides. This list can be left blank
        /// </summary>
        /// <remarks>mandatory but array can be empty</remarks>
        public string[] urls { get; set; } = new string[] { };
        
        public ID_RPC ToID_RPC()
        {
            return new ID_RPC(id);
        }
        public static implicit operator ID_RPC(Subscribe_RPC subscribeRpc)
        {
            return subscribeRpc.ToID_RPC();
        }
    }
}
