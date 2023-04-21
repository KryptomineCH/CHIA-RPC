using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Fetch the my_did and coin_id for a given wallet
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_get_did"/><br/><br/>
    /// uses:<br/><see cref="General_NS.WalletID_RPC"/>
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
        /// The wallet id which the did was requested for
        /// </summary>
        public ulong wallet_id { get; set; }
        public DidGetInfo_RPC ToDidGetInfo_RPC()
        {
            return new DidGetInfo_RPC(coin_id);
        }
        public static implicit operator DidGetInfo_RPC(DidGetDid_Response response)
        {
            return response.ToDidGetInfo_RPC();
        }
    }
}
