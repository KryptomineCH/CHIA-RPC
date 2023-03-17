using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Class to represent the foliage object in the JSON
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_block"/></remarks>
    public class Foliage : ObjectTemplate<Foliage>
    {
        /// <summary>
        /// Foliage block data object
        /// </summary>
        public FoliageBlockData foliage_block_data { get; set; }

        /// <summary>
        /// Foliage block data signature string
        /// </summary>
        public string foliage_block_data_signature { get; set; }

        /// <summary>
        /// Foliage transaction block hash string
        /// </summary>
        public string foliage_transaction_block_hash { get; set; }

        /// <summary>
        /// Foliage transaction block signature string
        /// </summary>
        public string foliage_transaction_block_signature { get; set; }

        /// <summary>
        /// Previous block hash string
        /// </summary>
        public string prev_block_hash { get; set; }

        /// <summary>
        /// Reward block hash string
        /// </summary>
        public string reward_block_hash { get; set; }
    }
}
