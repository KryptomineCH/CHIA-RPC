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
        /// Gets or sets the count of NFTs in the wallet.
        /// </summary>
        public ulong count { get; set; }

        /// <summary>
        /// Gets or sets the wallet ID. It is nullable.
        /// </summary>
        public ulong? wallet_id { get; set; }
    }
}
