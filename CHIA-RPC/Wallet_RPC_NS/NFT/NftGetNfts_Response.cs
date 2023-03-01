using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftGetNfts_Response : ResponseTemplate<NftGetNfts_Response>
    {
        public Nft[] nft_list { get; set; }
        /// <summary>
        /// the wallet which this nft belongs to
        /// </summary>
        public ulong wallet_id { get; set; }
    }
}
