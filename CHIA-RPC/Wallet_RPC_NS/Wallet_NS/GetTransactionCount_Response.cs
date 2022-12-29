namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class GetTransactionCount_Response
    {
        public ulong count { get; set; }
        public ulong wallet_id { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
