
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
        public Transaction_DictMemos tx_record { get; set; }
    }
    /// <summary>
    /// Represents a JSON RPC request to update the root of a data store.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#dl_update_root"/></remarks>
    /// <returns><see cref="General_NS.Tx"/></returns>
    public class DlUpdateRoot_RPC : RPCTemplate<DlUpdateRoot_RPC>
    {
        /// <summary>
        /// The launcher ID of the DataLayer wallet.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// The new root hash of the data store.
        /// </summary>
        public string new_root { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        public ulong? fee { get; set; }
    }

}
