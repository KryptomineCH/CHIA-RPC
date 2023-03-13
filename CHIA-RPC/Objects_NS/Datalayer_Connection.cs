using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Connection details
    /// </summary>
    public class Datalayer_Connection : ObjectTemplate<Datalayer_Connection>
    {
        /// <summary>
        /// Bytes read
        /// </summary>
        public ulong bytes_read { get; set; }

        /// <summary>
        /// Bytes written
        /// </summary>
        public ulong bytes_written { get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        public double creation_time { get; set; }

        /// <summary>
        /// Last message time
        /// </summary>
        public double last_message_time { get; set; }

        /// <summary>
        /// Local port
        /// </summary>
        public ulong local_port { get; set; }

        /// <summary>
        /// Node ID
        /// </summary>
        public string node_id { get; set; }

        /// <summary>
        /// Peer host
        /// </summary>
        public string peer_host { get; set; }

        /// <summary>
        /// Peer port
        /// </summary>
        public ulong peer_port { get; set; }

        /// <summary>
        /// Peer server port
        /// </summary>
        public ulong peer_server_port { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public ulong type { get; set; }
    }
}
