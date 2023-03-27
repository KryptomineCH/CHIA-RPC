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
        /// The Wallet ID of the DID wallet to transfer
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The coin ID of the NFT on which to add a URI
        /// </summary>
        public string nft_coin_id { get; set; }

        /// <summary>
        /// Key must be either "u" (data URI), "mu" (metadata URI), or "lu" (license URI)
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// The URI to add
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// The one-time blockchain fee (in mojos) to be used upon adding a URI
        /// </summary>
        public ulong? fee { get; set; }

        /// <summary>
        /// If true, will not generate a new puzzle hash / address for this transaction only. 
        /// Note that setting this parameter to true will override the global default setting from config.yaml
        /// </summary>
        public bool? reuse_puzhash { get; set; }
    }
}
