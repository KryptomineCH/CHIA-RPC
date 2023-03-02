using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    public class TradeRecord : ObjectTemplate<TradeRecord>
    {
		public bool? accepted_at_time { get; set; } 
		public Coin[] coins_of_interest { get; set; }
		public ulong confirmed_at_index { get; set; } 
		public ulong created_at_time { get; set; }
		public bool is_my_offer { get; set; } 
		public KeyValuePair<string, long> pending { get; set; }
        public ulong sent { get; set; }
		public dynamic? sent_to { get; set; }
		public string status { get; set; }
		public dynamic summary { get; set; }

		public dynamic? taken_offer { get; set; }
		public string trade_id { get; set; }
	}
}
