using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get a history of root hashes for a Store ID that you subscribe to
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_root_history"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.ID_RPC"/>
    /// </remarks>
    public class GetRootHistory_Response : ResponseTemplate<GetRootHistory_Response>
    {
        /// <summary>
        /// List of root hashes for the Store ID
        /// </summary>
        public RootHash[] root_history { get; set; }
    }
}
