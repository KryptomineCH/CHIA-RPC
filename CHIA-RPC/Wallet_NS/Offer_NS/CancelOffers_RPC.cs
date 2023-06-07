using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Offer_NS
{
    /// <summary>
    /// Cancel all offers, with the option to cancel only offers for a specific asset class
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/offer-rpc#cancel_offers"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class CancelOffers_RPC : RPCTemplate<CancelOffers_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CancelOffers_RPC() { /* for serialisation */ }
        /// <summary>
        /// Cancel all offers, with the option to cancel only offers for a specific asset class
        /// </summary>
        /// <param name="secure">Set to true to cancel on the blockchain by spending the coin(s) being offered; set to false to cancel in the wallet only. If false, the offer could still be taken if it has been shared</param>
        /// <param name="batch_fee">The fee, in mojos, to add to each batch cancellation [Default: 0]</param>
        /// <param name="batch_size">The number of offers to cancel in each batch [Default: 5]</param>
        /// <param name="cancel_all">Set to true to cancel all offers for all assets [Default: false]</param>
        /// <param name="asset_id">If cancel_all is false, then only cancel the specified type of asset [Default: xch]</param>
        public CancelOffers_RPC(bool secure, ulong? batch_fee, ulong? batch_size, bool? cancel_all, string? asset_id)
        {
            this.secure = secure;
            this.batch_fee = batch_fee;
            this.batch_size = batch_size;
            this.cancel_all = cancel_all;
            this.asset_id = asset_id;
        }

        /// <summary>
        /// If true, then "cancel on blockchain," ie spend the coins being offered. If false, then cancel locally.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public bool secure { get; set; }
        /// <summary>
        /// The fee, in mojos, to add to each batch cancellation [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? batch_fee { get; set; }

        /// <summary>
        /// The number of offers to cancel in one batch [Default: 5]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? batch_size { get; set; }

        /// <summary>
        /// Cancel all offers [Default: false]
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? cancel_all { get; set; }
        /// <summary>
        /// If cancel_all is false, then only cancel the specified type of asset [Default: xch]
        /// </summary>
        /// <remarks>optional</remarks>
        public string? asset_id { get; set; }
    }

}
