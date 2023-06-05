using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Return all ancestors of a given hash
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_ancestors"/><br/><br/>
    /// Uses:<br/><see cref="GetAncestors_RPC"/>
    /// </remarks>
    public class GetAncestors_Response : ResponseTemplate<GetAncestors_Response>
    {
        /// <summary>
        /// please refer to the original documentation at 
        /// </summary>
        /// <remarks>https://docs.chia.net/datalayer-rpc#get_ancestors</remarks>
        public object[] ancestors { get; set; }
    }
    /// <summary>
    /// Create a data store. Triggers a Chia transaction
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc/#get_ancestors"/></remarks>
    /// <returns><see cref="GetAncestors_Response"/></returns>
    public class GetAncestors_RPC : RPCTemplate<GetAncestors_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public GetAncestors_RPC() { /* for serialisation */}
        /// <summary>
        /// Return all ancestors of a given hash
        /// </summary>
        /// <param name="id">The hexadecimal store ID</param>
        /// <param name="hash">The hash from which to display ancestors</param>
        public GetAncestors_RPC(string id, string hash) 
        {
            this.id = id;
            this.hash = hash;
        }
        /// <summary>
        /// Return all ancestors of a given hash
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string id { set; get; }
        /// <summary>
        /// The hash from which to display ancestors
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string hash { set; get; }
    }
}
