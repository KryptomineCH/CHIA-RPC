using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.WalletManagement_NS
{
    /// <summary>
    /// Modifies the data of a cat wallet
    /// </summary>
    /// <remarks>the cat wallet must exist already</remarks>
    public class ModifyCatWallet_RPC : RPCTemplate<ModifyCatWallet_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public ModifyCatWallet_RPC() { /* for serialisation */ }
        /// <summary>
        /// Modifies the data of a cat wallet
        /// </summary>
        /// <param name="name">The name of the wallet to create or modify [Default: CAT followed by the beginning of the CAT ID]</param>
        /// <param name="asset_id">*Required if mode is new. Specify the value, in mojos, of this wallet</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public ModifyCatWallet_RPC(string name, string asset_id, ulong fee)
        {
            this.name = name;
            this.asset_id = asset_id;
            this.fee = fee;
        }

        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string wallet_type { get; set; } = "cat_wallet";
        /// <summary>
        /// Must be either new of existing
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string mode { get; set; } = "existing";
        /// <summary>
        /// The name of the wallet to create or modify [Default: CAT followed by the beginning of the CAT ID]
        /// </summary>
        /// <remarks>optional</remarks>
        public string? name { get; set; }
        /// <summary>
        /// *Required if mode is new. Specify the value, in mojos, of this wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string? asset_id { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}
