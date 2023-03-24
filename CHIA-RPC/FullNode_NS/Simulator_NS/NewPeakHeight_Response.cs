
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.Simulator_NS
{
    /// <summary>
    /// Response from the "revert_blocks" RPC method.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/simulator-rpc#revert_blocks"/><br/><br/>
    /// Uses:<br/>
    /// <see cref="RevertBlocks_RPC"/><br/>
    /// <see cref="ReorgBlocks_RPC"/>
    /// </remarks>
    public class NewPeakHeight_Response : ResponseTemplate<NewPeakHeight_Response>
    {
        /// <summary>
        /// The new peak height after reverting the specified number of blocks.
        /// </summary>
        public ulong? new_peak_height { get; init; }
    }
}
