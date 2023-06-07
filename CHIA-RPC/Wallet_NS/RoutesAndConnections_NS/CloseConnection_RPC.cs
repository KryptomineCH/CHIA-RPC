using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.RoutesAndConnections_NS
{
    /// <summary>
    /// Represents a JSON-RPC request for closing an active connection to a node.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#close_connection"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class CloseConnection_RPC : RPCTemplate<CloseConnection_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CloseConnection_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents a JSON-RPC request for closing an active connection to a node.
        /// </summary>
        /// <param name="node_id">The hex ID of the node to close, obtainable from get_connections</param>
        public CloseConnection_RPC(string node_id)
        {
            this.node_id = node_id;
        }

        /// <summary>
        /// The hex ID of the node to close, obtainable from get_connections
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string node_id { get; set; }
    }

}
