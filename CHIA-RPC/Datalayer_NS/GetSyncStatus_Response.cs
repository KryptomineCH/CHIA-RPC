using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Obtain the current sync status for a provided data store
    /// </summary>
    public class GetSyncStatus_Response : ResponseTemplate<GetSyncStatus_Response>
    {
        /// <summary>
        /// The current sync status
        /// </summary>
        public DataStoreSyncStatus sync_status { get; set; }
    }

    /// <summary>
    /// The current sync status
    /// </summary>
    public class DataStoreSyncStatus
    {
        /// <summary>
        /// The current generation number
        /// </summary>
        public ulong generation { get; set; }

        /// <summary>
        /// The root hash of the current generation
        /// </summary>
        public string root_hash { get; set; }

        /// <summary>
        /// The target generation number
        /// </summary>
        public ulong target_generation { get; set; }

        /// <summary>
        /// The root hash of the target generation
        /// </summary>
        public string target_root_hash { get; set; }
    }
}