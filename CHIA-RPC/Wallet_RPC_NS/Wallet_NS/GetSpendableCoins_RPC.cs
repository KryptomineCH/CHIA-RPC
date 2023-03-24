using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
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
