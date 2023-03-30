using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    using System.Collections.Generic;

    public class TradeRecord : ObjectTemplate<TradeRecord>
    {
        /// <summary>
        /// The time when the trade was accepted (null if not accepted yet)
        /// </summary>
        public ulong? accepted_at_time { get; set; }

        /// <summary>
        /// An array of coins involved in the trade
        /// </summary>
        public Coin[] coins_of_interest { get; set; }

        /// <summary>
        /// The index at which the trade was confirmed
        /// </summary>
        public ulong confirmed_at_index { get; set; }

        /// <summary>
        /// The time when the trade was created
        /// </summary>
        public ulong created_at_time { get; set; }

        /// <summary>
        /// Indicates whether the trade is the user's offer
        /// </summary>
        public bool is_my_offer { get; set; }

        /// <summary>
        /// A dictionary of pending offers
        /// </summary>
        public Dictionary<string, long> pending { get; set; }

        /// <summary>
        /// The amount sent in the trade
        /// </summary>
        public ulong sent { get; set; }

        /// <summary>
        /// The list of addresses the trade was sent to
        /// </summary>
        public string[] sent_to { get; set; }

        /// <summary>
        /// The current status of the trade
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// A summary of the trade
        /// </summary>
        public dynamic summary { get; set; }

        /// <summary>
        /// The taken offer for the trade (null if not taken)
        /// </summary>
        public dynamic? taken_offer { get; set; }

        /// <summary>
        /// The unique identifier of the trade
        /// </summary>
        public string trade_id { get; set; }
    }

}
