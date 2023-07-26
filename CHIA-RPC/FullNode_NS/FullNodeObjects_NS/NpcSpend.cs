using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents a Non-Player Character (NPC) spend operation in the Chia blockchain network.
    /// </summary>
    /// <remarks>
    /// NPC spend operations are an integral part of the Chia blockchain protocol, encapsulating the logic
    /// of spend conditions, and their evaluation.
    /// This class is a template for serializing and deserializing NPC spend JSON data.
    /// </remarks>
    public class NpcSpend : ObjectTemplate<NpcSpend>
    {
        /// <summary>
        /// The aggregated signature associated with the spend operation.
        /// </summary>
        /// <remarks>
        /// The aggregated signature provides proof of authority for the spend operation. It is an array of byte arrays.
        /// </remarks>
        public string[][]? agg_sig_me { get; set; }

        /// <summary>
        /// The height, relative to the block, before which the operation should occur.
        /// </summary>
        /// <remarks>
        /// This property provides a temporal boundary for the operation in terms of the blockchain height.
        /// </remarks>
        public ulong? before_height_relative { get; set; }

        /// <summary>
        /// The time, in seconds, relative to the block, before which the operation should occur.
        /// </summary>
        /// <remarks>
        /// This property provides a temporal boundary for the operation in terms of seconds from the block.
        /// </remarks>
        public ulong? before_seconds_relative { get; set; }

        /// <summary>
        /// The unique identifier of the coin being spent.
        /// </summary>
        /// <remarks>
        /// Each coin in the Chia network has a unique identifier. This property represents the coin involved in the operation.
        /// </remarks>
        public string? coin_id { get; set; }

        /// <summary>
        /// The array of coins created as a result of the operation. 
        /// </summary>
        /// <remarks>
        /// This property represents all coins created during the spend operation. It's an array of <see cref="Coin"/> objects.
        /// </remarks>
        [JsonConverter(typeof(MempoolCoinArrayJsonConverter))]
        public Coin[]? create_coin { get; set; }

        /// <summary>
        /// The flags associated with the spend operation.
        /// </summary>
        /// <remarks>
        /// Flags provide additional information about the operation such as specific conditions or states.
        /// </remarks>
        public ulong? flags { get; set; }

        /// <summary>
        /// The height, relative to the block, at which the operation occurs.
        /// </summary>
        /// <remarks>
        /// This property represents the blockchain height at the time of the operation.
        /// </remarks>
        public ulong? height_relative { get; set; }

        /// <summary>
        /// The puzzle hash associated with the operation.
        /// </summary>
        /// <remarks>
        /// Puzzle hashes are part of the Chia protocol and are associated with spend operations. They encapsulate the logic for coin creation and spending.
        /// </remarks>
        public string? puzzle_hash { get; set; }

        /// <summary>
        /// The time, in seconds, relative to the block, at which the operation occurs.
        /// </summary>
        /// <remarks>
        /// This property represents the relative time from the block at the moment of the operation.
        /// </remarks>
        public ulong? seconds_relative { get; set; }
    }

}
