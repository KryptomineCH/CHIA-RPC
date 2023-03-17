using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Represents a response object containing a list of all transaction IDs in the mempool.
    /// </summary>
    public class GetAllMempoolTxIDs_Response : ResponseTemplate<GetAllMempoolTxIDs_Response>
    {
        /// <summary>
        /// array of all transaction IDs in the mempool.
        /// </summary>
        public string[] tx_ids { get; set; }
    }
}
