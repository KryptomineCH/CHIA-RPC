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
        /// parameterless constructor, for serializer
        /// </summary>
        public RevertBlocks_RPC() { /* for serialisation */ }
        /// <summary>
        /// Request class for the "revert_blocks" RPC command in the Chia full node.
        /// </summary>
        /// <param name="num_of_blocks">The number of blocks to revert (Default: 1).</param>
        /// <param name="delete_all_blocks">Boolean, set to True to revert all blocks (Default: False).</param>
        public RevertBlocks_RPC(ulong? num_of_blocks = null, bool? delete_all_blocks = null)
        {
            this.num_of_blocks = num_of_blocks;
            this.delete_all_blocks = delete_all_blocks;
        }

        /// <summary>
        /// The number of blocks to revert (Default: 1).
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? num_of_blocks { get; set; }

        /// <summary>
        /// Boolean, set to True to revert all blocks (Default: False).
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? delete_all_blocks { get; set; }
    }

}
