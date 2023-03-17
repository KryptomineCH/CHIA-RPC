using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;
using static System.Net.WebRequestMethods;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// various metrics for the blockchain's blocks. Currently shows:<br/>
    /// compact blocks<br/>
    /// hint count<br/>
    /// uncompact blocks<br/>
    /// </summary>
    /// <remarks>
    /// request has no parameters<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block_count_metrics"/>
    /// </remarks>
    public class GetBlockCountMetrics_Response : ResponseTemplate<GetBlockCountMetrics_Response>
    {
        /// <summary>
        /// An object that contains the metric values
        /// </summary>
        public BlockCountMetrics metrics { get; set; }
    }
}
