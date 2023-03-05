using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT_NS
{
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
        public ulong fee { get; set; }
    }
}
