using CHIA_RPC.HelperFunctions_NS;
using static System.Net.WebRequestMethods;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Represents a response object containing a list of all transaction IDs in the mempool.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_all_mempool_tx_ids"/><br/><br/>
    /// Uses:<br/>the request does not have parameters
    /// </remarks>
    public class GetAllMempoolTxIDs_Response : ResponseTemplate<GetAllMempoolTxIDs_Response>
    {
        /// <summary>
        /// array of all transaction IDs in the mempool.
        /// </summary>
        public string[]? tx_ids { get; set; }
    }
}
