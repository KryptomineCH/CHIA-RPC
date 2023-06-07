using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// renames a did wallet. Returns a wallet_id response<br/>
    /// this is just local. Te wallet will not be renamed on the Blockchain and will not synchronize to other clients
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/did-rpc#did_set_wallet_name"/></remarks>
    /// <returns><see cref="General_NS.WalletID_Response"/></returns>
    public class DidSetWalletName_RPC : RPCTemplate<DidSetWalletName_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public DidSetWalletName_RPC() { /* for Serialisation */ }
        /// <summary>
        /// renames a did wallet. Returns a wallet_id response
        /// </summary>
        /// <param name="wallet_id">the id of the wallet which should be updated</param>
        /// <param name="name">The name which should be given to the did wallet</param>
        public DidSetWalletName_RPC(ulong wallet_id, string name)
        {
            this.wallet_id = wallet_id;
            this.name = name;
        }
        /// <summary>
        /// renames a did wallet. Returns a wallet_id response
        /// </summary>
        /// <param name="wallet_id">the id of the wallet which should be updated</param>
        /// <param name="name">The name which should be given to the did wallet</param>
        public DidSetWalletName_RPC(WalletID_RPC wallet_id, string name)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.name = name;
        }
        /// <summary>
        /// renames a did wallet. Returns a wallet_id response
        /// </summary>
        /// <param name="wallet_id">the id of the wallet which should be updated</param>
        /// <param name="name">The name which should be given to the did wallet</param>
        public DidSetWalletName_RPC(WalletID_Response wallet_id, string name)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.name = name;
        }

        /// <summary>
        /// the id of the wallet which should be updated
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The name which should be given to the did wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string name { get; set; }
    }
}
