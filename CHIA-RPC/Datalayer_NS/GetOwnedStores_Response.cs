using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using NFT.Storage.Net.ClientResponse;

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
        public string[]? store_ids { get; set; }
        /// <summary>
        /// converts this response to a ID_RPC
        /// </summary>
        /// <returns></returns>
        public ID_RPC GetID_RPC (int index = 0)
        {
            if (store_ids == null) throw new NullReferenceException("the response contains no store ids!");
            if (index > store_ids.Length) throw new IndexOutOfRangeException($"the requested index {index} is highes than the awailable ids {store_ids.Length}!");
            ID_RPC rpc = new ID_RPC(store_ids[index]);
            return rpc;
        }
        /// <summary>
        /// implicit conversion of the first store to ID RPC
        /// </summary>
        /// <param name="response"></param>
        public static implicit operator ID_RPC(GetOwnedStores_Response response)
        {
            return response.GetID_RPC();
        }
        /// <summary>
        /// converts this response to a GetRoots_RPC
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public GetRoots_RPC ToGetRoots_RPC()
        {
            if (store_ids == null)
            {
                throw new NullReferenceException(nameof(store_ids));
            }
            GetRoots_RPC rpc = new GetRoots_RPC()
            {
                ids = (string[])store_ids.Clone()
            };
            return rpc;
        }
        /// <summary>
        /// implicit conversion of to getRoots rpc
        /// </summary>
        /// <param name="response"></param>
        public static implicit operator GetRoots_RPC(GetOwnedStores_Response response)
        {
            return response.ToGetRoots_RPC();
        }
    }
}
