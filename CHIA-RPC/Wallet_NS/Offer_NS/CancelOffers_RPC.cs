using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Offer_NS
{
    /// <summary>
    /// Class for JSON rpc request to cancel multiple Offers.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/offer-rpc#cancel_offers"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class CancelOffers_RPC : RPCTemplate<CancelOffers_RPC>
    {
        /// <summary>
        /// If true, then "cancel on blockchain," ie spend the coins being offered. If false, then cancel locally.
        /// </summary>
        public bool secure { get; set; }

        /// <summary>
        /// An optional fee (in mojos) to include with the cancellation [Default: 0]
        /// </summary>
        public ulong? fee { get; set; }

        /// <summary>
        /// The number of offers to cancel in one batch [Default: 5]
        /// </summary>
        public ulong? batch_size { get; set; }

        /// <summary>
        /// Cancel all offers [Default: false]
        /// </summary>
        public bool? cancel_all { get; set; }
    }

}
