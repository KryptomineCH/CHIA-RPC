using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get all keys associated with a store_id
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_keys"/><br/><br/>
    /// Uses:<br/><see cref="GetKeys_RPC"/>
    /// </remarks>
    public class GetKeys_Response : ResponseTemplate<GetKeys_Response>
    {
        /// <summary>
        /// all available keys in the data store
        /// </summary>
        public string[] keys { get; set; }
    }
    /// <summary>
    /// Get all keys associated with a store_id<br/>
    /// root hash is important to make sure not to receive stale data
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#get_keys"/></remarks>
    /// <returns><see cref="GetKeys_RPC"/></returns>
    public class GetKeys_RPC : RPCTemplate<GetKeys_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public GetKeys_RPC() { /* for serialisation */ }
        /// <summary>
        /// Get all keys associated with a store_id
        /// </summary>
        /// <param name="storeId">The hexadecimal store ID</param>
        /// <param name="rootHash">The root hash from which to obtain data</param>
        public GetKeys_RPC(string storeId, string? rootHash = null)
        {
            id = storeId;
            root_hash = rootHash;
        }
        /// <summary>
        /// the hexadecimal data store id which to fetch a value from
        /// </summary>
        /// <remarks>encoded as hexadecimal string<br/>
        /// mandatory</remarks>
        public string id { get; set; }

        /// <summary>
        /// The root hash from which to obtain data
        /// </summary>
        /// <remarks>optional</remarks>
        public string? root_hash { get; set; }
    }
}
