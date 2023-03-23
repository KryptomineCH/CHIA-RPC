using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT_NS
{
    /// <summary>
    /// Bulk transfer NFTs to an address.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_transfer_bulk"/></remarks>
    /// <returns><see cref="General_NS.SpendBundle_MultiWallet_Response"/></returns>
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

        /// <summary>
        /// Optionally: If true, will not generate a new puzzle hash / address for this transaction only. 
        /// Note that setting this parameter to true will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
