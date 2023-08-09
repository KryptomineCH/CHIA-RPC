using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Represents a record of a coin within the Chia network.
    /// </summary>
    /// <remarks>
    /// This class is used by both the Full Node and the Wallet Node in the Chia network to keep track of the status and history of coins.
    /// It provides key information about a coin, including if it has been spent, when it was confirmed, and when it was spent.
    /// This object is utilized in the following API calls:<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_coin_record_by_name"/> for getting a coin record by its name.<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_names"/> for getting multiple coin records by their names.<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_parent_ids"/> for getting coin records by their parent IDs.<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_coin_records_by_hint"/> for getting coin records by a hint.
    /// </remarks>
    public class CoinRecord : ObjectTemplate<CoinRecord>
    {
        /// <summary>
        /// The Coin object associated with this record.
        /// </summary>
        public Coin? coin { get; set; }

        /// <summary>
        /// Indicates if the coin is a coinbase coin.
        /// </summary>
        /// <remarks>
        /// Coinbase coins are special types of coins that are awarded to miners for creating new blocks.
        /// </remarks>
        public bool? coinbase { get; set; }

        /// <summary>
        /// The index of the block in which the coin was confirmed.
        /// </summary>
        public ulong? confirmed_block_index { get; set; }

        /// <summary>
        /// Indicates whether the coin has been spent.
        /// </summary>
        public bool? spent { get; set; }

        /// <summary>
        /// The index of the block in which the coin was spent.
        /// </summary>
        public ulong? spent_block_index { get; set; }

        /// <summary>
        /// The timestamp when the coin was created or updated in unix time.
        /// </summary>
        public ulong? timestamp { get; set; }
        /// <summary>
        /// The timestamp as DateTime.
        /// </summary>
        [JsonIgnore]
        public DateTime? timestamp_dateTime
        {
            get
            {
                if (timestamp.HasValue)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)timestamp.Value);
                    return dateTimeOffset.DateTime;
                }
                return null;
            }
        }
    }

}
