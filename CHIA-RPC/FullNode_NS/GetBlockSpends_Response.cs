using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Retrieves every coin that was spent in a block. 
    /// </summary>
    /// <remarks>
    /// Keep in mind that most blocks do not cointain any transactions. These blocks will simply return "[]" for this request.<br/>
    /// the request is using a <see cref="General_NS.HeaderHash_RPC"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block_spends"/>
    /// </remarks>
    public class GetBlockSpends_Response : ResponseTemplate<GetBlockSpends_Response>
    {
        /// <summary>
        /// every coin that was spent in the block. 
        /// </summary>
        /// <remarks>
        /// Keep in mind that most blocks do not cointain any transactions. These blocks will simply return "[]" for this request.
        /// </remarks>
        public Spend[] block_spends { get; set; }
    }
}
