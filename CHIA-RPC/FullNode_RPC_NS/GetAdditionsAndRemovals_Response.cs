using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Represents the response of the get_additions_and_removals API call, which retrieves the additions and removals (state transitions) for a certain block.
    /// </summary>
    public class GetAdditionsAndRemovals_Response : ResponseTemplate<GetAdditionsAndRemovals_Response>
    {
        /// <summary>
        /// Gets or sets the list of coin transactions that represent the additions in the block.
        /// </summary>
        public CoinTransaction[] additions { get; set; }

        /// <summary>
        /// Gets or sets the list of coin transactions that represent the removals in the block.
        /// </summary>
        public CoinTransaction[] removals { get; set; }
    }
}
