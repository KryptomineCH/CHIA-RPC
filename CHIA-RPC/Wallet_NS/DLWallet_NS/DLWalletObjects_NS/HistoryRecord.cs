using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS
{
    /// <summary>
    /// A record of the history of a data store.
    /// </summary>
    public class HistoryRecord : ObjectTemplate<HistoryRecord>
    {
        /// <summary>
        /// The coin ID.
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// Whether the coin has been confirmed.
        /// </summary>
        public bool confirmed { get; set; }

        /// <summary>
        /// The height at which the coin was confirmed.
        /// </summary>
        public ulong? confirmed_at_height { get; set; }

        /// <summary>
        /// The generation of the record.
        /// </summary>
        public ulong? generation { get; set; }

        /// <summary>
        /// The inner puzzle hash of the coin.
        /// </summary>
        public string inner_puzzle_hash { get; set; }

        /// <summary>
        /// The launcher ID of the DataLayer wallet.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// The lineage proof of the coin.
        /// </summary>
        public LineageProof lineage_proof { get; set; }

        /// <summary>
        /// The root of the data store.
        /// </summary>
        public string root { get; set; }

        /// <summary>
        /// The timestamp of the record.
        /// </summary>
        public ulong? timestamp { get; set; }
    }
}
