using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    /// <summary>
    /// a did wallet is a digital identity
    /// </summary>
    public class CreateNewDIDWallet_RPC : RPCTemplate<CreateNewDIDWallet_RPC>
    {
        public CreateNewDIDWallet_RPC()
        {
            wallet_type = "did_wallet";
            did_type = "new";
        }
        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string wallet_type { get; set; }
        /// <summary>
        /// Must be either new or recovery. If recovery, then each of the following parameters will be ignored
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string did_type { get; set; }
        /// <summary>
        /// TThe name of the DID wallet [Default: None]
        /// </summary>
        /// <remarks>optional</remarks>
        public string wallet_name { get; set; }
        /// <summary>
        /// *Required if mode is new. Specify the value, in mojos, of this wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong amount { get; set; }
        /// <summary>
        /// *Required if did_type is new. An array of backup DID IDs to be used for recovery. Must match actual DIDs
        /// </summary>
        public string[] backup_dids { get; set; }
        /// <summary>
        /// *Required if did_type is new. The number of backup DIDs required for recovery. Minimum value is 1, maximum value is the number of DIDs in backup_dids
        /// </summary>
        public ulong num_of_backup_ids_needed { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong fee { get; set; }
    }
}
