using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Add a new URI to the location URI list
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_add_uri"/></remarks>
    /// <returns><see cref="General_NS.SpendBundle_Response"/></returns>
    public class NftAddURI_RPC : RPCTemplate<NftAddURI_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public NftAddURI_RPC() { /* for serialisation */ }
        /// <summary>
        /// Add a new URI to the location URI list
        /// </summary>
        /// <param name="wallet_id">The Wallet ID of the DID wallet to transfer</param>
        /// <param name="nft_coin_id">The coin ID of the NFT on which to add a URI</param>
        /// <param name="key">Key must be either "u" (data URI), "mu" (metadata URI), or "lu" (license URI)</param>
        /// <param name="uri">The URI to add</param>
        /// <param name="fee">The one-time blockchain fee (in mojos) to be used upon adding a URI</param>
        /// <param name="reuse_puzhash">If true, will not generate a new puzzle hash / address for this transaction only. </param>
        public NftAddURI_RPC(ulong wallet_id, string nft_coin_id, string key, string uri, ulong? fee = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.nft_coin_id = nft_coin_id;
            this.key = key;
            this.uri = uri;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// The Wallet ID of the DID wallet to transfer
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The coin ID of the NFT on which to add a URI
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string nft_coin_id { get; set; }

        /// <summary>
        /// Key must be either "u" (data URI), "mu" (metadata URI), or "lu" (license URI)
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string key { get; set; }

        /// <summary>
        /// The URI to add
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string uri { get; set; }

        /// <summary>
        /// The one-time blockchain fee (in mojos) to be used upon adding a URI
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }

        /// <summary>
        /// If true, will not generate a new puzzle hash / address for this transaction only. 
        /// Note that setting this parameter to true will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
