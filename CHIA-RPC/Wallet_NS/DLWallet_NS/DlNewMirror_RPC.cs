using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

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
        public Transaction_DictMemos[]? transactions { get; set; }
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
        /// <param name="amount_mojos">The value of the mirror (in mojos) to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized</param>
        /// <param name="fee_mojos">An optional blockchain fee, in mojos</param>
        public DlNewMirror_RPC(string launcher_id, string[] urls, ulong amount_mojos, ulong? fee_mojos = null)
        {
            this.launcher_id = launcher_id;
            this.urls = urls;
            this.amount = amount_mojos;
            this.fee = fee_mojos;
        }
        /// <summary>
        /// Add a new on chain message for a specific singleton
        /// </summary>
        /// <param name="launcher_id">The launcher ID of the DataLayer wallet</param>
        /// <param name="urls">A list of URLs to be used for the mirror</param>
        /// <param name="amount_xch">The value of the mirror (in xch) to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized</param>
        /// <param name="fee_xch">An optional blockchain fee, in xch</param>
        public DlNewMirror_RPC(string launcher_id, string[] urls, decimal amount_xch, decimal? fee_xch = null)
        {
            this.launcher_id = launcher_id;
            this.urls = urls;
            this.amount_in_xch = amount_xch;
            this.fee_in_xch = fee_xch;
        }

        /// <summary>
        /// The launcher ID of the DataLayer wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? launcher_id { get; set; }

        /// <summary>
        /// A list of URLs to be used for the mirror
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[]? urls { get; set; }

        /// <summary>
        /// The value of the mirror (in mojos) to spend to create the mirror. In theory, mirrors with a higher amount will be prioritized
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong amount { get; set; }
        /// <summary>
        /// the transaction amount in xch
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
        /// <summary>
        /// the transaction fee in xch
        /// </summary>
        /// <remarks>This value is derived from the mojos fee_amount</remarks>
        [JsonIgnore]
        public decimal? fee_in_xch
        {
            get { return fee / GlobalVar.OneChiaInMojos; }
            set { fee = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
    }
}
