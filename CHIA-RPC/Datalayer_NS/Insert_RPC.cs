﻿using CHIA_RPC.HelperFunctions_NS;
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
        /// The hexadecimal store ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The hexadecimal key.
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// The hexadecimal value.
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// Set the fee for the transaction, in mojos.
        /// </summary>
        [JsonConverter(typeof(StringToUlongNullableConverter))]
        public ulong? fee { get; set; }
    }
}
