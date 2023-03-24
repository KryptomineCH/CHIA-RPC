using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.WalletManagement_NS
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
        public Wallets_info[] wallets { get; set; }
    }
    public class Wallets_info
    {
        public dynamic data { get; set; }
        public ulong id { get; set; }
        public string name {
            get { return _name; }
            set {
                if (value.Contains(' '))
                {
                    _name = value.Split(' ')[1];
                }
                else { _name = value; }
            } 
        }
        private string _name { get; set; }
        public WalletType type { get; set; }
    }
    /// <summary>
    /// Show all wallets associated with the current fingerprint, including (by default) coin information
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#get_wallets"/></remarks>
    /// <returns><see cref="GetWallets_Response"/></returns>
    public class GetWallets_RPC : RPCTemplate<GetWallets_RPC>
    {
        /// <summary>
        /// Set to true to include all coin info for this wallet [Default: true]
        /// </summary>
        public bool include_data { get; set; }
    }
}
