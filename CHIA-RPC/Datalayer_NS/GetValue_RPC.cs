using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Given a key and the data store in which the key is located, return corresponding value
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_value"/><br/><br/>
    /// Uses:<br/><see cref="GetValue_RPC"/>
    /// </remarks>
    public class GetValue_Response : ResponseTemplate<GetValue_Response>
    {
        /// <summary>
        /// The value for the requested datastore key
        /// </summary>
        /// <remarks>encoded as hexadecimal string</remarks>
        public string? value { get; set; }
    }
    /// <summary>
    /// Given a key and the data store in which the key is located, return corresponding value
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#get_value"/></remarks>
    /// <returns><see cref="GetValue_Response"/></returns>
    public class GetValue_RPC : RPCTemplate<GetValue_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public GetValue_RPC() { /* for serialisation */ }
        /// <summary>
        /// Given a key and the data store in which the key is located, return corresponding value
        /// </summary>
        /// <param name="id">The hexadecimal store ID</param>
        /// <param name="key">The hexadecimal key</param>
        /// <param name="root_hash">The root hash from which to obtain data</param>
        public GetValue_RPC(string id, string key, string? root_hash = null)
        {
            this.id = id;
            this.key = key;
            this.root_hash = root_hash;
        }

        /// <summary>
        /// the hexadecimal data store id which to fetch a value from
        /// </summary>
        /// <remarks>encoded as hexadecimal string<br/>
        /// mandatory</remarks>
        public string? id { get; set; }
        /// <summary>
        /// the hexadecimal key of the dictionary to look up
        /// </summary>
        /// <remarks>encoded as hexadecimal string<br/>
        /// mandatory</remarks>
        public string? key { get; set; }
        /// <summary>
        /// The root hash from which to obtain data
        /// </summary>
        /// <remarks>optional</remarks>
        public string? root_hash { get; set; }
    }
}
