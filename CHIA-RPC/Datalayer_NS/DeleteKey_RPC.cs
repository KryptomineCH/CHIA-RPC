using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Represents a request to delete a key/value pair from a store that you control.
    /// Triggers a Chia transaction.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc/#delete_key"/></remarks>
    /// <returns><see cref="General_NS.TxID_Response"/></returns>
    public class DeleteKey_RPC : RPCTemplate<DeleteKey_RPC>
    {
        public DeleteKey_RPC() { /* for serialisation */ }
        public DeleteKey_RPC(string datastoreID, string keyToDelete, ulong? feeInMojos = null)
        {
            id = datastoreID;
            key = keyToDelete;
            fee = feeInMojos;
        }
        /// <summary>
        /// The hexadecimal store ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The hexadecimal key.
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// Set the fee for the transaction, in mojos.
        /// </summary>
        [JsonConverter(typeof(StringToUlongNullableConverter))]
        public ulong? fee { get; set; }
    }
}
