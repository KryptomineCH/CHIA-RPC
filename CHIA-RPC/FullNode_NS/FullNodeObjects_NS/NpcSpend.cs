using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    public class NpcSpend : ObjectTemplate<NpcSpend>
    {
        /// <summary>
        /// Aggregated signature.
        /// </summary>
        public string[][] agg_sig_me { get; set; }

        /// <summary>
        /// Height relative to the block.
        /// </summary>
        public ulong? before_height_relative { get; set; }

        /// <summary>
        /// Seconds relative to the block.
        /// </summary>
        public ulong? before_seconds_relative { get; set; }

        /// <summary>
        /// Coin ID.
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// Array of created coins. Each entry is a tuple with a string, ulong, and nullable ulong.
        /// </summary>
        [JsonConverter(typeof(MempoolCoinArrayJsonConverter))]
        public Coin[] create_coin { get; set; }

        /// <summary>
        /// Flags for the spend.
        /// </summary>
        public ulong flags { get; set; }

        /// <summary>
        /// Height relative to the block.
        /// </summary>
        public ulong? height_relative { get; set; }

        /// <summary>
        /// Puzzle hash.
        /// </summary>
        public string puzzle_hash { get; set; }

        /// <summary>
        /// Seconds relative to the block.
        /// </summary>
        public ulong seconds_relative { get; set; }
    }
}
