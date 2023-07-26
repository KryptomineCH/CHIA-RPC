using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Bulk transfer NFTs to an address.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_transfer_bulk"/></remarks>
    /// <returns><see cref="General_NS.SpendBundle_MultiWallet_Response"/></returns>
    public class NftTransferBulk_RPC : RPCTemplate<NftTransferBulk_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public NftTransferBulk_RPC() { /* for serialisation */ }
        /// <summary>
        /// Bulk transfer NFTs to an address.
        /// </summary>
        /// <param name="nft_coin_list">A list of coin IDs corresponding to the NFTs, along with the current wallet_ids. </param>
        /// <param name="target_address">The address to which to transfer the NFTs</param>
        /// <param name="fee">An optional blockchain fee.</param>
        /// <param name="reuse_puzhash">Optionally: If true, will not generate a new puzzle hash / address for this transaction only</param>
        public NftTransferBulk_RPC(NftCoinIdAndWalletId[] nft_coin_list, string target_address, ulong? fee = null, bool? reuse_puzhash = null)
        {
            this.nft_coin_list = nft_coin_list;
            this.target_address = target_address;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// A list of coin IDs corresponding to the NFTs, along with the current wallet_ids. 
        /// </summary>
        /// <remarks>mandatory</remarks>
        public NftCoinIdAndWalletId[]? nft_coin_list { get; set; }

        /// <summary>
        /// The address to which to transfer the NFTs
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? target_address { get; set; }

        /// <summary>
        /// An optional blockchain fee.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }

        /// <summary>
        /// Optionally: If true, will not generate a new puzzle hash / address for this transaction only. 
        /// Note that setting this parameter to true will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
