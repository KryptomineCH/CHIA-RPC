using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get a list of active connections
    /// </summary>
    public class GetConnections_Response : ResponseTemplate<GetConnections_Response>
    {
        /// <summary>
        /// List of active connections
        /// </summary>
        public Datalayer_Connection[] connections { get; set; }
    }

}