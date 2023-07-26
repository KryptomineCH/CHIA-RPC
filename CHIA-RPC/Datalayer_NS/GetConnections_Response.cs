using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get a list of active connections
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_connections"/><br/><br/>
    /// Uses:<br/>the request has no parameters
    /// </remarks>
    public class GetConnections_Response : ResponseTemplate<GetConnections_Response>
    {
        /// <summary>
        /// List of active connections
        /// </summary>
        public Datalayer_Connection[]? connections { get; set; }
    }

}