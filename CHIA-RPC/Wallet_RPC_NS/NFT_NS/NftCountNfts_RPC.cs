using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT_NS
{
    /// <summary>
    /// A class representing the response for the NFT count in a wallet.
    /// </summary>
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
    /// <summary>
    /// NftCountNfts_RPC is a class for serializing and deserializing the JSON RPC request
    /// for counting the number of NFTs in a wallet.
    /// </summary>
    public class NftCountNfts_RPC : RPCTemplate<NftCountNfts_RPC>
    {
        /// <summary>
        /// Gets or sets the wallet_id property, representing the ID of the wallet in which to count NFTs.
        /// If not provided, the default value is null (count all NFTs).
        /// </summary>
        public ulong? wallet_id { get; set; }
    }
}
