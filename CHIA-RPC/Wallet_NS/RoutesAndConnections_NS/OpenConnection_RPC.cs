using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.RoutesAndConnections_NS
{
    /// <summary>
    /// RPC request to open a connection to another node.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#open_connection"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
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
