using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Class to represent the Foliage Transaction Block.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_block"/></remarks>
    public class FoliageTransactionBlock : ObjectTemplate<FoliageTransactionBlock>
    {
        /// <summary>
        /// Gets or sets the additions root.
        /// </summary>
        public string additions_root { get; set; }

        /// <summary>
        /// Gets or sets the filter hash.
        /// </summary>
        public string filter_hash { get; set; }

        /// <summary>
        /// Gets or sets the previous transaction block hash.
        /// </summary>
        public string prev_transaction_block_hash { get; set; }

        /// <summary>
        /// Gets or sets the removals root.
        /// </summary>
        public string removals_root { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        public ulong timestamp { get; set; }

        /// <summary>
        /// Gets or sets the transactions info hash.
        /// </summary>
        public string transactions_info_hash { get; set; }
    }
}
