
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
        public Singleton singleton { get; set; } 
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
        /// The launcher ID of the DataLayer wallet.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// Only show the latest confirmed record. [Default: false]
        /// </summary>
        public bool? only_confirmed { get; set; }
    }

}
