using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CustomTransactionHistoryObjects_NS
{
    public class CustomChiaTransactionBundle : ObjectTemplate<CustomChiaTransactionBundle>
    {
        public DateTime Time { get; set; }
        public ulong BlockHeight { get; set; }
        public CustomChiaTransactionType Type { get; set; }
        public CustomChiaTransaction[] IncomingAssets { get; set; }
        public CustomChiaTransaction[] OutgoingAssets { get; set; }
        /// <summary>
        /// note: fees are always denominated in xch and substracted from wallet 1
        /// </summary>
        public CustomChiaTransaction[] Fees { get; set; }
    }
}
