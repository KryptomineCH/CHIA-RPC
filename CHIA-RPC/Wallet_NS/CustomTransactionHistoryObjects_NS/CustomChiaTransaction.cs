using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CustomTransactionHistoryObjects_NS
{
    public class CustomChiaTransaction : ObjectTemplate<CustomChiaTransaction>
    {
        public string Description { get; set; }
        public string AssetId { get; set; }
        public string[] TransactionIds { get; set; }
        public string AssetType { get; set; }
        public decimal Amount { get; set; }
        public ulong Mojos { get; set; }
        public ulong WalletTransactionHeight { get; set; }
    }
}
