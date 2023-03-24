
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Response object for the "get_offers_count" RPC method of the Chia wallet
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#get_offers_count"/><br/><br/>
    /// Uses:<br/>the request has no Parameters
    /// </remarks>
    public class GetOffersCount_Response : ResponseTemplate<GetOffersCount_Response>
    {
        /// <summary>
        /// The number of offers created by the current wallet
        /// </summary>
        public ulong my_offers_count { get; set; }

        /// <summary>
        /// The number of offers that have been taken by other wallets
        /// </summary>
        public ulong taken_offers_count { get; set; }

        /// <summary>
        /// The total number of offers (created and taken) for the current wallet
        /// </summary>
        public ulong total { get; set; }
    }

}
