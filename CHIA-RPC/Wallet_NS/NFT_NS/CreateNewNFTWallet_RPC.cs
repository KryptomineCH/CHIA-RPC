using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.WalletManagement_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Create a new wallet for NFTs
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#create_new_wallet"/></remarks>
    /// <returns><see cref="CreateNewWallet_Response"/></returns>
    public class CreateNewNFTWallet_RPC : RPCTemplate<CreateNewNFTWallet_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CreateNewNFTWallet_RPC() { /* for serialisation */ }
        /// <summary>
        /// Create a new wallet for NFTs
        /// </summary>
        /// <param name="wallet_type">The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet</param>
        /// <param name="name">The name of the wallet to create or modify [Default: CAT followed by the beginning of the CAT ID]</param>
        /// <param name="did_id">*Required if mode is new. Specify the value, in mojos, of this wallet</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public CreateNewNFTWallet_RPC(string wallet_type, string? name = null, string? did_id = null, ulong? fee = null)
        {
            this.wallet_type = wallet_type;
            this.name = name;
            this.did_id = did_id;
            this.fee = fee;
        }

        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string wallet_type { get; set; } = "nft_wallet";
        /// <summary>
        /// The name of the wallet to create or modify [Default: CAT followed by the beginning of the CAT ID]
        /// </summary>
        /// <remarks>optional</remarks>
        public string? name { get; set; }
        /// <summary>
        /// *Required if mode is new. Specify the value, in mojos, of this wallet
        /// </summary>
        /// <remarks>optional</remarks>
        public string? did_id { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}
