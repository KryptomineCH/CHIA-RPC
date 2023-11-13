using CHIA_RPC.HelperFunctions_NS;


namespace CHIA_RPC.Wallet_NS.CustomTransactionHistoryObjects_NS
{
    public class CustomTransactionHistorySaveState : ObjectTemplate<CustomTransactionHistorySaveState>
    {
        public ImportHeight ImportedOfferHeight { get; set; } = new ImportHeight();
        public Dictionary<string, ImportHeight> ImportedAssedIDHeights { get; set; } = new Dictionary<string, ImportHeight> { };

    }
    public class ImportHeight : ObjectTemplate<ImportHeight>
    {
        public ulong SequenceHeight { get; set; } = 0;
        public ulong BlockHeight { get; set; } = 0;
    }
}
