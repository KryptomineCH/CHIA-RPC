
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// object to change a value in the data store dictionary. keys and value strings must be converted encoded as hex
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#batch_update"/></remarks>
    public class DataStoreChange : ObjectTemplate<DataStoreChange>
    {
        public DataStoreChange() { /* used for serialisation */ }
        public DataStoreChange(DataStoreChangeAction action, string key, string? value = null)
        {
            this.action = action;
            this.key = key;
            this.value = value;
        }

        /// <summary>
        /// can be insert or delete
        /// </summary>
        [JsonConverter(typeof(StringToEnumConverter<DataStoreChangeAction>))]
        public DataStoreChangeAction action { get; set; }
        /// <summary>
        /// the key of the dictionary which should be changed. Must be encoded to hex
        /// </summary>
        public string key { get; set; }
        /// <summary>
        /// the value which should be applied (on insert). Muste be encoded into hex
        /// </summary>
        public string? value { get; set; }
        public enum DataStoreChangeAction
        {
            insert,
            delete
        }
    }
}
