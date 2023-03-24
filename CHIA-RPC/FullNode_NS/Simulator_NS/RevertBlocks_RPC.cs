using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.Simulator_NS
{

    /// <summary>
    /// Request class for the "revert_blocks" RPC command in the Chia full node.
    /// Revert a customizable number of blocks.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/simulator-rpc#revert_blocks"/></remarks>
    /// <returns><see cref="NewPeakHeight_Response"/></returns>
    public class RevertBlocks_RPC : RPCTemplate<RevertBlocks_RPC>
    {
        /// <summary>
        /// The number of blocks to revert (Default: 1).
        /// </summary>
        public ulong? num_of_blocks { get; set; }

        /// <summary>
        /// Boolean, set to True to revert all blocks (Default: False).
        /// </summary>
        public bool? delete_all_blocks { get; set; }
    }

}
