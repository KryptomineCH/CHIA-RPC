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
    /// returned by <see cref="GetKey_RPC"/>
    /// <see href="https://docs.chia.net/daemon-rpc#get_key"/><br/>
    /// an implicit conversion to <see cref="FingerPrint_RPC"/> exists
    /// </remarks>
    public class GetKey_Response : ResponseTemplate<GetKey_Response>
    {
        /// <summary>
        /// The key information returned from the server.
        /// </summary>
        public Key key { get; set; }
    }
    /// <summary>
    /// Represents the JSON RPC request for the get_key function.
    /// Given a fingerprint, this RPC retrieves the corresponding key.
    /// Usage: chia rpc daemon [OPTIONS] get_key [REQUEST]
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/daemon-rpc#get_key"/></remarks>
    /// <returns><see cref="GetKey_Response"/></returns>
    public class GetKey_RPC : RPCTemplate<GetKey_RPC>
    {
        /// <summary>
        /// Parameterless constructor, used for serialization.
        /// </summary>
        public GetKey_RPC() { /* for serialisation */ }

        /// <summary>
        /// Initializes a new instance with <see cref="ulong"/> and optionally include secrets.
        /// </summary>
        /// <param name="fingerprint">The fingerprint whose key you want to look up.</param>
        /// <param name="include_secrets">Set to true to include secrets in the response. Default is false.</param>
        public GetKey_RPC(ulong fingerprint, bool? include_secrets = null)
        {
            this.fingerprint = fingerprint;
            this.include_secrets = include_secrets;
        }
        /// <summary>
        /// Initializes a new instance with <see cref="FingerPrints_RPC"/> and optionally include secrets.
        /// </summary>
        /// <param name="fingerprint">The fingerprint whose key you want to look up.</param>
        /// <param name="include_secrets">Set to true to include secrets in the response. Default is false.</param>
        public GetKey_RPC(FingerPrint_RPC fingerprint, bool? include_secrets = null)
        {
            this.fingerprint = fingerprint.fingerprint;
            this.include_secrets = include_secrets;
        }
        /// <summary>
        /// Initializes a new instance with <see cref="FingerPrint_Response"/> and optionally include secrets.
        /// </summary>
        /// <param name="fingerprint">The fingerprint whose key you want to look up.</param>
        /// <param name="include_secrets">Set to true to include secrets in the response. Default is false.</param>
        public GetKey_RPC(FingerPrint_Response fingerprint, bool? include_secrets = null)
        {
            this.fingerprint = fingerprint.fingerprint;
            this.include_secrets = include_secrets;
        }
        /// <summary>
        /// Initializes a new instance with <see cref="Key"/> and optionally include secrets.
        /// </summary>
        /// <param name="key">The fingerprint whose key you want to look up.</param>
        /// <param name="include_secrets">Set to true to include secrets in the response. Default is false.</param>
        public GetKey_RPC(Key key, bool? include_secrets = null)
        {
            this.fingerprint = key.fingerprint;
            this.include_secrets = include_secrets;
        }
        /// <summary>
        /// Initializes a new instance with <see cref="GetKey_Response"/> and optionally include secrets.
        /// </summary>
        /// <param name="key">The fingerprint whose key you want to look up.</param>
        /// <param name="include_secrets">Set to true to include secrets in the response. Default is false.</param>
        public GetKey_RPC(GetKey_Response keyResponse, bool? include_secrets = null)
        {
            this.fingerprint = keyResponse.key.fingerprint;
            this.include_secrets = include_secrets;
        }
        /// <summary>
        /// The fingerprint whose key you want to look up.
        /// </summary>
        public ulong fingerprint { get; set; }

        /// <summary>
        /// Set to true to include secrets in the response. Default is false.
        /// </summary>
        public bool? include_secrets { get; set; }
    }

}
