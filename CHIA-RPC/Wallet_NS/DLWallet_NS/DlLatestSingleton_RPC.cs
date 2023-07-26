
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS
{
    /// <summary>
    /// Response object for dl_latest_singleton RPC request
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#dl_latest_singleton"/><br/><br/>
    /// Uses:<br/><see cref="DlLatestSingleton_RPC"/>
    /// </remarks>
    public class DlLatestSingleton_Response : ResponseTemplate<DlLatestSingleton_Response>
    {
        /// <summary>
        /// Information about the latest singleton of the given launcher ID
        /// </summary>
        public Singleton? singleton { get; set; } 
    }

    /// <summary>
    /// RPC request object for the "dl_latest_singleton" command.
    /// Get the singleton record for the latest singleton of a launcher ID.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#dl_latest_singleton"/></remarks>
    /// <returns><see cref="DlLatestSingleton_Response"/></returns>
    public class DlLatestSingleton_RPC : RPCTemplate<DlLatestSingleton_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public DlLatestSingleton_RPC() { /* for serialisation */ }
        /// <summary>
        /// RPC request object for the "dl_latest_singleton" command.
        /// </summary>
        /// <param name="launcher_id">The launcher ID of the DataLayer wallet.</param>
        /// <param name="only_confirmed">Only show the latest confirmed record. [Default: false]</param>
        public DlLatestSingleton_RPC(string launcher_id, bool? only_confirmed)
        {
            this.launcher_id = launcher_id;
            this.only_confirmed = only_confirmed;
        }

        /// <summary>
        /// The launcher ID of the DataLayer wallet.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? launcher_id { get; set; }

        /// <summary>
        /// Only show the latest confirmed record. [Default: false]
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? only_confirmed { get; set; }
    }

}
