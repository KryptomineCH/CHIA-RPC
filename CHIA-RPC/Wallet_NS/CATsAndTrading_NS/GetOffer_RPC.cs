using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Show the details of one offer
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#get_offer"/></remarks>
    /// <returns><see cref="OfferFile"/></returns>
    public class GetOffer_RPC : RPCTemplate<GetOffer_RPC>
    {
        /// <summary>
        /// The offer's ID
        /// </summary>
        public string trade_id { get; set; }

        /// <summary>
        /// The contents of the offer. Required if the offer's info is not stored in the database for this wallet
        /// </summary>
        public string? file_contents { get; set; }
    }
}
