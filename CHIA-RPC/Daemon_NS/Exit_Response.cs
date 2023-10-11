using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS
{
    /// <summary>
    /// Represents the server response for the `exit` functionality.
    /// The `exit` functionality is used to stop the daemon and all of its running services.
    /// <br/>
    /// Usage: chia rpc daemon [OPTIONS] exit [REQUEST]
    /// <br/>
    /// <see cref="ResponseTemplate{Exit_Response}"/> is the base class and already includes the properties 'success' and 'error'.
    /// </summary>
    public class Exit_Response : ResponseTemplate<Exit_Response>
    {
        /// <summary>
        /// Represents the list of services that have been stopped.
        /// </summary>
        public string[] services_stopped { get; set; }
    }

}
