using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.General_NS;

namespace CHIA_RPC.Wallet_NS.WalletManagement_NS
{
    /// <summary>
    /// Show all wallets associated with the current fingerprint, including (by default) coin information
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_wallets"/><br/><br/>
    /// Uses:<br/><see cref="GetWallets_RPC"/>
    /// </remarks>
    public class GetWallets_Response : ResponseTemplate<GetWallets_Response>
    {
        /// <summary>
        /// the fingerprint for which the related wallets were loaded
        /// </summary>
        public ulong fingerprint { get; set; }
        /// <summary>
        /// the wallets related to this fingerprint
        /// </summary>
        public Wallets_info[]? wallets { get; set; }
    }
    /// <summary>
    /// Represents a wallet in the Chia network, providing methods and properties 
    /// to access various aspects of the wallet such as its ID, name, and type.
    /// </summary>
    public class Wallets_info
    {
        /// <summary>
        /// The 'data' property can hold any type of data related to the wallet. 
        /// The type of this data can be dynamic, making this property flexible 
        /// for holding various types of information.
        /// </summary>
        public dynamic? data { get; set; }
        /// <summary>
        /// the wallet id in the currently logged in fingerprint. Use this to pull the wallet name
        /// </summary>
        public ulong id { get; set; }
        /// <summary>
        /// WARNING: tnis is the friendly name which a user has set.<br/>
        /// if no name string has been set, shows the did ID. Best pull the did id from the wallet
        /// </summary>
        public string? name { get; set; }
        /// <summary>
        /// The type of the wallet, represented as a value from the WalletType enumeration. 
        /// This property can be used to determine what kind of wallet this is, 
        /// and what capabilities or restrictions it might have.
        /// </summary>
        public WalletType? type { get; set; }
        /// <summary>
        /// gets a walletID RPC which may be used to obtain further information about the wallet
        /// </summary>
        /// <returns></returns>
        public WalletID_RPC GetWalletID_RPC()
        {
            return new WalletID_RPC(id);
        }
        /// <summary>
        /// Allows for implicit conversion from a Wallets_info instance to a WalletID_RPC instance.
        /// This can be useful in contexts where a WalletID_RPC is required, but a Wallets_info instance 
        /// is available. The conversion uses the GetWalletID_RPC method to perform the conversion.
        /// </summary>
        /// <param name="walletsInfo">A Wallets_info instance.</param>
        public static implicit operator WalletID_RPC(Wallets_info walletsInfo)
        {
            return walletsInfo.GetWalletID_RPC();
        }

    }
    /// <summary>
    /// Show all wallets associated with the current fingerprint, including (by default) coin information
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#get_wallets"/></remarks>
    /// <returns><see cref="GetWallets_Response"/></returns>
    public class GetWallets_RPC : RPCTemplate<GetWallets_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public GetWallets_RPC() { /* for Serialisation */ }
        /// <summary>
        /// Show all wallets associated with the current fingerprint, including (by default) coin information
        /// </summary>
        /// <param name="include_data">Set to true to include all coin info for this wallet [Default: true]</param>
        /// <param name="wallet_type">The type of wallet to retrieve.</param>
        public GetWallets_RPC(bool include_data, WalletType? wallet_type = null)
        {
            this.include_data = include_data;
            string? type;
            if (wallet_type == null)
            {
                type = null;
            }
            else
            {
                type = wallet_type.Value.ToString();
            }
            this.type = type;
        }

        /// <summary>
        /// Set to true to include all coin info for this wallet [Default: true]
        /// </summary>
        /// <remarks>optional</remarks>
        public bool include_data { get; set; }
        /// <summary>
        /// The type of wallet to retrieve. If included, must be one of `cat_wallet`, `did_wallet`, `nft_wallet`, or `pool_wallet`
        /// </summary>
        /// <remarks>optional</remarks>
        public string? type { get; set; }
    }
}
