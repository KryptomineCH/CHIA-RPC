using CHIA_RPC.Daemon_NS.Server_NS.ServerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Server_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the server response for listing one or more addresses from one or more keys in a blockchain network.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#get_wallet_addresses"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Serves as the response for the `get_wallet_addresses` functionality.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - takes <see cref="GetWalletAddresses_RPC"/> for the request.<br/>
    /// </remarks>
    ///<returns>
    /// Represents a mapping between wallet identifiers and their associated addresses and hierarchical deterministic paths. Type: <see cref="Dictionary{TKey, TValue}"/><see cref="ulong"/>, <see cref="AddressInfo"/>[].
    /// </returns>
    public class GetWalletAddresses_Response : ResponseTemplate<GetWalletAddresses_Response>
    {
        /// <summary>
        /// Represents a mapping between wallet identifiers and their associated addresses and hierarchical deterministic paths.
        /// </summary>
        public Dictionary<ulong, AddressInfo[]> wallet_addresses { get; set; }
    }
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the RPC request for the `get_wallet_addresses` functionality in a blockchain network.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#get_wallet_addresses"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Used to list one or more addresses from one or more keys.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `fingerprints`: List the keys for the specified fingerprints only. Type: <see cref="ulong"/>[].<br/>
    /// - `index`: Starting index for addresses to list. Type: <see cref="ulong"/>?.<br/>
    /// - `count`: Number of addresses to list. Type: <see cref="ulong"/>?.<br/>
    /// - `non_observer_derivation`: Set to True to use non-observer derivation. Type: <see cref="bool"/>?.<br/>
    /// </remarks>
    /// 
    /// <returns>
    /// <b>Returns:</b><br/>
    /// <see cref="GetWalletAddresses_Response"/>
    /// </returns>
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
