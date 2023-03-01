using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Retrieves recent unfinished header blocks. 
    /// These blocks might get finished and confirmed soon. 
    /// The height and header hash is unknown, because some of these blocks might not get confirmed, which will affect the blocks after it.
    /// </summary>
    public class GetUnfinishedBlockHeaders_Response : ResponseTemplate<GetUnfinishedBlockHeaders_Response>
    {
        /// <summary>
        /// List of header blocks that have not been finished and confirmed yet.
        /// </summary>
        /// <remarks>
        /// Some of these blocks might not get confirmed, which will affect the blocks after it.
        /// The height and header hash of these blocks is unknown.
        /// </remarks>
        BlockHeader[] headers { get; set; }
    }
}
