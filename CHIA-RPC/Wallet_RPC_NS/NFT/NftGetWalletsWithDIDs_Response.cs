using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftGetWalletsWithDIDs_Response : ResponseTemplate<NftGetWalletsWithDIDs_Response>
    {
        NftWallet[] nft_wallets { get; set; }
    }
}
