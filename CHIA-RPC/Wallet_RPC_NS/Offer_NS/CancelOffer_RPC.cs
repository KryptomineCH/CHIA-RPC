using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Cancel an offer with a specific identifier.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/offer-rpc#cancel_offer"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class CancelOffer_RPC : RPCTemplate<CancelOffer_RPC>
    {
        /// <summary>
        /// The ID of the offer to examine. Can be retrieved from an offer file by calling cdv inspect spendbundles <offer_file>.
        /// </summary>
        public string trade_id { get; set; }

        /// <summary>
        /// An optional fee (in mojos) to include with the cancellation. Defaults to 0.
        /// </summary>
        public ulong? fee { get; set; } = 0;

        /// <summary>
        /// Defaults to True, which means "cancel on blockchain," ie spend the coins being offered and create new coin's in the Maker's wallet. 
        /// Set to False to cancel locally. See cancellation for more info.
        /// </summary>
        public bool? secure { get; set; } = true;
    }
}
