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
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public DeleteKey_RPC() { /* for serialisation */ }
        /// <summary>
        /// Delete a key/value pair from a store that you control. Triggers a Chia transaction
        /// </summary>
        /// <param name="datastoreID">The hexadecimal store ID</param>
        /// <param name="keyToDelete">The hexadecimal key</param>
        /// <param name="feeInMojos">Set the fee for the transaction, in mojos</param>
        public DeleteKey_RPC(string datastoreID, string keyToDelete, ulong? feeInMojos = null)
        {
            id = datastoreID;
            key = keyToDelete;
            fee = feeInMojos;
        }
        /// <summary>
        /// The hexadecimal store ID.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string id { get; set; }

        /// <summary>
        /// The hexadecimal key.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string key { get; set; }

        /// <summary>
        /// Set the fee for the transaction, in mojos.
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(StringToUlongNullableConverter))]
        public ulong? fee { get; set; }
    }
}
