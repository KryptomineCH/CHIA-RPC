using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    /// <summary>
    /// Obtain the number of transactions for a wallet
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_transaction_count"/><br/><br/>
    /// Uses:<br/>
    /// </remarks>
    public class GetTransactionCount_Response : ResponseTemplate<GetTransactionCount_Response>
    {
        public ulong count { get; set; }
        public ulong wallet_id { get; set; }
    }
}
