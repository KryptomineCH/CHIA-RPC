using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Represents the server response for get_kv_diff
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_kv_diff"/><br/><br/>
    /// Uses:<br/><see cref="GetKvDiff_RPC"/>
    /// </remarks>
    public class GetKvDiff_Response : ResponseTemplate<GetKvDiff_Response>
    {
        /// <summary>
        /// The kv diff between two hashes within the same store ID
        /// </summary>
        public Diff[] diff { get; set; }
    }

    /// <summary>
    /// Represents a kv diff entry
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc/#get_kv_diff"/></remarks>
    public class Diff
    {
        /// <summary>
        /// The key of the kv pair
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// The type of operation
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// The value of the kv pair
        /// </summary>
        public string value { get; set; }
    }

    /// <summary>
    /// Get the kv diff between two hashes within the same store ID
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc/#get_kv_diff"/></remarks>
    /// <returns><see cref="GetKvDiff_Response"/></returns>
    public class GetKvDiff_RPC : RPCTemplate<GetKvDiff_RPC>
    {
        /// <summary>
        /// The hexadecimal store ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The first hash to compare
        /// </summary>
        public string hash_1 { get; set; }

        /// <summary>
        /// The second hash to compare
        /// </summary>
        public string hash_2 { get; set; }
    }

}
