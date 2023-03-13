using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Return all ancestors of a given hash
    /// </summary>
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
    public class GetAncestors_RPC : RPCTemplate<GetAncestors_RPC>
    {
        /// <summary>
        /// Return all ancestors of a given hash
        /// </summary>
        public string id { set; get; }
        /// <summary>
        /// The hash from which to display ancestors
        /// </summary>
        public string hash { set; get; }
    }
}
