using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.WalletManagement_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Create a new wallet for CATs
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#create_new_wallet"/></remarks>
    /// <returns><see cref="CreateNewWallet_Response"/></returns>
    public class CreateNewCatWallet_RPC : RPCTemplate<CreateNewCatWallet_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CreateNewCatWallet_RPC() { /* for serialisation */ }

        /// <summary>
        /// Create a new wallet for CATs
        /// </summary>
        /// <param name="amount">Specify the value, in mojos, of this wallet</param>
        /// <param name="name">The name of the wallet to create or modify [Default: CAT followed by the beginning of the CAT ID]</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public CreateNewCatWallet_RPC(ulong amount = 1, string? name = null,  ulong? fee = null)
        {
            this.name = name;
            this.amount = amount;
            this.fee = fee;
        }

        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string wallet_type { get; set; } = "cat_wallet";
        /// <summary>
        /// Must be either new of existing
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string mode { get; set; } = "new";
        /// <summary>
        /// The name of the wallet to create or modify [Default: CAT followed by the beginning of the CAT ID]
        /// </summary>
        /// <remarks>optional</remarks>
        public string? name { get; set; }
        /// <summary>
        /// *Required if mode is new. Specify the value, in mojos, of this wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong amount { get; set; } = 1;
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}
