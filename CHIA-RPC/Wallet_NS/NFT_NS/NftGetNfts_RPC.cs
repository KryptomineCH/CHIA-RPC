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
        /// <summary>
        /// a list containing the nft informations according to the Filter
        /// </summary>
        public Nft[]? nft_list { get; set; }
        /// <summary>
        /// the wallet which this nft belongs to
        /// </summary>
        public ulong? wallet_id { get; set; }
    }
    /// <summary>
    /// Show all NFTs in a given wallet
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_get_nfts"/></remarks>
    public class NftGetNfts_RPC : RPCTemplate<NftGetNfts_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public NftGetNfts_RPC() { /* for serialisation */ }
        /// <summary>
        /// Show all NFTs in a given wallet
        /// </summary>
        /// <param name="wallet_id">The Wallet ID from which to retrieve the NFTs</param>
        /// <param name="start_index">The NFT index at which to start retrieving the NFTs [Default: 0]</param>
        /// <param name="num">The maximum number of NFTs to retrieve [Default: 0]</param>
        /// <param name="ignore_size_limit">Set to True to ignore the size limit when retrieving NFTs [Default: False]</param>
        public NftGetNfts_RPC(ulong wallet_id, ulong? start_index = null, ulong? num = null, bool? ignore_size_limit = null)
        {
            this.wallet_id = wallet_id;
            this.start_index = start_index;
            this.num = num;
            this.ignore_size_limit = ignore_size_limit;
        }


        /// <summary>
        /// The Wallet ID from which to retrieve the NFTs
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong? wallet_id { get; set; }

        /// <summary>
        /// The NFT index at which to start retrieving the NFTs [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? start_index { get; set; }

        /// <summary>
        /// The maximum number of NFTs to retrieve [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? num { get; set; }

        /// <summary>
        /// Set to True to ignore the size limit when retrieving NFTs [Default: False]
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? ignore_size_limit { get; set; }
    }
}
