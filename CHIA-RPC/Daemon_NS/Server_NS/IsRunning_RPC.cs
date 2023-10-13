using CHIA_RPC.Daemon_NS.Server_NS.ServerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the response received from the server to indicate the running status of a Chia service.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#is_running"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Provides information about the running status of a queried Chia service.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - takes <see cref="IsRunning_RPC"/> for the request
    /// </remarks>
    ///
    /// <returns>
    /// - `is_running`: Indicates whether the queried service is running. Type: <see cref="bool"/>.<br/>
    /// - `service_name`: Specifies the name of the service being queried. Type: <see cref="ChiaService"/>.
    /// </returns>

    public class IsRunning_Response : ResponseTemplate<IsRunning_Response>
    {
        /// <summary>
        /// Indicates whether the queried service is running. <br/>
        /// <c>true</c> if the service is running; otherwise, <c>false</c>.
        /// </summary>
        public bool is_running { get; set; }

        /// <summary>
        /// Specifies the name of the service being queried.
        /// </summary>
        public ChiaService service_name { get; set; }
    }
}
