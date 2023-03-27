using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS
{
    /// <summary>
    /// The lineage proof of a singleton
    /// </summary>
    public class LineageProof : ObjectTemplate<LineageProof>
    {
        /// <summary>
        /// The amount of the lineage proof
        /// </summary>
        public ulong amount { get; set; }

        /// <summary>
        /// The inner puzzle hash of the lineage proof
        /// </summary>
        public string inner_puzzle_hash { get; set; }

        /// <summary>
        /// The parent name of the lineage proof
        /// </summary>
        public string parent_name { get; set; }
    }
}
