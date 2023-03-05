namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// The nft_coin_id and wallet_id of an NFT
    /// </summary>
    public class NftCoinIdAndWalletId
    {
        /// <summary>
        /// The ID of the NFT coin.
        /// </summary>
        public string nft_coin_id { get; set; }
        /// <summary>
        /// The ID of the wallet containing the NFT.
        /// </summary>
        public ulong wallet_id { get; set; }
    }
}
