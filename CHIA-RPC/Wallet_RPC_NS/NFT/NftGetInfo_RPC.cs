using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftGetInfo_Response : ResponseTemplate<NftGetInfo_Response>
    {
        public Nft nft_info { get; set; }
    }
    public class NftGetInfo_RPC : RPCTemplate<NftGetInfo_RPC>
    {
        /// <summary>
        /// The coin ID of the NFT about which to retrieve info
        /// </summary>
        /// <remarks>eg: 0x821fdd13fe209466f1c69d82eb951cf630d28e901c2e14285d8a574dbde034c4</remarks>
        public string coin_id { get; set; }

        /// <summary>
        /// The Wallet ID of the NFT from which to retrieve info
        /// </summary>
        public ulong wallet_id { get; set; }
    }
}
