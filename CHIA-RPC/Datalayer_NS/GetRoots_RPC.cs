using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get the root hashes and timestamps from a list of stores.
    /// Note that an invalid hash will be returned for remote stores. Use get_local_root instead
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_roots"/><br/><br/>
    /// Uses:<br/><see cref="GetRoots_RPC"/>
    /// </remarks>
    public class GetRoots_Response : ResponseTemplate<GetRoots_Response>
    {
        /// <summary>
        /// A list of root hashes and timestamps
        /// </summary>
        public RootHash[] root_hashes { get; set; }
    }

    /// <summary>
    /// Represents a request to get the root hashes and timestamps from a list of stores.
    /// Note that an invalid hash will be returned for remote stores. Use get_local_root instead.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#get_roots"/></remarks>
    /// <returns><see cref="GetRoots_Response"/></returns>
    public class GetRoots_RPC : RPCTemplate<GetRoots_RPC>
    {
        /// <summary>
        /// A list of hexadecimal store IDs
        /// </summary>
        public string[] ids { get; set; }
    }
}
