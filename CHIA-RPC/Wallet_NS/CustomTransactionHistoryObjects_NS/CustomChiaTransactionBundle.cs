using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.CustomTransactionHistoryObjects_NS
{
    public class CustomChiaTransactionBundle : ObjectTemplate<CustomChiaTransactionBundle>
    {
        public DateTime Time { get; set; }
        public ulong BlockHeight { get; set; }
        public CustomChiaTransactionType Type { get; set; }
        /// <summary>
        /// incoming assets (xch/cat) 
        /// </summary>
        public List<Transaction_DictMemos> IncomingAssets { get; set; } = new List<Transaction_DictMemos>();
        /// <summary>
        /// outgoing assets (xch/cat/xch_fee)
        /// </summary>
        public List<Transaction_DictMemos> OutgoingAssets { get; set; } = new List<Transaction_DictMemos>();
        /// <summary>
        /// the related offer file (if applicable)
        /// </summary>
        public OfferFile? OfferFile { get; set; }
    }
}
