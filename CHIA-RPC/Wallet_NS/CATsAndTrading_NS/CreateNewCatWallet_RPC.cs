using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CHIA_RPC.General_NS;
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
        /// <param name="amount_mojos">Specify the value, in mojos, of this wallet</param>
        /// <param name="name">The name of the wallet to create or modify [Default: CAT followed by the beginning of the CAT ID]</param>
        /// <param name="fee_mojos">An optional blockchain fee, in mojos</param>
        public CreateNewCatWallet_RPC(ulong amount_mojos = 1, string? name = null,  ulong? fee_mojos = null)
        {
            this.name = name;
            this.amount = amount_mojos;
            this.fee = fee_mojos;
        }
        /// <summary>
        /// Create a new wallet for CATs
        /// </summary>
        /// <param name="amount_xch">Specify the value, in mojos, of this wallet</param>
        /// <param name="name">The name of the wallet to create or modify [Default: CAT followed by the beginning of the CAT ID]</param>
        /// <param name="fee_xch">An optional blockchain fee, in mojos</param>
        public CreateNewCatWallet_RPC(decimal amount_xch = 1, string? name = null, decimal? fee_xch = null)
        {
            this.name = name;
            this.amount_in_xch = amount_xch;
            this.fee_in_xch = fee_xch;
        }

        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string wallet_type { get; set; } = "cat_wallet";
        /// <summary>
        /// Must be either new or existing
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
        /// the amount of xch to send
        /// </summary>
        /// <remarks>mandatory</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
        /// <summary>
        /// the amount of xch to set as fee
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? fee_in_xch
        {
            get { return fee / GlobalVar.OneChiaInMojos; }
            set { fee = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
    }
}
