using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.WalletManagement_NS
{
    /// <summary>
    /// Create a new wallet for CATs, DIDs, NFTs, or pooling
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#create_new_wallet"/><br/><br/>
    /// Uses:<br/>
    /// <see cref="CreateNewCatWallet_RPC"/><br/>
    /// <see cref="CreateNewNFTWallet_RPC"/><br/>
    /// <see cref="CreateNewPoolWallet_RPC"/><br/>
    /// </remarks>
    public class CreateNewWallet_Response : ResponseTemplate<CreateNewWallet_Response>
    {
        public string asset_id { get; set; }
        public WalletType type { get; set; }
        public ulong wallet_id { get; set; }
    }
}
