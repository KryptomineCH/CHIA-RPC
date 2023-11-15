using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.CustomTransactionHistoryObjects_NS
{
    public class CustomChiaTransactionBundle : ObjectTemplate<CustomChiaTransactionBundle>
    {
        public DateTime Time { get; set; }
        public ulong BlockHeight { get; set; }
        public TransactionType Type { get; set; }
        public Transaction_DictMemos[] IncomingAssets { get; set; }
        public Transaction_DictMemos[] OutgoingAssets { get; set; }
        /// <summary>
        /// note: fees are always denominated in xch and substracted from wallet 1
        /// </summary>
        public Transaction_DictMemos[] Fees { get; set; }
    }
}
