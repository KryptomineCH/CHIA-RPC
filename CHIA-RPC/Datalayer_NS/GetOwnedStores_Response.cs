using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// List the id (store_id) of each data_store owned by this wallet
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_owned_stores"/><br/><br/>
    /// Uses:<br/>the request has no parameters
    /// </remarks>
    public class GetOwnedStores_Response : ResponseTemplate<GetOwnedStores_Response>
    {
        /// <summary>
        /// The created Data Store ID
        /// </summary>
        public string[] store_ids { get; set; }
    }
}
