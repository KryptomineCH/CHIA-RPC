using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Obtain the current sync status for a provided data store
    /// </summary>
    /// <remarks>
    /// request uses a <see cref="General_NS.ID_RPC"/><br/>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_sync_status"/>
    /// </remarks>
    public class GetSyncStatus_Response : ResponseTemplate<GetSyncStatus_Response>
    {
        /// <summary>
        /// The current sync status
        /// </summary>
        public DataStoreSyncStatus sync_status { get; set; }
    }
}