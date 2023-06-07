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
        public Transaction_DictMemos[] transactions { get; set; }
    }
    /// <summary>
    /// Add a new on chain message for a specific singleton
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#dl_new_mirror"/></remarks>
    /// <returns><see cref="DlNewMirror_Response"/></returns>
    public class DlNewMirror_RPC : RPCTemplate<DlNewMirror_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public DlNewMirror_RPC () { /* for serialisation */ }
        /// <summary>
        /// Add a new on chain message for a specific singleton
        /// </summary>
        /// <param name="launcher_id">The launcher ID of the DataLayer wallet</param>
        /// <param name="urls">A list of URLs to be used for the mirror</param>
        /// <param name="amount">The value of the mirror (in mojos) to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public DlNewMirror_RPC(string launcher_id, string[] urls, ulong amount, ulong? fee = null)
        {
            this.launcher_id = launcher_id;
            this.urls = urls;
            this.amount = amount;
            this.fee = fee;
        }

        /// <summary>
        /// The launcher ID of the DataLayer wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string launcher_id { get; init; }

        /// <summary>
        /// A list of URLs to be used for the mirror
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[] urls { get; init; }

        /// <summary>
        /// The value of the mirror (in mojos) to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong amount { get; init; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; init; }
    }
}
