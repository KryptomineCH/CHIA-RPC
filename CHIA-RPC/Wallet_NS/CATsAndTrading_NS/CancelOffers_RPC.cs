using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Represents a JSON rpc request to cancel all offers or offers for a specific asset class in the Chia wallet.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#cancel_offers"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class CancelOffers_RPC : RPCTemplate<CancelOffers_RPC>
    {
        /// <summary>
        /// Set to true to cancel on the blockchain by spending the coin(s) being offered; set to false to cancel in the wallet only. 
        /// If false, the offer could still be taken if it has been shared.
        /// </summary>
        public bool secure { get; set; }

        /// <summary>
        /// The fee, in mojos, to add to each batch cancellation. [Default: 0]
        /// </summary>
        public ulong? batch_fee { get; set; }

        /// <summary>
        /// The number of offers to cancel in each batch. [Default: 5]
        /// </summary>
        public ulong? batch_size { get; set; }

        /// <summary>
        /// Set to true to cancel all offers for all assets. [Default: false]
        /// </summary>
        public bool? cancel_all { get; set; }

        /// <summary>
        /// If cancel_all is false, then only cancel the specified type of asset. [Default: xch]
        /// </summary>
        public string? asset_id { get; set; }
    }

}
