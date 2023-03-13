using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get a history of root hashes for a Store ID that you subscribe to
    /// </summary>
    /// <remarks>Requires an ID_RPC</remarks>
    public class GetRootHistory_Response : ResponseTemplate<GetRootHistory_Response>
    {
        /// <summary>
        /// List of root hashes for the Store ID
        /// </summary>
        public RootHash[] root_history { get; set; }
    }

    /// <summary>
    /// Root hash object containing the root hash, timestamp and confirmation status
    /// </summary>
    public class RootHash
    {
        /// <summary>
        /// Confirmation status
        /// </summary>
        public bool confirmed { get; set; }

        /// <summary>
        /// Root hash value
        /// </summary>
        public string root_hash { get; set; }

        /// <summary>
        /// Timestamp of root hash
        /// </summary>
        public ulong timestamp { get; set; }
    }
}
