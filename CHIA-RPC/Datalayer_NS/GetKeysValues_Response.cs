using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Get all keys and values for a store. Must be subscribed to store ID
    /// </summary>

    public class GetKeysValues_Response : ResponseTemplate<GetKeysValues_Response>
    {
        /// <summary>
        /// all available keyvaluepairs
        /// </summary>
        public DataStoreKeyValuePair[] keys_values { get; set; }
    }
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
