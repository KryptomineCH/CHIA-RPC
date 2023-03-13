using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get root hash and timestamp of a given store ID
    /// </summary>
    /// <remarks>uses an id rpc</remarks>
    public class GetRoot_Response : ResponseTemplate<GetRoot_Response>
    {
        /// <summary>
        /// Whether the root hash is confirmed
        /// </summary>
        public bool confirmed { get; set; }

        /// <summary>
        /// The hexadecimal root hash
        /// </summary>
        public string hash { get; set; }

        /// <summary>
        /// The timestamp of the root hash
        /// </summary>
        public ulong timestamp { get; set; }
    }
}
