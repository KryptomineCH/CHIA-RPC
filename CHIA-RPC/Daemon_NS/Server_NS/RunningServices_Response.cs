using CHIA_RPC.Daemon_NS.Server_NS.ServerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the server response showing all services that are currently running.
    /// </summary>
    ///
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#running_services"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// This response provides information about the services currently running on the server.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - the request is parameterless
    /// </remarks>
    ///
    /// <returns>
    /// - `running_services`: List of running services. Type: <see cref="ChiaService"/>[]
    /// </returns>
    public class RunningServices_Response : ResponseTemplate<RunningServices_Response>
    {
        /// <summary>
        /// List of running services.
        /// <br/>
        /// Enum values are used to represent the services.
        /// </summary>
        public ChiaService[] running_services { get; set; }
    }
}
