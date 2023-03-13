using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Represents the response to a request for a list of store IDs for current subscriptions.
    /// </summary>
    public class Subscriptions_Response : ResponseTemplate<Subscriptions_Response>
    {
        /// <summary>
        /// Gets or sets an array of store IDs for each current subscription.
        /// </summary>
        public string[] store_ids { get; set; }
    }
}
