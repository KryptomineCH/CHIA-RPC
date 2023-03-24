using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_RPC_NS.WalletManagement_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT_NS
{
    /// <summary>
    /// Create a new wallet for NFTs
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#create_new_wallet"/></remarks>
    /// <returns><see cref="CreateNewWallet_Response"/></returns>
    public class CreateNewNFTWallet_RPC : RPCTemplate<CreateNewNFTWallet_RPC>
    {
        public CreateNewNFTWallet_RPC()
        {
            wallet_type = "nft_wallet";
        }
        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string wallet_type { get; set; }
        /// <summary>
        /// The name of the wallet to create or modify [Default: CAT followed by the beginning of the CAT ID]
        /// </summary>
        /// <remarks>optional</remarks>
        public string name { get; set; }
        /// <summary>
        /// *Required if mode is new. Specify the value, in mojos, of this wallet
        /// </summary>
        /// <remarks>optional</remarks>
        public string did_id { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong fee { get; set; }
    }
}
