using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// Represents the response for a trade record server request in the Chia ecosystem.
    /// This class contains the trade record of a specific transaction, which includes details about the transaction such as the traded assets, their quantity, the involved parties, and the timestamp of the transaction.
    /// </summary>
    /// <remarks>
    /// A 'TradeRecord_Response' is returned from the server when a request is made to retrieve details about a specific trade.
    /// The trade details are stored in a 'TradeRecord' object.
    /// The 'TradeRecord' contains detailed information about the trade, which can include the assets involved in the trade, the parties involved, the quantity of assets traded, and the timestamp of the trade, among other details.
    /// This information can be used to keep track of the trades that a user has made, for auditing purposes, or to display a history of trades to the user.
    /// </remarks>
    public class TradeRecord_Response : ResponseTemplate<TradeRecord_Response>
    {
        /// <summary>
        /// The 'TradeRecord' object that contains the details of the trade.
        /// This includes information such as the assets involved in the trade, the parties involved, the quantity of the assets traded, and the timestamp of the trade, among other details.
        /// The 'TradeRecord' is a complete record of the trade, which can be used to verify the details of the trade, to keep track of the trades that a user has made, or to display a history of trades to the user.
        /// </summary>
        public TradeRecord? trade_record { get; set; }
    }

}
