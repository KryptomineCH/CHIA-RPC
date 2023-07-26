using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC.Wallet_NS.NFT_NS;
using CHIA_RPC.Wallet_NS.PoolWallet_NS;

namespace CHIA_RPC.Wallet_NS.WalletManagement_NS
{
    /// <summary>
    /// This class represents the response to the creation of a new wallet for various purposes like CATs, DIDs, NFTs, or pooling.
    /// </summary>
    /// <remarks>
    /// This response is obtained from the following methods:
    /// <list type="bullet">
    /// <item>
    /// <term><see cref="CreateNewCatWallet_RPC"/></term>
    /// <description>Used to create a new Coloured Coin (CAT) wallet.</description>
    /// </item>
    /// <item>
    /// <term><see cref="CreateNewNFTWallet_RPC"/></term>
    /// <description>Used to create a new Non-Fungible Token (NFT) wallet.</description>
    /// </item>
    /// <item>
    /// <term><see cref="CreateNewPoolWallet_RPC"/></term>
    /// <description>Used to create a new Pool wallet for participating in Chia pooling.</description>
    /// </item>
    /// </list>
    /// For more details, see: <see href="https://docs.chia.net/wallet-rpc#create_new_wallet"/>.
    /// </remarks>
    public class CreateNewWallet_Response : ResponseTemplate<CreateNewWallet_Response>
    {
        /// <summary>
        /// The unique identifier for the newly created asset, which can be a CAT, DID, NFT, or pool.
        /// </summary>
        /// <remarks>This identifier can be used for referencing the asset within the Chia network.</remarks>
        public string? asset_id { get; set; }

        /// <summary>
        /// The type of the wallet that has been created.
        /// </summary>
        /// <remarks>This value could represent a CAT, DID, NFT, or pool wallet type.</remarks>
        public WalletType? type { get; set; }

        /// <summary>
        /// The unique identifier for the newly created wallet.
        /// </summary>
        /// <remarks>This identifier is used to perform actions like sending or receiving transactions on behalf of the wallet.</remarks>
        public ulong? wallet_id { get; set; }
    }

}
