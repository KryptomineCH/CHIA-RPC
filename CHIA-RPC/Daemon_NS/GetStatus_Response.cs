using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS
{
    /// <summary>
    /// Show the status of the daemon
    /// </summary>
    public class GetStatus_Response : ResponseTemplate<GetStatus_Response>
    {
        /// <summary>
        /// unknown
        /// </summary>
        public bool genesis_initialized { get; set; }
    }

}
