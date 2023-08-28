
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Class for serializing and deserializing a cancel_offer JSON RPC request.<br/>
    /// Cancel an Offer with a specific identifier
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#cancel_offer"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class CancelOffer_RPC : RPCTemplate<CancelOffer_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CancelOffer_RPC() { /* for serialisation */ }
        /// <summary>
        /// Cancel an Offer with a specific identifier
        /// </summary>
        /// <param name="trade_id">The `trade_id` of the Offer to cancel. Can be retrieved from an Offer file by calling `cdv inspect spendbundles [offer_file]`</param>
        /// <param name="secure">Set to true to cancel on the blockchain. set to false to cancel in the wallet only.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public CancelOffer_RPC(TradeID_Response trade_id, bool secure = true, ulong? fee = null)
        {
            this.secure = secure;
            this.trade_id = trade_id.trade_id;
            this.fee = fee;
        }
        /// <summary>
        /// Cancel an Offer with a specific identifier
        /// </summary>
        /// <param name="trade_id">The `trade_id` of the Offer to cancel. Can be retrieved from an Offer file by calling `cdv inspect spendbundles [offer_file]`</param>
        /// <param name="secure">Set to true to cancel on the blockchain. set to false to cancel in the wallet only.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public CancelOffer_RPC(TxID_Response trade_id, bool secure = true, ulong? fee = null)
        {
            this.secure = secure;
            this.trade_id = trade_id.tx_id;
            this.fee = fee;
        }
        /// <summary>
        /// cancel an offer
        /// </summary>
        /// <param name="offerInfo">The ID of the offer to cancel.</param>
        /// <param name="secure">Set to true to cancel on the blockchain. set to false to cancel in the wallet only.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public CancelOffer_RPC(OfferInfo offerInfo, bool secure = true, ulong? fee = null)
        {
            this.secure = secure;
            this.trade_id = offerInfo.launcher_id;
            this.fee = fee;
        }
        /// <summary>
        /// cancel an offer
        /// </summary>
        /// <param name="offerInfo">The Offer info which the tradeID can be loaded from</param>
        /// <param name="secure">Set to true to cancel on the blockchain. set to false to cancel in the wallet only.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public CancelOffer_RPC(OfferFile offerInfo, bool secure = true, ulong? fee = null)
        {
            this.secure = secure;
            if (offerInfo.trade_record == null) { this.trade_id = null; }
            else { this.trade_id = offerInfo.trade_record.trade_id; }
            this.fee = fee;
        }

        /// <summary>
        /// cancel an offer
        /// </summary>
        /// <param name="trade_id">The `trade_id` of the Offer to cancel. Can be retrieved from an Offer file by calling `cdv inspect spendbundles [offer_file]`</param>
        /// <param name="secure">Set to true to cancel on the blockchain. set to false to cancel in the wallet only.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public CancelOffer_RPC(string trade_id, bool secure = true, ulong? fee = null)
        {
            this.secure = secure;
            this.trade_id = trade_id;
            this.fee = fee;
        }

        /// <summary>
        /// Set to true to cancel on the blockchain by spending the coin(s) being offered;<br/> 
        /// set to false to cancel in the wallet only.<br/>
        /// If false, the offer could still be taken if it has been shared.
        /// </summary>
        public bool? secure { get; set; } = true;

        /// <summary>
        /// The `trade_id` of the Offer to cancel. Can be retrieved from an Offer file by calling `cdv inspect spendbundles [offer_file]`
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? trade_id { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }

}
