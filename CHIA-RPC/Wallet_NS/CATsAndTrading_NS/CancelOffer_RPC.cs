
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Class for serializing and deserializing a cancel_offer JSON RPC request.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#cancel_offer"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class CancelOffer_RPC : RPCTemplate<CancelOffer_RPC>
    {
        /// <summary>
        /// Set to true to cancel on the blockchain by spending the coin(s) being offered; set to false to cancel in the wallet only. If false, the offer could still be taken if it has been shared.
        /// </summary>
        public bool secure { get; set; }

        /// <summary>
        /// The ID of the offer to cancel.
        /// </summary>
        public string trade_id { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        public ulong? fee { get; set; }
    }

}
