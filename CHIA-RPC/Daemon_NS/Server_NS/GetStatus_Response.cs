using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the server response for the `get_status` functionality in a blockchain network.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#get_status"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Shows the status of the daemon. Request parameters: None.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - request does not take any parameters
    /// </remarks>
    /// 
    /// <returns>
    /// Bool, indicating the genesis initialization status.
    /// </returns>

    public class GetStatus_Response : ResponseTemplate<GetStatus_Response>
    {
        /// <summary>
        /// indicating the genesis initialization status.
        /// </summary>
        public bool genesis_initialized { get; set; }
    }

}
