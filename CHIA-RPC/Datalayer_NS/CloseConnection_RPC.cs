using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Close an active connection
    /// </summary>
    public class CloseConnection_RPC : RPCTemplate<CloseConnection_RPC>
    {
        /// <summary>
        /// The hex ID of the node to close, obtainable from get_connections
        /// </summary>
        public string node_id { get; set; }
    }
}
