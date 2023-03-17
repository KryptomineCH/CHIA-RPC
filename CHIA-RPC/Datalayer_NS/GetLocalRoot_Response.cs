using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get the root hash and timestamp of a store ID. Can be used for either local or remote stores
    /// </summary>
    /// <remarks>
    /// request uses an <see cref="General_NS.ID_RPC"/><br/>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_local_root"/>
    /// </remarks>
    public class GetLocalRoot_Response : ResponseTemplate<GetLocalRoot_Response>
    {
        /// <summary>
        /// The hexadecimal root hash
        /// </summary>
        public string hash { get; set; }
    }
}
