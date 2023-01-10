namespace CHIA_RPC.Objects_NS
{
    public class TradeData
    {
        /// <summary>
        /// Address of the trading party
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// The amount of fungible asset to be traded
        /// </summary>
        public ulong amount { get; set; }

        /// <summary>
        /// The fungible asset to be traded
        /// </summary>
        public string asset { get; set; }
    }
}
