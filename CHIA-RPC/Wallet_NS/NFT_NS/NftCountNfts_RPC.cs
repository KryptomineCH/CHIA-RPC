using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// A class representing the response for the NFT count in a wallet.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/nft-rpc#nft_count_nfts"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class NftCountNfts_Response : ResponseTemplate<NftCountNfts_Response>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public NftCountNfts_Response() { /* for serialisation */ }
        /// <summary>
        /// A class representing the response for the NFT count in a wallet.
        /// </summary>
        /// <param name="count">Gets or sets the count of NFTs in the wallet.</param>
        /// <param name="wallet_id">Gets or sets the wallet ID. It is nullable.</param>
        public NftCountNfts_Response(ulong count, ulong? wallet_id)
        {
            this.count = count;
            this.wallet_id = wallet_id;
        }


        /// <summary>
        /// Gets or sets the count of NFTs in the wallet.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong count { get; set; }

        /// <summary>
        /// Gets or sets the wallet ID. It is nullable.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? wallet_id { get; set; }
    }
}
