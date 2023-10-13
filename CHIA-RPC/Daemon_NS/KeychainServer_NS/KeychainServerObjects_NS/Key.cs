using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
namespace CHIA_RPC.Daemon_NS.KeychainServer_NS.KeychainServerObjects_NS
{
    /// <summary>
    /// represents a fingerprint
    /// </summary>
    /// <remarks>
    /// used by multiple daemon endpoints such as:<br/>
    /// - <see cref="GetKeys_RPC"/><br/>
    /// - <see cref="GetKey_RPC"/><br/>
    /// <br/>
    /// <b>Conversions:</b><br/>
    /// - An implicit Conversion to <see cref="FingerPrint_RPC"/> exists
    /// </remarks>
    public class Key : ObjectTemplate<Key>
    {
        /// <summary>
        /// the wallet figer print
        /// </summary>
        public ulong fingerprint { get; set; }
        /// <summary>
        /// the public key
        /// </summary>
        public string? public_key { get; set; }
        /// <summary>
        /// The entropy associated with the private key. Usually a hexadecimal string.
        /// </summary>
        /// <remarks>returned when called by daemon</remarks>
        public string? entropy { get; set; }
        /// <summary>
        /// the human identifiable name of the key/wallet
        /// </summary>
        /// <remarks>
        /// this is machine specific and won't be synchronized through the blockchain<br/>
        /// this is returned by the daemon
        /// </remarks>
        public string? label { get; set; }
        /// <summary>
        /// Contains secrets associated with the key. May be null if no secrets are provided or available.
        /// </summary>
        public dynamic? secrets { get; set; }
    }
}
