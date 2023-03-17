using CHIA_RPC.HelperFunctions_NS;
using System.Numerics;
using System.Text.Json.Serialization;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Class representing the blockchain state
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/></remarks>
    public class BlockchainState : ObjectTemplate<BlockchainState>
    {
        /// <summary>
        /// The difficulty of the blockchain
        /// </summary>
        public ulong difficulty { get; set; }

        /// <summary>
        /// Indicates if the genesis challenge has been initialized
        /// </summary>
        public bool genesis_challenge_initialized { get; set; }

        /// <summary>
        /// The size of the mempool
        /// </summary>
        public ulong mempool_size { get; set; }

        /// <summary>
        /// Information about the peak of the blockchain
        /// </summary>
        public Peak peak { get; set; }

        /// <summary>
        /// The space of the blockchain
        /// </summary>
        [JsonConverter(typeof(BigIntegerConverter))]
        public BigInteger space { get; set; }

        /// <summary>
        /// The number of sub-slot iterations of the blockchain
        /// </summary>
        public ulong sub_slot_iters { get; set; }

        /// <summary>
        /// Information about the sync status of the blockchain
        /// </summary>
        public Sync sync { get; set; }
    }
}
