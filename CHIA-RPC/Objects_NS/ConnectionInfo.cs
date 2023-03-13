using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Represents the connection information for the harvester node.
    /// </summary>
    public class ConnectionInfo : ObjectTemplate<ConnectionInfo>
    {
        /// <summary>
        /// The IP address or hostname of the harvester node.
        /// </summary>
        public string host { get; set; } = null!;

        /// <summary>
        /// The node ID of the harvester node.
        /// </summary>
        public string node_id { get; set; } = null!;

        /// <summary>
        /// The port number of the harvester node.
        /// </summary>
        public uint port { get; set; }
    }
}
