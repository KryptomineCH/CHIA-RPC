using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    /// <summary>
    /// Fetch the metadata for a given wallet
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_get_metadata"/><br/><br/>
    /// uses:<br/> <see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class DidGetMetadata_Response : ResponseTemplate<DidGetMetadata_Response>
    {
        /// <summary>
        /// the metadata of the did wallet
        /// </summary>
        public Dictionary<string,object> metadata { get; set; }
        /// <summary>
        /// The wallet ID for which the request was
        /// </summary>
        public ulong wallet_id { get; set; }
    }
}
