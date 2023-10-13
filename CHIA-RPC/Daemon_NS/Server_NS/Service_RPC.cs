using CHIA_RPC.Daemon_NS.Server_NS.ServerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// Represents the RPC response for a service.
    /// </summary>
    public class Service_Response : ResponseTemplate<Service_Response>
    {
        /// <summary>
        /// The name of the service to register.
        /// <br/>
        /// This is a mandatory field.
        /// </summary>
        public ChiaService service { get; set; }
    }
    /// <summary>
    /// Represents the RPC request for a service.
    /// </summary>
    public class Service_RPC : RPCTemplate<Service_RPC>
    {
        /// <summary>
        /// The name of the service to register.
        /// <br/>
        /// This is a mandatory field.
        /// </summary>
        public ChiaService service { get; set; }
    }

}
