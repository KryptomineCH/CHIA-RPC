using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Retrieves recent unfinished header blocks. 
    /// These blocks might get finished and confirmed soon. 
    /// The height and header hash is unknown, because some of these blocks might not get confirmed, which will affect the blocks after it.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_unfinished_block_headers"/><br/><br/>
    /// Uses:<br/>the request does not have any parameters
    /// </remarks>
    public class GetUnfinishedBlockHeaders_Response : ResponseTemplate<GetUnfinishedBlockHeaders_Response>
    {
        /// <summary>
        /// List of header blocks that have not been finished and confirmed yet.
        /// </summary>
        /// <remarks>
        /// Some of these blocks might not get confirmed, which will affect the blocks after it.
        /// The height and header hash of these blocks is unknown.
        /// </remarks>
        public BlockHeader[] headers { get; set; }
    }
}
