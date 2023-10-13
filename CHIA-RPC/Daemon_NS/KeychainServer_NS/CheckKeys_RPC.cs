using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.KeychainServer_NS
{
    /// <summary>
    /// Represents the request parameters for the check_keys RPC call.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/daemon-rpc#check_keys"/></remarks>
    /// <returns>unknown returnn type (check docs)</returns>
    public class CheckKeys_RPC : RPCTemplate<CheckKeys_RPC>
    {
        /// <summary>
        /// Parameterless constructor, used for serialization.
        /// </summary>
        public CheckKeys_RPC() { /* for serialisation */ }
        /// <summary>
        /// initializes CheckKeys_RPC with a root path
        /// </summary>
        public CheckKeys_RPC(string rootPath) { 
            this.root_path = rootPath;
        }

        /// <summary>
        /// The root path to check keys.
        /// </summary>
        public string root_path { get; set; }
    }

}
