using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Represents a request to delete a key/value pair from a store that you control.
    /// Triggers a Chia transaction.
    /// </summary>
    /// <remarks>returns a TxID_Response</remarks>
    public class DeleteKey_RPC : RPCTemplate<DeleteKey_RPC>
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
        /// Set the fee for the transaction, in mojos.
        /// </summary>
        public ulong? fee { get; set; }
    }
}
