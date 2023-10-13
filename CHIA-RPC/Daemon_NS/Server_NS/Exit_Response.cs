using CHIA_RPC.Daemon_NS.Server_NS.ServerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the server response for the `exit` functionality in a blockchain network.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#exit"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// The `exit` functionality is used to stop the daemon and all of its running services.<br/>
    /// </remarks>
    /// 
    /// <returns>
    ///  <see cref="ChiaService"/>[] containing the list of stopped services.
    /// </returns>
    public class Exit_Response : ResponseTemplate<Exit_Response>
    {
        /// <summary>
        /// the list of services that have been stopped.
        /// </summary>
        public ChiaService[] services_stopped { get; set; }
    }

}
