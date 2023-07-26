using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get the root hash and timestamp of a store ID. Can be used for either owned or subscribed stores
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_local_root"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.ID_RPC"/>
    /// </remarks>
    public class GetLocalRoot_Response : ResponseTemplate<GetLocalRoot_Response>
    {
        /// <summary>
        /// The hexadecimal root hash
        /// </summary>
        public string? hash { get; set; }
    }
}
