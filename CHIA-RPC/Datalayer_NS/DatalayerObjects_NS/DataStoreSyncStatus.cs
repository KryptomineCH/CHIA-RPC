using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// The current sync status
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#get_sync_status"/></remarks>
    public class DataStoreSyncStatus : ObjectTemplate<DataStoreSyncStatus>
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
