using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Rename a CAT wallet.<br/>
    /// note that this change is local only and will not be synchronized to other clients
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#cat_set_name"/></remarks>
    /// <returns><see cref="General_NS.WalletID_Response"/></returns>
    public class CatSetName_RPC : RPCTemplate<CatSetName_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CatSetName_RPC() { /* for serialisation */ }

        /// <summary>
        /// Rename a CAT wallet.
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet whose name you would like to change.</param>
        /// <param name="name">The new name for the wallet.</param>
        public CatSetName_RPC(ulong wallet_id, string name)
        {
            this.wallet_id = wallet_id;
            this.name = name;
        }
        /// <summary>
        /// Rename a CAT wallet.
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet whose name you would like to change.</param>
        /// <param name="name">The new name for the wallet.</param>
        public CatSetName_RPC(WalletID_RPC wallet_id, string name)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.name = name;
        }
        /// <summary>
        /// Rename a CAT wallet.
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet whose name you would like to change.</param>
        /// <param name="name">The new name for the wallet.</param>
        public CatSetName_RPC(WalletID_Response wallet_id, string name)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.name = name;
        }

        /// <summary>
        /// The ID of the wallet whose name you would like to change.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The new name for the wallet.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string name { get; set; }
    }
}
