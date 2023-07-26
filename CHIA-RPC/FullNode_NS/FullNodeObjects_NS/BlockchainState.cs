using CHIA_RPC.HelperFunctions_NS;
using System.Numerics;
using System.Text.Json.Serialization;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents the current state of the blockchain within the Chia network.
    /// </summary>
    /// <remarks>
    /// This class is used to capture various attributes about the blockchain's state at any given moment.
    /// It includes information such as the maximum cost of a block, difficulty, and the state of the mempool.
    /// For more details about this information, refer to Chia's full node RPC documentation:<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/>
    /// </remarks>
    public class BlockchainState : ObjectTemplate<BlockchainState>
    {
        /// <summary>
        /// The maximum cost that a block can have in the blockchain.
        /// </summary>
        public ulong? block_max_cost { get; set; }

        /// <summary>
        /// The current difficulty of the blockchain, affecting how hard it is to mine new blocks.
        /// </summary>
        public ulong? difficulty { get; set; }

        /// <summary>
        /// Indicates whether the genesis challenge, the original challenge that starts the blockchain, has been initialized.
        /// </summary>
        public bool? genesis_challenge_initialized { get; set; }

        /// <summary>
        /// The current total cost of all transactions waiting in the mempool to be included in future blocks.
        /// </summary>
        public ulong? mempool_cost { get; set; }

        /// <summary>
        /// The total amount of fees attached to all transactions currently in the mempool.
        /// </summary>
        public ulong? mempool_fees { get; set; }

        /// <summary>
        /// The maximum total cost that transactions can have to be included in the mempool.
        /// </summary>
        public ulong? mempool_max_total_cost { get; set; }

        /// <summary>
        /// The minimum fees required per unit of cost for transactions to be included in the mempool.
        /// </summary>
        public Dictionary<string, ulong>? mempool_min_fees { get; set; }

        /// <summary>
        /// The current size of the mempool, representing the number of transactions waiting to be included in future blocks.
        /// </summary>
        public ulong? mempool_size { get; set; }

        /// <summary>
        /// The unique identifier for the node that this blockchain state information is relevant to.
        /// </summary>
        public string? node_id { get; set; }

        /// <summary>
        /// Information about the current highest (most recent) block in the blockchain, also known as the "peak".
        /// </summary>
        public Peak? peak { get; set; }

        /// <summary>
        /// The total amount of space that the blockchain is currently taking up.
        /// </summary>
        [JsonConverter(typeof(BigIntegerConverter))]
        public BigInteger? space { get; set; }

        /// <summary>
        /// The current number of sub-slot iterations, which is a measure of time within the Chia network.
        /// </summary>
        public ulong? sub_slot_iters { get; set; }

        /// <summary>
        /// Information about the current synchronization status of the blockchain.
        /// </summary>
        public Sync? sync { get; set; }
    }

}
