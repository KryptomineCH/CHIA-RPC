
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS
{
    /// <summary>
    /// Represents response to update the root of a data store.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#dl_update_root"/><br/><br/>
    /// Uses:<br/><see cref="DlUpdateRoot_RPC"/>
    /// </remarks>
    public class DlUpdateRoot_Response : ResponseTemplate<DlUpdateRoot_Response>
    {
        /// <summary>
        /// datastore transaction summary
        /// </summary>
        public Transaction_DictMemos? tx_record { get; set; }
    }
    /// <summary>
    /// Represents a JSON RPC request to update the root of a data store.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#dl_update_root"/></remarks>
    /// <returns><see cref="DlUpdateRoot_RPC"/></returns>
    public class DlUpdateRoot_RPC : RPCTemplate<DlUpdateRoot_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public DlUpdateRoot_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents a JSON RPC request to update the root of a data store.
        /// </summary>
        /// <param name="launcher_id">The launcher ID of the DataLayer wallet.</param>
        /// <param name="new_root">The new root hash of the data store.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public DlUpdateRoot_RPC(string launcher_id, string new_root, ulong? fee)
        {
            this.launcher_id = launcher_id;
            this.new_root = new_root;
            this.fee = fee;
        }

        /// <summary>
        /// The launcher ID of the DataLayer wallet.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? launcher_id { get; set; }

        /// <summary>
        /// The new root hash of the data store.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? new_root { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}
