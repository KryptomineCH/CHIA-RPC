namespace CHIA_RPC.Objects
{
    public class Coin
    {
        /// <summary>
        /// the coins value in mojos
        /// </summary>
        public ulong amount { get; set; }
        public string parent_coin_info { get; set; }
        public string puzzle_hash { get; set; }
    }
}
