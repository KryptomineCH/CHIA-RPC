﻿using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_RPC_NS.WalletManagement_NS;

namespace CHIA_RPC.Wallet_RPC_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Create a new wallet for CATs
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#create_new_wallet"/></remarks>
    /// <returns><see cref="CreateNewWallet_Response"/></returns>
    public class CreateNewCatWallet_RPC : RPCTemplate<CreateNewCatWallet_RPC>
    {
        public CreateNewCatWallet_RPC()
        {
            wallet_type = "cat_wallet";
            mode = "new";
        }
        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string wallet_type { get; set; }
        /// <summary>
        /// Must be either new of existing
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string mode { get; set; }
        /// <summary>
        /// The name of the wallet to create or modify [Default: CAT followed by the beginning of the CAT ID]
        /// </summary>
        /// <remarks>optional</remarks>
        public string name { get; set; }
        /// <summary>
        /// *Required if mode is new. Specify the value, in mojos, of this wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong amount { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong fee { get; set; }
    }
}