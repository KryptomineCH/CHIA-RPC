using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_RPC_NS.DLWallet_NS.DLWalletObjects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DLWallet_NS
{
    /// <summary>
    /// Class for deserializing the response of the "dl_history" RPC request in the Chia blockchain.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#dl_history"/><br/><br/>
    /// Using:<br/><see cref="DlHistory_RPC"/>
    /// </remarks>
    public class DlHistory_Response : ResponseTemplate<DlHistory_Response>
    {
        /// <summary>
        /// The number of records returned.
        /// </summary>
        public ulong? count { get; set; }

        /// <summary>
        /// An array of the records returned.
        /// </summary>
        public HistoryRecord[] history { get; set; }
    }

    /// <summary>
    /// RPC request class for the "dl_history" command in the Chia wallet RPC API.
    /// Show the history of a data store
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#dl_history"/></remarks>
    /// <returns><see cref="DlHistory_Response"/></returns>
    public class DlHistory_RPC : RPCTemplate<DlHistory_RPC>
    {
        /// <summary>
        /// The launcher ID of the DataLayer wallet.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// The first generation of singleton to show [Default: none].
        /// </summary>
        public ulong? min_generation { get; set; }

        /// <summary>
        /// The last generation of the singleton to show [Default: none].
        /// </summary>
        public ulong? max_generation { get; set; }

        /// <summary>
        /// The number of results to show [Default: show all results].
        /// </summary>
        public ulong? num_results { get; set; }
    }

}
