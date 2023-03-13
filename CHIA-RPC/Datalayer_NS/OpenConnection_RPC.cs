using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Class for serializing/deserializing an open_connection RPC request.
    /// </summary>
    public class OpenConnection_RPC : RPCTemplate<OpenConnection_RPC>
    {
        /// <summary>
        /// The IP or URL of the node to connect to.
        /// </summary>
        public string host { get; set; }

        /// <summary>
        /// The port through which to connect to the remote node.
        /// </summary>
        public ulong port { get; set; }
    }

}
