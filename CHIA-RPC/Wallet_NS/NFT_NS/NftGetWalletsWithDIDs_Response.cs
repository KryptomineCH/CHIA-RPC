using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Show all NFT wallets that are associated with DIDs
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/nft-rpc#nft_get_wallets_with_dids"/><br/><br/>
    /// Uses:<br/>This request has no parameters
    /// </remarks>
    public class NftGetWalletsWithDIDs_Response : ResponseTemplate<NftGetWalletsWithDIDs_Response>
    {
        NftWallet[] nft_wallets { get; set; }
    }
}
