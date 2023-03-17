﻿
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// object to change a value in the data store dictionary. keys and value strings must be converted encoded as hex
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#batch_update"/></remarks>
    public class DataStoreChange : ObjectTemplate<DataStoreChange>
    {
        /// <summary>
        /// can be insert or delete
        /// </summary>
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
