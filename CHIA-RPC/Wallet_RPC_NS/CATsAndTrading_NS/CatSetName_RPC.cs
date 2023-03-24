using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Rename a CAT wallet.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#cat_set_name"/></remarks>
    /// <returns><see cref="General_NS.WalletID_Response"/></returns>
    public class CatSetName_RPC : RPCTemplate<CatSetName_RPC>
    {
        /// <summary>
        /// The ID of the wallet whose name you would like to change.
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The new name for the wallet.
        /// </summary>
        public string name { get; set; }
    }
}
