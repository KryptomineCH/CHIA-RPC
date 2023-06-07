using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// All spendable coins, with various possible filters
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#get_spendable_coins"/><br/><br/>
    /// Uses:<br/><see cref="GetSpendableCoins_RPC"/>
    /// </remarks>
    public class GetSpendableCoins_Response : ResponseTemplate<GetSpendableCoins_Response>
    {

        public CoinRecord[] confirmed_records { get; set; }
        
        public Coin[] unconfirmed_additions { get; set; }
        public CoinRecord[] unconfirmed_removals { get; set; }
    }
    /// <summary>
    /// Get all spendable coins, with various possible filters
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#get_spendable_coins"/></remarks>
    /// <returns><see cref="GetSpendableCoins_Response"/></returns>
    public class GetSpendableCoins_RPC : RPCTemplate<GetSpendableCoins_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public GetSpendableCoins_RPC() { /* for serialisation */ }
        /// <summary>
        /// Get all spendable coins, with various possible filters
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet from which to display coins</param>
        /// <param name="min_coin_amount">The smallest coin to be selected in this query[Default: No minimum]</param>
        /// <param name="max_coin_amount">The largest coin to be selected in this query[Default: No maximum]</param>
        /// <param name="excluded_coin_amounts">A list of coin amounts to exclude</param>
        /// <param name="excluded_coins">A list of coins to exclude</param>
        /// <param name="excluded_coin_ids">A list of coin IDs to exclude</param>
        public GetSpendableCoins_RPC(ulong wallet_id, ulong? min_coin_amount = null, ulong? max_coin_amount = null, 
            ulong[]? excluded_coin_amounts = null, string[]? excluded_coins = null, string[]? excluded_coin_ids = null)
        {
            this.wallet_id = wallet_id;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.excluded_coin_amounts = excluded_coin_amounts;
            this.excluded_coins = excluded_coins;
            this.excluded_coin_ids = excluded_coin_ids;
        }

        /// <summary>
        /// The ID of the wallet from which to display coins
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The smallest coin to be selected in this query[Default: No minimum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// The largest coin to be selected in this query[Default: No maximum]
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
        /// <summary>
        /// A list of coin IDs to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? excluded_coin_ids { get; set; }
    }
}
