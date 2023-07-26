using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Represents a response for getting a list of all unacknowledged CATs.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#get_stray_cats"/><br/><br/>
    /// Uses:<br/>the request does not have any parameters
    /// </remarks>
    public class GetStrayCats_Response : ResponseTemplate<GetStrayCats_Response>
    {
        /// <summary>
        /// The list of unacknowledged CATs.
        /// </summary>
        public object[]? stray_cats { get; set; }
    }
}
