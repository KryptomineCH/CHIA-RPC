using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// Root hash object containing the root hash, timestamp and confirmation status
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#get_root_history"/></remarks>
    public class RootHistoryEntry : ObjectTemplate<RootHistoryEntry>
    {
        /// <summary>
        /// Confirmation status
        /// </summary>
        public bool? confirmed { get; set; }

        /// <summary>
        /// Root hash value
        /// </summary>
        public string? root_hash { get; set; }

        /// <summary>
        /// Timestamp of root hash
        /// </summary>
        public ulong? timestamp { get; set; }
    }
}
