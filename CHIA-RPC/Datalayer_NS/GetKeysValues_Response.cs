using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get all keys and values for a store. Must be subscribed to store ID
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_keys_values"/><br/><br/>
    /// Uses:<br/><see cref="GetKeys_RPC"/>
    /// </remarks>
    public class GetKeysValues_Response : ResponseTemplate<GetKeysValues_Response>
    {
        /// <summary>
        /// all available keyvaluepairs
        /// </summary>
        public DataStoreKeyValuePair[] keys_values { get; set; }
    }
    /// <summary>
    /// a key and value for a store. Must be subscribed to store ID
    /// </summary>
    ///  <remarks><see href="https://docs.chia.net/datalayer-rpc/#get_keys_values"/></remarks>
    public class DataStoreKeyValuePair : ObjectTemplate<DataStoreKeyValuePair>
    {
        public object atom { get; set; }
        /// <summary>
        /// validation hash sum
        /// </summary>
        public string hash { get; set; }
        /// <summary>
        /// the hex encoded key (unique identifier) of this keyvaluepair
        /// </summary>
        public string key { get; set; }
        /// <summary>
        /// the hex encoded value of this keyvaluepair
        /// </summary>
        public string value { get; set; }
    }
}
