using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// a trade record is beeing generated when acceping a chia offer fron an offer file
    /// </summary>
    /// <remarks>
    /// Technical Limitations:<br/>
    /// - accepted_at_time can only be filled if you accepted the offer<br/>
    /// - accepted_at_index cannot be filled at all currently<br/>
    /// can be used with:<br/>
    /// <see href="CHIA_RPC.Wallet_NS.CATsAndTrading_NS.GetOffer_RPC"/>
    /// 
    /// </remarks>
    public class TradeRecord : ObjectTemplate<TradeRecord>
    {
        /// <summary>
        /// The time when the trade was accepted (null if not accepted yet)
        /// </summary>
        /// <remarks>
        /// WARNING: As of right now, can only be filled when you filled the offer
        /// </remarks>
        public ulong? accepted_at_time { get; set; }

        /// <summary>
        /// The time when the trade was accepted (null if not accepted yet)
        /// </summary>
        /// <remarks>
        /// WARNING: As of right now, can only be filled when you filled the offer
        /// </remarks>
        [JsonIgnore]
        public DateTime? accepted_at_time_dateTime
        {
            get
            {
                if (accepted_at_time.HasValue)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)accepted_at_time.Value);
                    return dateTimeOffset.DateTime;
                }
                return null;
            }
        }

        /// <summary>
        /// An array of coins involved in the trade
        /// </summary>
        public Coin[]? coins_of_interest { get; set; }

        /// <summary>
        /// The index at which the trade was confirmed
        /// </summary>
        /// <remarks>
        /// WARNING: As of right now is ALWAYS 0
        /// </remarks>
        public ulong? confirmed_at_index { get; set; }

        /// <summary>
        /// The time when the trade was created
        /// </summary>
        public ulong? created_at_time { get; set; }
        /// <summary>
        /// The timestamp of creation as DateTime.
        /// </summary>
        [JsonIgnore]
        public DateTime? created_at_time_dateTime
        {
            get
            {
                if (created_at_time.HasValue)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)created_at_time.Value);
                    return dateTimeOffset.DateTime;
                }
                return null;
            }
        }

        /// <summary>
        /// Indicates whether the trade is the user's offer
        /// </summary>
        public bool? is_my_offer { get; set; }

        /// <summary>
        /// A dictionary of pending offers
        /// </summary>
        public Dictionary<string, long>? pending { get; set; }

        /// <summary>
        /// The amount sent in the trade
        /// </summary>
        public ulong? sent { get; set; }

        /// <summary>
        /// The list of addresses the trade was sent to
        /// </summary>
        public string[]? sent_to { get; set; }

        /// <summary>
        /// The current status of the trade
        /// </summary>
        [JsonConverter(typeof(NullableTradeStatusConverter))]
        public TradeStatus? status { get; set; }

        /// <summary>
        /// A summary of the trade
        /// </summary>
        public OfferSummary? summary { get; set; }

        /// <summary>
        /// The taken offer for the trade (null if not taken)
        /// </summary>
        public dynamic? taken_offer { get; set; }

        /// <summary>
        /// The unique identifier of the trade
        /// </summary>
        public string? trade_id { get; set; }

        /// <summary>
        /// contains information if this offer generates a separate fee transaction for you
        /// </summary>
        [JsonIgnore]
        public bool contains_additional_fee_transaction
        {
            get
            {
                if ((bool)is_my_offer)
                {
                    return false;
                }
                return summary.contains_separate_fee_trasaction;
            }
        }
    }

}
