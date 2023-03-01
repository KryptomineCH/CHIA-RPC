using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftCalculateRoyalties_Response : ResponseTemplate<NftCalculateRoyalties_Response>
    {
        /// <summary>
        /// Dictionary to hold key-value pairs where key is the NFT coin id, and value is list of TradeData
        /// </summary>
        public Dictionary<string, List<TradeData>> NFTTrade { get; set; }
    }
    public class NftCalculateRoyalties_RPC : RPCTemplate<NftCalculateRoyalties_RPC>
    {
        /// <summary>
        /// A list of NFTs for which to calculate royalties
        /// </summary>
        public List<RoyaltyAsset> royalty_assets { get; set; }

        /// <summary>
        /// The assets against which to calculate royalties
        /// </summary>
        public List<FungibleAsset> fungible_assets { get; set; }
    }
}
