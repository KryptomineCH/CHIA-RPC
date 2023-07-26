using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Represents the response of the get_pool_state endpoint.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/farmer-rpc#get_pool_state"/><br/><br/>
    /// Uses:<br/>the request has no parameters
    /// </remarks>
    public class GetPoolState_Response : ResponseTemplate<GetPoolState_Response>
    {
        /// <summary>
        /// The state of the pool.
        /// </summary>
        public PoolState[]? pool_state { get; set; }
    }

}
