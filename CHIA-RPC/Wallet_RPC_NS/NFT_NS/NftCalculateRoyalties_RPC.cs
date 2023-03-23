using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT_NS
{
    /// <summary>
    /// Calculates the correct royalty payments for given one or more NFTs to be exchanged for one or more fungible assets.<br/>
    /// - If more than one NFT is being traded, the royalties will be divided by the number of NFTs.<br/>
    /// - If the NFTs are being traded for more than one fungible asset, then the royalties will be calculated for each asset individually.<br/>
    /// - If multiple NFTs are being traded for multiple fungible assets, then both of the above rules will be applied.<br/>
    /// - When NFTs are traded for other NFTs, no royalties are exchanged.<br/>
    /// Although this RPC has multiple required parameters, the royalty_percentage and amount are the only values used in these calculations.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/nft-rpc#nft_calculate_royalties"/><br/><br/>
    /// Uses:<br/><see cref="NftCalculateRoyalties_Response"/>
    /// </remarks>
    public class NftCalculateRoyalties_Response : ResponseTemplate<NftCalculateRoyalties_Response>
    {
        /// <summary>
        /// Dictionary to hold key-value pairs where key is the NFT coin id, and value is list of TradeData
        /// </summary>
        public Dictionary<string, TradeData[]> NFTTrade { get; set; }
    }
    /// <summary>
    /// Calculates the correct royalty payments for given one or more NFTs to be exchanged for one or more fungible assets.<br/>
    /// - If more than one NFT is being traded, the royalties will be divided by the number of NFTs.<br/>
    /// - If the NFTs are being traded for more than one fungible asset, then the royalties will be calculated for each asset individually.<br/>
    /// - If multiple NFTs are being traded for multiple fungible assets, then both of the above rules will be applied.<br/>
    /// - When NFTs are traded for other NFTs, no royalties are exchanged.<br/>
    /// Although this RPC has multiple required parameters, the royalty_percentage and amount are the only values used in these calculations.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_calculate_royalties"/></remarks>
    /// <returns><see cref="NftCalculateRoyalties_Response"/></returns>
    public class NftCalculateRoyalties_RPC : RPCTemplate<NftCalculateRoyalties_RPC>
    {
        /// <summary>
        /// A list of NFTs for which to calculate royalties.
        /// If this parameter is not included, then nothing will be returned.
        /// </summary>
        public RoyaltyAsset[] royalty_assets { get; set; }

        /// <summary>
        /// The assets against which to calculate royalties.
        /// If this parameter is not included, no royalties will be returned.
        /// Note that no royalties are calculated for NFT:NFT trades, so NFT assets should not be included here.
        /// </summary>
        public FungibleAsset[] fungible_assets { get; set; }
    }
}
