using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
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
        /// <summary>
        /// the count of transactions made
        /// </summary>
        public ulong? count { get; set; }
        /// <summary>
        /// the wallet for which the transactions count should be fetched
        /// </summary>
        public ulong? wallet_id { get; set; }
    }
}
