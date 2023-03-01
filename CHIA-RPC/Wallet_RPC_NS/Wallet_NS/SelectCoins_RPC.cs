using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.ComponentModel.DataAnnotations;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class SelectCoins_Response : ResponseTemplate<SelectCoins_Response>
    {
        public Coin[] coins { get; set; }
    }
    public class SelectCoins_RPC : RPCTemplate<SelectCoins_RPC>
    {
        /// <summary>
        /// The ID of the wallet from which to select coins
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The number of mojos to select
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong amount { get; set; }
        /// <summary>
        /// The smallest coin to be selected in this query [Default: No minimum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong min_coin_amount { get; set; }
        /// <summary>
        /// The largest coin to be selected in this query [Default: No maximum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong max_coin_amount { get; set; }
    }
}
