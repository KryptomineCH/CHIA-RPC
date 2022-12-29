
namespace CHIA_RPC.Objects_NS
{
    public class Transaction
    {
        public Coin[] additions { get; set; }
        public ulong amount { get; set; }
        public bool confirmed { get; set; }
        public ulong confirmed_at_height { get; set; }
        public ulong created_at_time { get; set; }
        public ulong fee_amount { get; set; }
        /// <summary>
        /// note: could not be validated yet
        /// </summary>
        public Memos memos { get; set; }
        /// <summary>
        /// This is the transaction ID!!!
        /// </summary>
        public string name { get; set; }
        public Coin[] removals { get; set; }
        public ulong sent { get; set; }
        public string[] sent_to { get; set; }
        public SpendBundle spend_bundle { get; set; }
        public string to_address { get; set; }
        public string to_puzzle_hash { get; set; }
        public string trade_id { get; set; }
        public ulong type { get; set; }
        public ulong wallet_id { get; set; }
    }
}
