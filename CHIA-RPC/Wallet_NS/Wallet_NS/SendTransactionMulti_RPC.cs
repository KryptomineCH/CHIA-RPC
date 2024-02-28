
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// Class representing a JSON RPC request for the send_transaction_multi method.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#send_transaction_multi"/></remarks>
    public class SendTransactionMulti_RPC : RPCTemplate<SendTransactionMulti_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public SendTransactionMulti_RPC() { /* for serrialisation */ }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wallet_id">the wallet id on which the transaction is to take place</param>
        /// <param name="recipients">the recipient adresses of coins</param>
        /// <param name="inputCoins">the coins to be consumed (optional)</param>
        /// <param name="fee_mojos">the fee to pay</param>
        /// <param name="memos">memos to add</param>
        /// <param name="min_coin_amount">the minimum coin size to select from the wallet</param>
        /// <param name="max_coin_amount">the largest coin size to be allowed for selection</param>
        /// <param name="exclude_coin_amounts"></param>
        /// <param name="exclude_coin_ids">coins to exclude from the selection</param>
        /// <param name="reuse_puzhash">recommended to set to false</param>
        public SendTransactionMulti_RPC(
            ulong wallet_id,
            MultiTransactionRecipient[] recipients, 
            Coin[]? inputCoins = null,
            ulong? fee_mojos = null, string[]? memos = null, ulong? min_coin_amount = null,
            ulong? max_coin_amount = null, ulong[]? exclude_coin_amounts = null,
            string? exclude_coin_ids = null, bool? reuse_puzhash = false)
        {
            this.wallet_id = wallet_id;
            this.fee = fee_mojos;
            this.memos = memos;
            this.additions = recipients;
            this.coins = inputCoins;
            this.min_coin_amount = min_coin_amount;
            this.max_coin_amount = max_coin_amount;
            this.exclude_coin_amounts = exclude_coin_amounts;
            this.reuse_puzhash=reuse_puzhash;

        }

        private ulong? _wallet_id;
        /// <summary>
        /// The wallet ID for the origin of the transaction.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public ulong? wallet_id
        {
            get { return _wallet_id; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("wallet_id must be greater than 0");
                }
                _wallet_id = value;
            }
        }

        /// <summary>
        /// An optional blockchain fee, in mojos.
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

        public bool push { get; set; }

        /// <summary>
        /// An optional array of memos to be sent with the transaction.
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? memos { get; set; }

        /// <summary>
        /// A list of puzzle hashes and amounts to be created.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public MultiTransactionRecipient[] additions { get; set; }

        /// <summary>
        /// A list of puzzle hashes and amounts to be consumed.
        /// </summary>
        /// <remarks>mantatory</remarks>
        public Coin[]? coins { get; set; }

        /// <summary>
        /// The minimum coin amount in mojos to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? min_coin_amount { get; set; }
        /// <summary>
        /// The minimum coin amount in xch to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? min_coin_amount_in_xch
        {
            get { return min_coin_amount / GlobalVar.OneChiaInMojos; }
            set { min_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// The maximum coin amount in mojos to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_coin_amount { get; set; } = 0;
        /// <summary>
        /// The maximum coin amount in xch to send [Default: 0]
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? max_coin_amount_in_xch
        {
            get { return max_coin_amount / GlobalVar.OneChiaInMojos; }
            set { max_coin_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// A list of coin amounts (in mojos) to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong[]? exclude_coin_amounts { get; set; }
        /// <summary>
        /// A list of coin amounts (in xch) to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal[]? exclude_coin_amounts_in_xch
        {
            get
            {
                if (exclude_coin_amounts == null) return null;
                decimal[] ex = new decimal[exclude_coin_amounts.Length];
                for (int i = 0; i < exclude_coin_amounts.Length; i++) ex[i] = (exclude_coin_amounts[i] / GlobalVar.OneChiaInMojos);
                return ex;
            }
            set
            {
                if (value == null)
                {
                    exclude_coin_amounts = null;
                    return;
                }
                ulong[] ex = new ulong[value.Length];
                for (int i = 0; i < value.Length; i++) ex[i] = (ulong)(value[i] * GlobalVar.OneChiaInMojos);
                exclude_coin_amounts = ex;
            }
        }
        /// <summary>
        /// A list of coin IDs to exclude
        /// </summary>
        /// <remarks>optional</remarks>
        public string? exclude_coin_ids { get; set; }
        /// <summary>
        /// If true, will not generate a new puzzle hash / address for this transaction only. 
        /// Note that setting this parameter to true will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
    public struct MultiTransactionRecipient
    {
        public MultiTransactionRecipient(ulong amount, string targetAddress)
        {
            this.amount = amount;
            this.puzzle_hash = Bech32M.AddressToPuzzleHashString(targetAddress);
        }

        /// <summary>
        /// Represents the transaction value in mojos, where: <br/>
        /// - 1 Chia = 1e12 mojos. <see cref="GlobalVar.OneChiaInMojos"/><br/>
        /// - 1 Ct = 1000 mojos. <see cref="GlobalVar.OneCatInMojos"/><br/>
        /// </summary>
        /// <remarks>
        /// This property is marks the amount which should be sent to the recipient address
        /// </remarks>
        public ulong? amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
            }
        }
        private ulong? _amount; // Backing field

        /// <summary>
        /// Represents the transaction value in Chia (XCH).
        /// </summary>
        /// <remarks>This value is derived from the mojos amount.</remarks>
        [JsonIgnore]
        public decimal? amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// Represents the transaction value in a CAT token.
        /// </summary>
        /// <remarks>This value is derived from the mojos amount.</remarks>
        [JsonIgnore]
        public decimal? amount_in_cat
        {
            get { return amount / GlobalVar.OneCatInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneCatInMojos); }
        }
        /// <summary>
        /// The puzzle hash of the recipiet address.
        /// </summary>
        /// <remarks>
        /// can be obtained with <see cref="CHIA_RPC.HelperFunctions_NS.Bech32M.AddressToPuzzleHashString"/>
        /// </remarks>
        public string? puzzle_hash { get; set; }
        
    }
}
