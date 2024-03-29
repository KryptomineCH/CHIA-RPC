﻿using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;
using CHIA_RPC.General_NS;
using System.Runtime.CompilerServices;
using CHIA_RPC.Wallet_NS.WalletManagement_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// All spendable coins, with various possible filters
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#get_spendable_coins"/><br/><br/>
    /// Uses:<br/><see cref="GetSpendableCoins_RPC"/><br/><br/>
    /// The 'GetSpendableCoins' method is used to retrieve the coins that are currently spendable by the wallet, both confirmed and unconfirmed.
    /// The confirmed coins are ones that have been included in the blockchain and can be spent without any restrictions.
    /// The unconfirmed coins are ones that have been recently received or sent but not yet included in the blockchain. 
    /// Their spendability depends on the transaction they are a part of being confirmed.
    /// </remarks>
    public class GetSpendableCoins_Response : ResponseTemplate<GetSpendableCoins_Response>
    {
        /// <summary>
        /// An array of CoinRecord objects representing the confirmed coins.
        /// These are coins that have been included in the blockchain and are spendable without any restrictions.
        /// Each CoinRecord includes details such as the coin's parent coin info, puzzle hash, amount, and more.
        /// </summary>
        public CoinRecord[]? confirmed_records { get; set; }

        /// <summary>
        /// An array of Coin objects representing unconfirmed additions to the wallet.
        /// These are coins that have been recently received but have not yet been included in the blockchain.
        /// Their spendability depends on the transaction they are a part of being confirmed.
        /// Each Coin includes details such as the coin's parent coin info, puzzle hash, and amount.
        /// </summary>
        public Coin[]? unconfirmed_additions { get; set; }

        /// <summary>
        /// An array of CoinRecord objects representing unconfirmed removals from the wallet.
        /// These are coins that have been recently sent but the transaction has not yet been included in the blockchain.
        /// If the transaction is not confirmed, these coins may still be spendable by the wallet.
        /// Each CoinRecord includes details such as the coin's parent coin info, puzzle hash, amount, and more.
        /// </summary>
        public CoinRecord[]? unconfirmed_removals { get; set; }

        /// <summary>
        /// This Function extracts the Coins from confirmed_records and lets you choose to sort them in ascending or descending order by amount
        /// </summary>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public Coin[] GetSortedCoins(bool ascending = true)
        {
            if (confirmed_records == null)
                return Array.Empty<Coin>();

            var sortedCoins = confirmed_records
                .Select(record => record.coin);

            return ascending ?
                sortedCoins.OrderBy(coin => coin.amount).ToArray() :
                sortedCoins.OrderByDescending(coin => coin.amount).ToArray();
        }
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
        /// <summary>
        /// A list of coin IDs to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? excluded_coin_ids { get; set; }

        public static implicit operator GetSpendableCoins_RPC(WalletID_RPC rpc)
        {
            return new GetSpendableCoins_RPC(rpc, null);
        }
        public static implicit operator GetSpendableCoins_RPC(Wallets_info rpc)
        {
            return new GetSpendableCoins_RPC(rpc.id, null);
        }
    }
}
