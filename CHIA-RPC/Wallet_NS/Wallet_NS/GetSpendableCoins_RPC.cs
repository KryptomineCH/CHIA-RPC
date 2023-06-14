using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;
using CHIA_RPC.General_NS;

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
        /// <param name="min_coin_amount_mojo">The smallest coin to be selected in this query[Default: No minimum]</param>
        /// <param name="max_coin_amount_mojo">The largest coin to be selected in this query[Default: No maximum]</param>
        /// <param name="excluded_coin_amounts_mojo">A list of coin amounts to exclude</param>
        /// <param name="excluded_coins">A list of coins to exclude</param>
        /// <param name="excluded_coin_ids">A list of coin IDs to exclude</param>
        public GetSpendableCoins_RPC(ulong wallet_id, ulong? min_coin_amount_mojo = null, ulong? max_coin_amount_mojo = null, 
            ulong[]? excluded_coin_amounts_mojo = null, string[]? excluded_coins = null, string[]? excluded_coin_ids = null)
        {
            this.wallet_id = wallet_id;
            this.min_coin_amount = min_coin_amount_mojo;
            this.max_coin_amount = max_coin_amount_mojo;
            this.excluded_coin_amounts = excluded_coin_amounts_mojo;
            this.excluded_coins = excluded_coins;
            this.excluded_coin_ids = excluded_coin_ids;
        }
        /// <summary>
        /// Get all spendable coins, with various possible filters
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet from which to display coins</param>
        /// <param name="min_coin_amount_mojo">The smallest coin to be selected in this query[Default: No minimum]</param>
        /// <param name="max_coin_amount_mojo">The largest coin to be selected in this query[Default: No maximum]</param>
        /// <param name="excluded_coin_amounts_mojo">A list of coin amounts to exclude</param>
        /// <param name="excluded_coins">A list of coins to exclude</param>
        /// <param name="excluded_coin_ids">A list of coin IDs to exclude</param>
        public GetSpendableCoins_RPC(WalletID_RPC wallet_id, ulong? min_coin_amount_mojo = null, ulong? max_coin_amount_mojo = null,
            ulong[]? excluded_coin_amounts_mojo = null, string[]? excluded_coins = null, string[]? excluded_coin_ids = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.min_coin_amount = min_coin_amount_mojo;
            this.max_coin_amount = max_coin_amount_mojo;
            this.excluded_coin_amounts = excluded_coin_amounts_mojo;
            this.excluded_coins = excluded_coins;
            this.excluded_coin_ids = excluded_coin_ids;
        }
        /// <summary>
        /// Get all spendable coins, with various possible filters
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet from which to display coins</param>
        /// <param name="min_coin_amount_xch">The smallest coin to be selected in this query[Default: No minimum]</param>
        /// <param name="max_coin_amount_xch">The largest coin to be selected in this query[Default: No maximum]</param>
        /// <param name="excluded_coin_amounts_xch">A list of coin amounts to exclude</param>
        /// <param name="excluded_coins">A list of coins to exclude</param>
        /// <param name="excluded_coin_ids">A list of coin IDs to exclude</param>
        public GetSpendableCoins_RPC(ulong wallet_id, decimal? min_coin_amount_xch = null, decimal? max_coin_amount_xch = null,
            decimal[]? excluded_coin_amounts_xch = null, string[]? excluded_coins = null, string[]? excluded_coin_ids = null)
        {
            this.wallet_id = wallet_id;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.excluded_coin_amounts_in_xch = excluded_coin_amounts_xch;
            this.excluded_coins = excluded_coins;
            this.excluded_coin_ids = excluded_coin_ids;
        }
        /// <summary>
        /// Get all spendable coins, with various possible filters
        /// </summary>
        /// <param name="wallet_id">The ID of the wallet from which to display coins</param>
        /// <param name="min_coin_amount_xch">The smallest coin to be selected in this query[Default: No minimum]</param>
        /// <param name="max_coin_amount_xch">The largest coin to be selected in this query[Default: No maximum]</param>
        /// <param name="excluded_coin_amounts_xch">A list of coin amounts to exclude</param>
        /// <param name="excluded_coins">A list of coins to exclude</param>
        /// <param name="excluded_coin_ids">A list of coin IDs to exclude</param>
        public GetSpendableCoins_RPC(WalletID_RPC wallet_id, decimal? min_coin_amount_xch = null, decimal? max_coin_amount_xch = null,
            decimal[]? excluded_coin_amounts_xch = null, string[]? excluded_coins = null, string[]? excluded_coin_ids = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.min_coin_amount_in_xch = min_coin_amount_xch;
            this.max_coin_amount_in_xch = max_coin_amount_xch;
            this.excluded_coin_amounts_in_xch = excluded_coin_amounts_xch;
            this.excluded_coins = excluded_coins;
            this.excluded_coin_ids = excluded_coin_ids;
        }

        /// <summary>
        /// The ID of the wallet from which to display coins
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The smallest coin (mojos) to be selected in this query[Default: No minimum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// The smallest coin (xch) to be selected in this query[Default: No minimum]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? min_coin_amount_in_xch
        {
            get { return min_coin_amount / GlobalVar.OneChiaInMojos; }
            set { min_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// The largest coin (mojos) to be selected in this query[Default: No maximum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; }
        /// <summary>
        /// The largest coin (xch) to be selected in this query[Default: No maximum]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? max_coin_amount_in_xch
        {
            get { return max_coin_amount / GlobalVar.OneChiaInMojos; }
            set { max_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// A list of coin amounts (mojos) to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong[]? excluded_coin_amounts { get; set; }
        /// <summary>
        /// A list of coin amounts (xch) to exclude
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
                if (value == null) excluded_coin_amounts = null;
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
        /// <summary>
        /// A list of coin IDs to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? excluded_coin_ids { get; set; }
    }
}
