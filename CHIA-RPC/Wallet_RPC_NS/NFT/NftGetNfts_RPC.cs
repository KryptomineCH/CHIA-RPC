using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftGetNfts_Response
    {
        public Nft[] nft_list { get; set; }
        /// <summary>
        /// the wallet which this nft belongs to
        /// </summary>
        public int wallet_id { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
