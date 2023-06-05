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
        /// parameterless constructor, for serializer
        /// </summary>
        public ReorgBlocks_RPC() { /* for serialisation */ }
        /// <summary>
        /// RPC request for initiating a reorg or a customizable number of blocks.
        /// </summary>
        /// <param name="num_of_blocks_to_rev">The number of blocks to go back. Default is 1.</param>
        /// <param name="num_of_new_blocks">The number of blocks to add. Default is 1.</param>
        /// <param name="revert_all_blocks">Boolean, set to true to fork all blocks. Default is false.</param>
        /// <param name="random_seed">String used to randomize the seed, which will differentiate reorgs.</param>
        public ReorgBlocks_RPC(ulong? num_of_blocks_to_rev = null, ulong? num_of_new_blocks = null, bool? revert_all_blocks = null, string random_seed = null)
        {
            this.num_of_blocks_to_rev = num_of_blocks_to_rev;
            this.num_of_new_blocks = num_of_new_blocks;
            this.revert_all_blocks = revert_all_blocks;
            this.random_seed = random_seed;
        }

        /// <summary>
        /// The number of blocks to go back. Default is 1.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? num_of_blocks_to_rev { get; set; }

        /// <summary>
        /// The number of blocks to add. Default is 1.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? num_of_new_blocks { get; set; }

        /// <summary>
        /// Boolean, set to true to fork all blocks. Default is false.
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? revert_all_blocks { get; set; }

        /// <summary>
        /// String used to randomize the seed, which will differentiate reorgs.
        /// </summary>
        /// <remarks>optional</remarks>
        public string random_seed { get; set; }
    }
}
