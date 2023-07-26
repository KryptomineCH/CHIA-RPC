using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Class representing the insert function of the data_layer RPC.
    /// triggers a chia transaction
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#insert"/></remarks>
    /// <returns><see cref="General_NS.TxID_Response"/></returns>
    public class Insert_RPC : RPCTemplate<Insert_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public Insert_RPC() { /* for serialisation */ }
        /// <summary>
        /// Insert a key/value pair into a store that you control. Triggers a Chia transaction
        /// </summary>
        /// <param name="storeID">The hexadecimal store ID</param>
        /// <param name="keyToInsert">The hexadecimal key</param>
        /// <param name="valueToInsert">The hexadecimal value</param>
        /// <param name="feeInMojos">Set the fee for the transaction, in mojos</param>
        public Insert_RPC(string storeID, string keyToInsert, string valueToInsert, ulong? feeInMojos = null)
        {
            id = storeID;
            key = keyToInsert;
            value = valueToInsert;
            fee = feeInMojos;
        }
        /// <summary>
        /// The hexadecimal store ID.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? id { get; set; }

        /// <summary>
        /// The hexadecimal key.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? key { get; set; }

        /// <summary>
        /// The hexadecimal value.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? value { get; set; }

        /// <summary>
        /// Set the fee for the transaction, in mojos.
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(StringToUlongNullableConverter))]
        public ulong? fee { get; set; }
    }
}
