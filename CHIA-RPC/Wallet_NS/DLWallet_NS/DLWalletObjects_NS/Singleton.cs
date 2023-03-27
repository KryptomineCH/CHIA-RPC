using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS
{
    /// <summary>
    /// Information about the singleton record
    /// </summary>
    public class Singleton : ObjectTemplate<Singleton>
    {
        /// <summary>
        /// The coin ID of the singleton
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// Whether the singleton is confirmed or not
        /// </summary>
        public bool confirmed { get; set; }

        /// <summary>
        /// The height at which the singleton was confirmed
        /// </summary>
        public ulong confirmed_at_height { get; set; }

        /// <summary>
        /// The generation of the singleton
        /// </summary>
        public ulong generation { get; set; }

        /// <summary>
        /// The inner puzzle hash of the singleton
        /// </summary>
        public string inner_puzzle_hash { get; set; }

        /// <summary>
        /// The launcher ID of the DataLayer wallet
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// The lineage proof of the singleton
        /// </summary>
        public LineageProof lineage_proof { get; set; }

        /// <summary>
        /// The root hash of an existing data store
        /// </summary>
        public string root { get; set; }

        /// <summary>
        /// The timestamp of the singleton
        /// </summary>
        public ulong timestamp { get; set; }
    }
}
