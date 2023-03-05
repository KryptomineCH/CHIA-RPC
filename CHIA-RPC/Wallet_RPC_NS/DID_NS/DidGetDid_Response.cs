using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    /// <summary>
    /// Fetch the my_did and coin_id (if applicable) settings for a given wallet
    /// </summary>
    /// <remarks>
    /// requires a wallet ID rpc
    /// </remarks>
    public class DidGetDid_Response : ResponseTemplate<DidGetDid_Response>
    {
        /// <summary>
        /// the coin which is associated with the did wallet
        /// </summary>
        public string coin_id { get; set; }
        /// <summary>
        /// the did_id of the wallet
        /// </summary>
        public string my_did { get; set; }
        /// <summary>
        /// The wallet idwhich the did was requested for
        /// </summary>
        public ulong wallet_id { get; set; }
    }
}
