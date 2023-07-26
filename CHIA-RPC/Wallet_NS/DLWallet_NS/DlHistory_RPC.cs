using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS
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
        public HistoryRecord[]? history { get; set; }
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
        /// parameterless constructor, for serializer
        /// </summary>
        public DlHistory_RPC() { /* for serialisation */ }
        /// <summary>
        /// RPC request class for the "dl_history" command in the Chia wallet RPC API.
        /// </summary>
        /// <param name="launcher_id">The launcher ID of the DataLayer wallet.</param>
        /// <param name="min_generation">The first generation of singleton to show [Default: none].</param>
        /// <param name="max_generation">The last generation of the singleton to show [Default: none].</param>
        /// <param name="num_results">The number of results to show [Default: show all results].</param>
        public DlHistory_RPC(string launcher_id, ulong? min_generation = null, ulong? max_generation = null, ulong? num_results = null)
        {
            this.launcher_id = launcher_id;
            this.min_generation = min_generation;
            this.max_generation = max_generation;
            this.num_results = num_results;
        }

        /// <summary>
        /// The launcher ID of the DataLayer wallet.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? launcher_id { get; set; }

        /// <summary>
        /// The first generation of singleton to show [Default: none].
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_generation { get; set; }

        /// <summary>
        /// The last generation of the singleton to show [Default: none].
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_generation { get; set; }

        /// <summary>
        /// The number of results to show [Default: show all results].
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? num_results { get; set; }
    }

}
