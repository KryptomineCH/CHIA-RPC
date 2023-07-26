
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
        /// <summary>
        /// empty constructor required for the serializer
        /// </summary>
        public DataStoreChange() { /* used for serialisation */ }
        /// <summary>
        /// defines a datastore change
        /// </summary>
        /// <param name="action">the action to take, currently insert or delete</param>
        /// <param name="key">the unique identifier of the record. If it exists, need to delete first for update</param>
        /// <param name="value">the value which should be inserted (if action = insert)</param>
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
        public DataStoreChangeAction? action { get; set; }
        /// <summary>
        /// the key of the dictionary which should be changed. Must be encoded to hex
        /// </summary>
        public string? key { get; set; }
        /// <summary>
        /// the value which should be applied (on insert). Muste be encoded into hex
        /// </summary>
        public string? value { get; set; }
        /// <summary>
        /// enum defining the possible interactions with a datastore
        /// </summary>
        public enum DataStoreChangeAction
        {
            /// <summary>
            /// insert a record
            /// </summary>
            insert,
            /// <summary>
            /// delete a record
            /// </summary>
            delete
        }
    }
}
