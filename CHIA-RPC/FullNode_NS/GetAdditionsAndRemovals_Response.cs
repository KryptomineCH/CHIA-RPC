using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Represents the response of the get_additions_and_removals API call, which retrieves the additions and removals (state transitions) for a certain block.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_additions_and_removals"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.HeaderHash_RPC"/>
    /// </remarks>
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
