using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Represents the response returned by the "get_pool_login_link" API endpoint.
    /// </summary>
    /// <remarks>
    /// request uses a <see cref="General_NS.LauncherID_RPC"/><br/>
    /// <see cref="https://docs.chia.net/farmer-rpc#get_pool_login_link"/>
    /// </remarks>
    public class GetPoolLoginLink_Response : ResponseTemplate<GetPoolLoginLink_Response>
    {
        /// <summary>
        /// The URI to view the pool info.
        /// </summary>
        public string login_link { get; set; }

        /// <summary>
        /// Indicates whether the API call was successful.
        /// </summary>
        public bool success { get; set; }
    }

}
