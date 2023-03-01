using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class GetTransactionCount_Response : ResponseTemplate<GetTransactionCount_Response>
    {
        public ulong count { get; set; }
        public ulong wallet_id { get; set; }
    }
}
