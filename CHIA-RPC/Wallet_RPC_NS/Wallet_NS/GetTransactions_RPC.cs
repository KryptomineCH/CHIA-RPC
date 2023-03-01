using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class GetTransaction_Response : ResponseTemplate<GetTransaction_Response>
    {
        public Transaction transaction { get; set; }
        public string transaction_id { get; set; }
    }
    public class GetTransactions_Response : ResponseTemplate<GetTransactions_Response>
    {
        public Transaction[] transactions { get; set; }
        public ulong wallet_id { get; set; }
    }
}
