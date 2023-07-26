using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// response with a transaction id
    /// </summary>
    public class TradeID_Response : ResponseTemplate<TradeID_Response>
    {
        /// <summary>
        /// The transaction ID
        /// </summary>
        public string? trade_id { get; set; }
    }
}
