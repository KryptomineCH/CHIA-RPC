using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS
{
    /// <summary>
    /// Represents the server response for the `get_version` functionality.
    /// The `get_version` functionality is used to show the version of the daemon.
    /// <br/>
    /// <see cref="ResponseTemplate{GetVersion_Response}"/> is the base class and already includes the properties 'success' and 'error'.
    /// </summary>
    public class GetVersion_Response : ResponseTemplate<GetVersion_Response>
    {
        /// <summary>
        /// Represents the version of the daemon.
        /// </summary>
        public string version { get; set; }
    }

}
