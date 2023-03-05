using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT_NS
{
    /// <summary>
    /// Bulk transfer NFTs to an address.
    /// </summary>
    public class NftTransferBulk_RPC : RPCTemplate<NftTransferBulk_RPC>
    {
        /// <summary>
        /// A list of coin IDs corresponding to the NFTs, along with the current wallet_ids. 
        /// </summary>
        public NftCoinIdAndWalletId[] nft_coin_list { get; set; }
        /// <summary>
        /// The address to which to transfer the NFTs
        /// </summary>
        public string target_address { get; set; }
        /// <summary>
        /// An optional blockchain fee.
        /// </summary>
        public ulong? fee { get; set; }
    }
}
