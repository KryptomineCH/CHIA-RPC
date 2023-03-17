using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get all keys associated with a store_id
    /// </summary>
    /// <remarks>
    /// request requires an <see cref="General_NS.ID_RPC"/><br/>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_keys"/>
    /// </remarks>
    public class GetKeys_Response : ResponseTemplate<GetKeys_Response>
    {
        /// <summary>
        /// all available keys in the data store
        /// </summary>
        public string[] keys { get; set; }
    }
}
