using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// An adress which can be used for receiving
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_next_address"/><br/><br/>
    /// Uses:<br/><see cref="GetNextAddress_RPC"/>
    /// </remarks>
    /// <summary>
    /// Represents the server response for wallet addresses.
    /// Each wallet ID is associated with an array of addresses and their corresponding hierarchical deterministic (HD) paths.
    /// </summary>
    public class GetWalletAddresses_Response : ResponseTemplate<GetWalletAddresses_Response>
    {
        /// <summary>
        /// A collection of wallet addresses, keyed by wallet ID.
        /// Each wallet ID maps to an array of address details.
        /// </summary>
        public WalletAddressDetails[] wallet_addresses { get; set; }
    }

    /// <summary>
    /// Represents details of a wallet address, including the address itself and its HD path.
    /// </summary>
    public class WalletAddressDetails
    {
        /// <summary>
        /// The Chia wallet address.
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// The hierarchical deterministic (HD) path for the wallet address.
        /// </summary>
        public string hd_path { get; set; }
    }
    /// <summary>
    /// Get specific address(es) from the address tree, this is mainly used to validate if an address is an own address
    /// </summary>
    /// <remarks>not documented yet</remarks>
    /// <returns><see cref="GetWalletAddress_Response"/></returns>
    public class GetWalletAddresses_RPC : RPCTemplate<GetWalletAddresses_RPC>
    {
        /// <summary>
        /// this constructor is parameterless, primairly used for serialisation purposes
        /// </summary>
        public GetWalletAddresses_RPC() { /* required for serialisation */ }
        /// <summary>
        /// Get specific address(es) from the address tree, this is mainly used to validate if an address is an own address
        /// </summary>
        /// <param name="fingerprints">the wallet which to retrieve an address from</param>
        /// <param name="index">the start index of the wallet addaress to retrieve. 0 Based. Defaults to 0</param>
        /// <param name="count">the amount of adresses to generate. Defaults to 1.</param>
        public GetWalletAddresses_RPC(string[]? fingerprints, ulong? index, ulong? count)
        {
            this.fingerprints = fingerprints;
            this.index = index;
            this.count = count;
        }
        /// <summary>
        /// the wallet number of the wallet in the chia client (eg. 2)
        /// </summary>
        public string[]? fingerprints { get; set; }
        /// <summary>
        /// the start index of the wallet addaress to retrieve. 0 Based. Defaults to 0
        /// </summary>
        public ulong? index { get; set; }
        /// <summary>
        /// the amount of adresses to generate. Defaults to 1
        /// </summary>
        public ulong? count { get; set; }
        public bool? non_observer_derivation { get; set; }
    }
}
