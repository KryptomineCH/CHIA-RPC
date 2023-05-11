using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get the root hash and timestamp of a given store ID. <br/>
    /// If it is a subscribed store, this command will return an invalid hash (see example).<br/>
    /// In this case, use <see cref="GetLocalRoot_Response"/> instead
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_root"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.ID_RPC"/>
    /// </remarks>
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
