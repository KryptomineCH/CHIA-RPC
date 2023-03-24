using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DLWallet_NS.DLWalletObjects_NS
{
    /// <summary>
    /// Represents a mirror in the response.
    /// </summary>
    public class Mirror : ObjectTemplate<Mirror>
    {
        /// <summary>
        /// The amount associated with the mirror.
        /// </summary>
        public ulong amount { get; set; }

        /// <summary>
        /// The coin ID associated with the mirror.
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// The launcher ID associated with the mirror.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// Indicates if the mirror is owned by us.
        /// </summary>
        public bool ours { get; set; }

        /// <summary>
        /// An array of URLs associated with the mirror.
        /// </summary>
        public string[] urls { get; set; }
    }
}
