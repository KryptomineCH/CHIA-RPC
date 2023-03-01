using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General
{
    public class TransactionID_RPC : RPCTemplate<TransactionID_RPC>
    {
        /// <summary>
        /// The ID of the transaction to obtain. This is listed as name in the output of the transactions RPC
        /// </summary>
        public string transaction_id { get; set; }
    }
}
