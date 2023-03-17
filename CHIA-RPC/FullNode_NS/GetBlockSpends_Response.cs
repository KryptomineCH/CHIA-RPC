using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Retrieves every coin that was spent in a block. 
    /// </summary>
    /// <remarks>
    /// Keep in mind that most blocks do not cointain any transactions. These blocks will simply return "[]" for this request.
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
