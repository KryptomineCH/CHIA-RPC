using CHIA_RPC.Daemon_NS.KeychainServer_NS.KeychainServerObjects_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.KeychainServer_NS
{
    /// <summary>
    /// Represents the server response for the get_key RPC call.
    /// This RPC call retrieves a key corresponding to a given fingerprint.
    /// Note: Set include_secrets to true in the request to include secrets in the response. Default is false.
    /// </summary>
    /// <remarks>
    /// returned by <see cref="GetKeys_RPC"/>
    /// <see href="https://docs.chia.net/daemon-rpc#get_keys"/><br/>
    /// an implicit conversion to <see cref="FingerPrints_RPC"/> exists
    /// </remarks>
    public class GetKeys_Response : ResponseTemplate<GetKeys_Response>
    {
        /// <summary>
        /// The key information returned from the server.
        /// </summary>
        public Key[] keys { get; set; }
    }
    /// <summary>
    /// Represents the JSON RPC request for the get_keys function.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/daemon-rpc#get_keys"/></remarks>
    /// <returns><see cref="GetKeys_Response"/></returns>
    public class GetKeys_RPC : RPCTemplate<GetKeys_RPC>
    {
        /// <summary>
        /// Parameterless constructor, used for serialization.
        /// </summary>
        public GetKeys_RPC() { /* for serialisation */ }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKeys_RPC"/> class with the optional <paramref name="include_secrets"/> flag.
        /// </summary>
        /// <param name="include_secrets">Set to true to include secrets in the response. Default is false.</param>
        public GetKeys_RPC(bool include_secrets)
        {
            this.include_secrets = include_secrets;
        }

        /// <summary>
        /// Set to true to include secrets in the response. Default is false.
        /// </summary>
        public bool? include_secrets { get; set; }
    }
}
