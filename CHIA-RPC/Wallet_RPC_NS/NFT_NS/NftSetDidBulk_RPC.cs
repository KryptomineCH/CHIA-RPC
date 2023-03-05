using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT_NS
{
    /// <summary>
    /// Bulk set DID for NFTs across different wallets.
    /// </summary>
    /// <remarks>
    /// returns a SpendBundle response
    /// </remarks>
    public class NftSetDidBulk_RPC : RPCTemplate<NftSetDidBulk_RPC>
    {
        /// <summary>
        /// A list of coin IDs corresponding to the NFTs, along with the current wallet_ids. 
        /// </summary>
        public NftCoinIdAndWalletId[] nft_coin_list { get; set; }
        /// <summary>
        /// The ID of the DID to which to transfer the NFTs. [Default: no DID (reset the NFTs' DIDs)]
        /// </summary>
        public string did_id { get; set; }
        /// <summary>
        /// An optional blockchain fee.
        /// </summary>
        public ulong? fee { get; set; }
    }
}
