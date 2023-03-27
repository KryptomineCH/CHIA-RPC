using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS
{
    /// <summary>
    /// Represents the response for the dl_new_mirror command.
    /// This command adds a new on chain message for a specific singleton.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#dl_new_mirror"/><br/><br/>
    /// Uses:<br/><see cref="DlNewMirror_RPC"/>
    /// </remarks>
    public class DlNewMirror_Response : ResponseTemplate<DlNewMirror_Response>
    {
        /// <summary>
        /// An array of transactions returned in the response.
        /// </summary>
        public Transaction[] transactions { get; set; }
    }
    /// <summary>
    /// Add a new on chain message for a specific singleton
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#dl_new_mirror"/></remarks>
    /// <returns><see cref="DlNewMirror_Response"/></returns>
    public class DlNewMirror_RPC : RPCTemplate<DlNewMirror_RPC>
    {
        /// <summary>
        /// The launcher ID of the DataLayer wallet
        /// </summary>
        public string launcher_id { get; init; }

        /// <summary>
        /// A list of URLs to be used for the mirror
        /// </summary>
        public string[] urls { get; init; }

        /// <summary>
        /// The value of the mirror (in mojos) to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized
        /// </summary>
        public ulong amount { get; init; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong? fee { get; init; }
    }
}
