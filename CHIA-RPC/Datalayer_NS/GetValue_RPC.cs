using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Given a key and the data store in which the key is located, return corresponding value
    /// </summary>
    public class GetValue_Response : ResponseTemplate<GetValue_Response>
    {
        /// <summary>
        /// The value for the requested datastore key
        /// </summary>
        /// <remarks>encoded as hexadecimal string</remarks>
        public string value { get; set; }
    }
    /// <summary>
    /// Given a key and the data store in which the key is located, return corresponding value
    /// </summary>
    public class GetValue_RPC : RPCTemplate<GetValue_RPC>
    {
        /// <summary>
        /// the hexadecimal data store id which to fetch a value from
        /// </summary>
        /// <remarks>encoded as hexadecimal string</remarks>
        public string id { get; set; }
        /// <summary>
        /// the hexadecimal key of the dictionary to look up
        /// </summary>
        /// <remarks>encoded as hexadecimal string</remarks>
        public string key { get; set; }
    }
}
