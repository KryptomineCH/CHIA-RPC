using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    public class DidGetDid_Response : ResponseTemplate<DidGetDid_Response>
    {
        public string coin_id { get; set; }
        /// <summary>
        /// the did_id of the wallet
        /// </summary>
        public string my_did { get; set; }
        public ulong wallet_id { get; set; }
    }
}
