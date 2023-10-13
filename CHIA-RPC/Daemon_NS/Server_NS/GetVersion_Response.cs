using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the server response for the `get_version` functionality in a blockchain network.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#get_version"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Shows the version of the daemon. Request parameters: None.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - request has no parameters
    /// </remarks>
    /// 
    /// <returns>
    /// Property <see cref="version"/> indicating the version of the daemon.
    /// </returns>
    public class GetVersion_Response : ResponseTemplate<GetVersion_Response>
    {
        /// <summary>
        /// Represents the version of the daemon.
        /// </summary>
        public string version { get; set; }
    }

}
