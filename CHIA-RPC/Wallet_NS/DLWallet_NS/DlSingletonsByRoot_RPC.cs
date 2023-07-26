using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS
{
    /// <summary>
    /// Response class for "dl_singletons_by_root" RPC request in Chia blockchain.
    /// Get the singleton records that contain the specified root.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#dl_singletons_by_root"/><br/><br/>
    /// Uses:<br/><see cref="DlSingletonsByRoot_RPC"/>
    /// </remarks>
    public class DlSingletonsByRoot_Response : ResponseTemplate<DlSingletonsByRoot_Response>
    {
        /// <summary>
        /// List of singleton records that contain the specified root.
        /// </summary>
        public Singleton[]? singletons { get; set; }
    }
    /// <summary>
    /// Request to get the singleton records that contain the specified root.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#dl_singletons_by_root"/></remarks>
    /// <returns><see cref="DlSingletonsByRoot_Response"/></returns>
    public class DlSingletonsByRoot_RPC : RPCTemplate<DlSingletonsByRoot_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public DlSingletonsByRoot_RPC() { /* for serialisation */ }
        /// <summary>
        /// Request to get the singleton records that contain the specified root.
        /// </summary>
        /// <param name="launcher_id">The launcher ID of the DataLayer wallet.</param>
        /// <param name="root">The root hash of an existing data store.</param>
        public DlSingletonsByRoot_RPC(string launcher_id, string root)
        {
            this.launcher_id = launcher_id;
            this.root = root;
        }

        /// <summary>
        /// The launcher ID of the DataLayer wallet.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? launcher_id { get; set; }

        /// <summary>
        /// The root hash of an existing data store.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? root { get; set; }
    }
}
