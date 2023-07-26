
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS
{
    /// <summary>
    /// Represents a JSON RPC request to delete a mirror for a specific singleton in a DataLayer wallet.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#dl_delete_mirror"/></remarks>
    /// <returns><see cref="DlNewMirror_Response"/></returns>
    public class DlDeleteMirror_RPC : RPCTemplate<DlDeleteMirror_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public DlDeleteMirror_RPC() { /* for serialisation */ }
        /// <summary>
        /// Represents a JSON RPC request to delete a mirror for a specific singleton in a DataLayer wallet.
        /// </summary>
        /// <param name="coin_id">The coin_id of the mirror to delete.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public DlDeleteMirror_RPC(string coin_id, ulong? fee = null)
        {
            this.coin_id = coin_id;
            this.fee = fee;
        }

        /// <summary>
        /// The coin_id of the mirror to delete.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? coin_id { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }

}
