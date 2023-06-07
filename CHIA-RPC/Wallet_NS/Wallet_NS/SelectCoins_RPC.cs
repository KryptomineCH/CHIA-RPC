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
        /// parameterless constructor, for serializer
        /// </summary>
        public SelectCoins_RPC() { /* for serialisation */ }
        /// <summary>
        /// Select coins from a given wallet that add up to at least the specified amount
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet from which to select coins</param>
        /// <param name="amount">The number of mojos to select</param>
        /// <param name="min_coin_amount">The smallest coin to be selected in this query [Default: No minimum]</param>
        /// <param name="max_coin_amount">The largest coin to be selected in this query [Default: No maximum]</param>
        /// <param name="excluded_coin_amounts">A list of coin amounts to exclude</param>
        /// <param name="excluded_coins">A list of coins to exclude</param>
        public SelectCoins_RPC(ulong wallet_id, ulong amount, ulong? min_coin_amount = null, ulong? max_coin_amount = null, ulong[]? excluded_coin_amounts = null, string[]? excluded_coins = null)
        {
            this.wallet_id = wallet_id;
            this.amount = amount;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.excluded_coin_amounts = excluded_coin_amounts;
            this.excluded_coins = excluded_coins;
        }

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
