using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS
{
    /// <summary>
    /// The lineage proof of a singleton
    /// </summary>
    public class LineageProof : ObjectTemplate<LineageProof>
    {
        /// <summary>
        /// The amount (mojos) of the lineage proof
        /// </summary>
        public ulong? amount { get; set; }
        /// <summary>
        /// the lineage proof amount in full chia
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal? amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// The inner puzzle hash of the lineage proof
        /// </summary>
        public string? inner_puzzle_hash { get; set; }

        /// <summary>
        /// The parent name of the lineage proof
        /// </summary>
        public string? parent_name { get; set; }
    }
}
