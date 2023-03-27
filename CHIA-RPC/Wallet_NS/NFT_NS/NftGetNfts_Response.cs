using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Show all NFTs in a given wallet
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/nft-rpc#nft_get_nfts"/><br/><br/>
    /// Uses:<br/><see cref="NftGetNfts_RPC"/>
    /// </remarks>
    public class NftGetNfts_Response : ResponseTemplate<NftGetNfts_Response>
    {
        public Nft[] nft_list { get; set; }
        /// <summary>
        /// the wallet which this nft belongs to
        /// </summary>
        public ulong wallet_id { get; set; }
    }
    /// <summary>
    /// Show all NFTs in a given wallet
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_get_nfts"/></remarks>
    public class NftGetNfts_RPC : RPCTemplate<NftGetNfts_RPC>
    {
        /// <summary>
        /// The Wallet ID from which to retrieve the NFTs
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The NFT index at which to start retrieving the NFTs [Default: 0]
        /// </summary>
        public ulong? start_index { get; set; }

        /// <summary>
        /// The maximum number of NFTs to retrieve [Default: 0]
        /// </summary>
        public ulong? num { get; set; }

        /// <summary>
        /// Set to True to ignore the size limit when retrieving NFTs [Default: False]
        /// </summary>
        public bool? ignore_size_limit { get; set; }
    }
}
