
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DLWallet_NS
{
    /// <summary>
    /// Represents a JSON RPC request to delete a mirror for a specific singleton in a DataLayer wallet.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#dl_delete_mirror"/></remarks>
    /// <returns><see cref="DlNewMirror_Response"/></returns>
    public class DlDeleteMirror_RPC : RPCTemplate<DlDeleteMirror_RPC>
    {
        /// <summary>
        /// The coin_id of the mirror to delete.
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        public ulong? fee { get; set; }
    }

}
