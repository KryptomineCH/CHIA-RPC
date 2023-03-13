using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Get all keys associated with a store_id
    /// </summary>
    /// <remarks>
    /// the rpc is an ID_RPC
    /// </remarks>
    public class GetKeys_Response : ResponseTemplate<GetKeys_Response>
    {
        /// <summary>
        /// all available keys in the data store
        /// </summary>
        public string[] keys { get; set; }
    }
}
