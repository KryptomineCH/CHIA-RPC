using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Class to represent the pool target.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_block"/></remarks>
    public class PoolTarget : ObjectTemplate<PoolTarget>
    {
        /// <summary>
        /// Gets or sets the maximum height.
        /// </summary>
        public ulong? max_height { get; set; }

        /// <summary>
        /// Gets or sets the puzzle hash.
        /// </summary>
        public string? puzzle_hash { get; set; }
    }
}
