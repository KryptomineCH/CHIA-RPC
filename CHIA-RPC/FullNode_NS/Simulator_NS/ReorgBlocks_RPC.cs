using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.Simulator_NS
{
    /// <summary>
    /// RPC request for initiating a reorg or a customizable number of blocks.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/simulator-rpc#reorg_blocks"/></remarks>
    /// <returns><see cref="NewPeakHeight_Response"/></returns>
    public class ReorgBlocks_RPC : RPCTemplate<ReorgBlocks_RPC>
    {
        /// <summary>
        /// The number of blocks to go back. Default is 1.
        /// </summary>
        public ulong? num_of_blocks_to_rev { get; set; }

        /// <summary>
        /// The number of blocks to add. Default is 1.
        /// </summary>
        public ulong? num_of_new_blocks { get; set; }

        /// <summary>
        /// Boolean, set to true to fork all blocks. Default is false.
        /// </summary>
        public bool? revert_all_blocks { get; set; }

        /// <summary>
        /// String used to randomize the seed, which will differentiate reorgs.
        /// </summary>
        public string random_seed { get; set; }
    }
}
