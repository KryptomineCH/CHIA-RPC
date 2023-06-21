using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

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
        /// <param name="min_coin_amount">The smallest coin (mojos) to be selected in this query [Default: No minimum]</param>
        /// <param name="max_coin_amount">The largest coin (mojos) to be selected in this query [Default: No maximum]</param>
        /// <param name="excluded_coin_amounts">A list of coin amounts (mojos) to exclude</param>
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
        /// Select coins from a given wallet that add up to at least the specified amount
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet from which to select coins</param>
        /// <param name="amount">The number of mojos to select</param>
        /// <param name="min_coin_amount">The smallest coin (mojos) to be selected in this query [Default: No minimum]</param>
        /// <param name="max_coin_amount">The largest coin (mojos) to be selected in this query [Default: No maximum]</param>
        /// <param name="excluded_coin_amounts">A list of coin amounts (mojos) to exclude</param>
        /// <param name="excluded_coins">A list of coins to exclude</param>
        public SelectCoins_RPC(WalletID_RPC wallet_id, ulong amount, ulong? min_coin_amount = null, ulong? max_coin_amount = null, ulong[]? excluded_coin_amounts = null, string[]? excluded_coins = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.amount = amount;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.excluded_coin_amounts = excluded_coin_amounts;
            this.excluded_coins = excluded_coins;
        }
        /// <summary>
        /// Select coins from a given wallet that add up to at least the specified amount
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet from which to select coins</param>
        /// <param name="amount_xch">The amount of xch to select</param>
        /// <param name="min_coin_amount_xch">The smallest coin (xch) to be selected in this query [Default: No minimum]</param>
        /// <param name="max_coin_amount_xch">The largest coin (xch) to be selected in this query [Default: No maximum]</param>
        /// <param name="excluded_coin_amounts_xch">A list of coin amounts (xch) to exclude</param>
        /// <param name="excluded_coins">A list of coins to exclude</param>
        public SelectCoins_RPC(ulong wallet_id, decimal amount_xch, decimal? min_coin_amount_xch = null, decimal? max_coin_amount_xch = null, decimal[]? excluded_coin_amounts_xch = null, string[]? excluded_coins = null)
        {
            this.wallet_id = wallet_id;
            this.amount_in_xch = amount_xch;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.excluded_coin_amounts_in_xch = excluded_coin_amounts_xch;
            this.excluded_coins = excluded_coins;
        }
        /// <summary>
        /// Select coins from a given wallet that add up to at least the specified amount
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet from which to select coins</param>
        /// <param name="amount_xch">The amount of xch to select</param>
        /// <param name="min_coin_amount_xch">The smallest coin (xch) to be selected in this query [Default: No minimum]</param>
        /// <param name="max_coin_amount_xch">The largest coin (xch) to be selected in this query [Default: No maximum]</param>
        /// <param name="excluded_coin_amounts_xch">A list of coin amounts (xch) to exclude</param>
        /// <param name="excluded_coins">A list of coins to exclude</param>
        public SelectCoins_RPC(WalletID_RPC wallet_id, decimal amount_xch, decimal? min_coin_amount_xch = null, decimal? max_coin_amount_xch = null, decimal[]? excluded_coin_amounts_xch = null, string[]? excluded_coins = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.amount_in_xch = amount_xch;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.excluded_coin_amounts_in_xch = excluded_coin_amounts_xch;
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
        /// The amount of xch to select
        /// </summary>
        /// <remarks>mandatory</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// The smallest coin to be selected in this query [Default: No minimum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// The smallest coin to be selected in this query [Default: No minimum]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? min_coin_amount_in_xch
        {
            get { return min_coin_amount / GlobalVar.OneChiaInMojos; }
            set { min_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// The largest coin to be selected in this query [Default: No maximum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; }
        /// <summary>
        /// The largest coin to be selected in this query [Default: No maximum]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? max_coin_amount_in_xch
        {
            get { return max_coin_amount / GlobalVar.OneChiaInMojos; }
            set { max_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// A list of coin amounts to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong[]? excluded_coin_amounts { get; set; }
        /// <summary>
        /// A list of coin amounts to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal[]? excluded_coin_amounts_in_xch
        {
            get
            {
                if (excluded_coin_amounts == null) return null;
                decimal[] ex = new decimal[excluded_coin_amounts.Length];
                for (int i = 0; i < excluded_coin_amounts.Length; i++) ex[i] = (excluded_coin_amounts[i] / GlobalVar.OneChiaInMojos);
                return ex;
            }
            set
            {
                if (value == null)
                {
                    excluded_coin_amounts = null;
                    return;
                }
                ulong[] ex = new ulong[value.Length];
                for (int i = 0; i < value.Length; i++) ex[i] = (ulong)(value[i] * GlobalVar.OneChiaInMojos);
                excluded_coin_amounts = ex;
            }
        }
        /// <summary>
        /// A list of coins to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? excluded_coins { get; set; }
    }
}
