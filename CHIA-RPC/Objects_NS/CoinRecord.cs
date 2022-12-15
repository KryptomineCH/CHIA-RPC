namespace CHIA_RPC.Objects_NS
{
    public class CoinRecord
    {
        public Coin coin { get; set; }
        public bool coinbase { get; set; }
        public ulong confirmed_block_index { get; set; }
        public ulong spent_block_index { get; set; }
        public ulong timestamp { get; set; }
    }
}
