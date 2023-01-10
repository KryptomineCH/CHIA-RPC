using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftGetWalletsWithDIDs_Response
    {
        NftWallet[] nft_wallets { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
