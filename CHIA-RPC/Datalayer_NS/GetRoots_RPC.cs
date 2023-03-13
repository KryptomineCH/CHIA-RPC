using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Get the root hashes and timestamps from a list of stores.
    /// Note that an invalid hash will be returned for remote stores. Use get_local_root instead
    /// </summary>
    public class GetRoots_Response : ResponseTemplate<GetRoots_Response>
    {
        /// <summary>
        /// A list of root hashes and timestamps
        /// </summary>
        public RootHash[] root_hashes { get; set; }
    }

    /// <summary>
    /// Represents a root hash and timestamp
    /// </summary>
    public class RootHash
    {
        /// <summary>
        /// Whether or not the hash is confirmed
        /// </summary>
        public bool confirmed { get; set; }

        /// <summary>
        /// The root hash
        /// </summary>
        public string hash { get; set; }

        /// <summary>
        /// The store ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The timestamp
        /// </summary>
        public ulong timestamp { get; set; }
    }
    /// <summary>
    /// Represents a request to get the root hashes and timestamps from a list of stores.
    /// Note that an invalid hash will be returned for remote stores. Use get_local_root instead.
    /// </summary>
    public class GetRoots_RPC : RPCTemplate<GetRoots_RPC>
    {
        /// <summary>
        /// A list of hexadecimal store IDs
        /// </summary>
        public string[] ids { get; set; }
    }
}
