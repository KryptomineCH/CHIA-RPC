using CHIA_RPC.General_NS;
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
        /// parameterless constructor, for serializer
        /// </summary>
        public GetOffer_RPC() { /* for serialisation */ }

        /// <summary>
        /// Show the details of one offer
        /// </summary>
        /// <param name="trade_id">The offer's ID</param>
        /// <param name="file_contents">The contents of the offer. Required if the offer's info is not stored in the database for this wallet</param>
        public GetOffer_RPC(string trade_id, string? file_contents = null)
        {
            this.trade_id = trade_id;
            this.file_contents = file_contents;
        }
        /// <summary>
        /// Show the details of one offer
        /// </summary>
        /// <param name="trade_id">The offer's ID</param>
        /// <param name="file_contents">The contents of the offer. Required if the offer's info is not stored in the database for this wallet</param>
        public GetOffer_RPC(TradeRecord trade, string? file_contents = null)
        {
            this.trade_id = trade.trade_id;
            this.file_contents = file_contents;
        }

        /// <summary>
        /// The offer's ID
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string trade_id { get; set; }

        /// <summary>
        /// The contents of the offer. <br/>
        /// Required if the offer's info is not stored in the database for this wallet
        /// </summary>
        /// <remarks>optional</remarks>
        public string? file_contents { get; set; }

        /// <summary>
        /// converts a TradeRecord into GetOffer_RPC
        /// </summary>
        /// <param name="tradeRecord"></param>
        public static implicit operator GetOffer_RPC(TradeRecord tradeRecord)
        {
            return new GetOffer_RPC(tradeRecord);
        }
        /// <summary>
        /// converts a TradeRecord into GetOffer_RPC
        /// </summary>
        /// <param name="tradeRecord"></param>
        public static implicit operator GetOffer_RPC(TradeRecord_Response tradeRecord)
        {
            return new GetOffer_RPC(tradeRecord.trade_record);
        }
    }
}
