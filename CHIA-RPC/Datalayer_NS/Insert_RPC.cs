﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Class representing the insert function of the data_layer RPC.
    /// triggers a chia transaction
    /// </summary>
    /// <remarks>Request returns a TxID_Response</remarks>
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
        public ulong? fee { get; set; }
    }
}