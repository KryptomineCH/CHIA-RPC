using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet
{
    public class GetTransaction_Response
    {
        public Transaction transactions { get; set; }
        public string transaction_id { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class GetTransactions_Response
    {
        public Transaction[] transactions { get; set; }
        public ulong wallet_id { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
