using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// coins from a given wallet that add up to at least the specified amount
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#select_coins"/><br/><br/>
    /// Uses:<br/><see cref="SelectCoins_RPC"/>
    /// </remarks>
    public class SelectCoins_Response : ResponseTemplate<SelectCoins_Response>
    {
        public Coin[] coins { get; set; }
    }
    /// <summary>
    /// Select coins from a given wallet that add up to at least the specified amount
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#select_coins"/></remarks>
    /// <returns><see cref="SelectCoins_Response"/></returns>
    public class SelectCoins_RPC : RPCTemplate<SelectCoins_RPC>
    {
        /// <summary>
        /// The ID of the wallet from which to select coins
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The number of mojos to select
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong amount { get; set; }
        /// <summary>
        /// The smallest coin to be selected in this query [Default: No minimum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// The largest coin to be selected in this query [Default: No maximum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; }
        /// <summary>
        /// A list of coin amounts to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong[]? excluded_coin_amounts { get; set; }
        /// <summary>
        /// A list of coins to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? excluded_coins { get; set; }
    }
}
