using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// List the id (store_id) of each data_store owned by this wallet
    /// </summary>
    /// <remarks>
    /// the rpc does not take any parameters
    /// </remarks>
    public class GetOwnedStores_Response : ResponseTemplate<GetOwnedStores_Response>
    {
        /// <summary>
        /// The created Data Store ID
        /// </summary>
        public string[] store_ids { get; set; }
    }
}
