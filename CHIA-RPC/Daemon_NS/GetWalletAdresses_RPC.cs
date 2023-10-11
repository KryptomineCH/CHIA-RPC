
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS
{
    /// <summary>
    /// Represents the server response for listing one or more addresses from one or more keys.
    /// <br/>
    /// <see cref="ResponseTemplate{GetWalletAddresses_Response}"/> is the base class and already includes the properties 'success' and 'error'.
    /// </summary>
    public class GetWalletAddresses_Response : ResponseTemplate<GetWalletAddresses_Response>
    {
        /// <summary>
        /// Represents a mapping between wallet identifiers and their associated addresses and hierarchical deterministic paths.
        /// </summary>
        public Dictionary<ulong, DaemonObjects_NS.AddressInfo[]> wallet_addresses { get; set; }
    }
    /// <summary>
    /// Represents the RPC request for the `get_wallet_addresses` functionality.
    /// The `get_wallet_addresses` functionality is used to list one or more addresses from one or more keys.
    /// <br/>
    /// Usage: chia rpc daemon [OPTIONS] get_wallet_addresses [REQUEST]
    /// <br/>
    /// <see cref="RPCTemplate{GetWalletAddresses_RPC}"/> is the base class and already includes the properties 'success' and 'error'.
    /// </summary>
    public class GetWalletAddresses_RPC : RPCTemplate<GetWalletAddresses_RPC>
    {
        /// <summary>
        /// List the keys for the specified fingerprints only. Default is to list keys for all fingerprints.
        /// </summary>
        public ulong[] fingerprints { get; set; }

        /// <summary>
        /// Starting index for addresses to list. Default is 0.
        /// </summary>
        public ulong? index { get; set; }

        /// <summary>
        /// Number of addresses to list. Default is 1.
        /// </summary>
        public ulong? count { get; set; }

        /// <summary>
        /// Set to True to use non-observer derivation. Default is False.
        /// </summary>
        public bool? non_observer_derivation { get; set; }
    }

}
