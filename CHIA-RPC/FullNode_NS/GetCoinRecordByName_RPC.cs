using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Represents the response of a GetCoinRecordByName request.
    /// </summary>
    public class GetCoinRecordByName_Response : ResponseTemplate<GetCoinRecordByName_Response>
    {
        /// <summary>
        /// A CoinRecord object containing information about the retrieved coin.
        /// </summary>
        public CoinRecord coin_record { get; set; }
    }

    /// <summary>
    /// Represents the request for retrieving a coin record by its name or ID.
    /// </summary>
    public class GetCoinRecordByName_RPC : RPCTemplate<GetCoinRecordByName_RPC>
    {
        /// <summary>
        /// A string containing the name or ID of the coin to retrieve.
        /// </summary>
        public string name { get; set; }
    }
}
