using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Cancel all offers, with the option to cancel only offers for a specific asset class
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#cancel_offers"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class CancelCatOffers_RPC : RPCTemplate<CancelCatOffers_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CancelCatOffers_RPC() { /* for serialisation */ }
        /// <summary>
        /// Cancel all offers, with the option to cancel only offers for a specific asset class
        /// </summary>
        /// </summary>
        /// <param name="secure">Set to true to cancel on the blockchain by spending the coin(s) being offered; set to false to cancel in the wallet only. </param>
        /// <param name="batch_fee">The fee, in mojos, to add to each batch cancellation. [Default: 0]</param>
        /// <param name="batch_size">The number of offers to cancel in each batch. [Default: 5]</param>
        /// <param name="cancel_all">Set to true to cancel all offers for all assets. [Default: false]</param>
        /// <param name="asset_id">If cancel_all is false, then only cancel the specified type of asset. [Default: xch]</param>
        public CancelCatOffers_RPC(bool secure = true, ulong? batch_fee = null, ulong? batch_size = null, bool? cancel_all = null, string? asset_id = null)
        {
            this.secure = secure;
            this.batch_fee = batch_fee;
            this.batch_size = batch_size;
            this.cancel_all = cancel_all;
            this.asset_id = asset_id;
        }

        /// <summary>
        /// Set to true to cancel on the blockchain by spending the coin(s) being offered; set to false to cancel in the wallet only. 
        /// If false, the offer could still be taken if it has been shared.
        /// </summary>
        public bool secure { get; set; } = true;

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
