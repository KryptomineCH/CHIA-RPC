using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// Obtain the balance (and related info) from a wallet
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_wallet_balance"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class GetWalletBalance_Response : ResponseTemplate<GetWalletBalance_Response>
    {
        /// <summary>
        /// Contains infomation about the wallet
        /// </summary>
        public WalletBalanceInfo? wallet_balance { get; set; }
    }
    /// <summary>
    /// <see href="https://docs.chia.net/wallet-rpc#get_wallet_balance"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.WalletID_RPC"/>
    /// </summary>
    public class WalletBalanceInfo
    {
        /// <summary>
        /// represents the total balance (mojos) which is in the wallet *right now*, <br/>
        /// </summary>
        public ulong confirmed_wallet_balance { get; set; }
        /// <summary>
        /// represents the total balance (xch) which is in the wallet *right now*, <br/>
        /// </summary>
        [JsonIgnore]
        public decimal confirmed_wallet_balance_in_xch 
        {
            get { return (confirmed_wallet_balance / GlobalVar.OneChiaInMojos); }
            set { confirmed_wallet_balance = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// the fingerprint, which is a unique identifier for the wallet (usually the first 4 bytes of the public key).
        /// </summary>
        public ulong fingerprint { get; set; }

        /// <summary>
        /// The maximum amount of mojos that can be sent in a single transaction.
        /// </summary>
        /// <remarks>
        /// `in a single transaction` is important because small dust coins might consume a lot of space in a transaction block.<br/>
        /// -> max_send_amount equates to the largest transaction you can make with your balance that still fits in one transaction block.
        /// </remarks>
        public ulong max_send_amount { get; set; }
        /// <summary>
        /// The maximum amount of xch that can be sent in a single transaction.
        /// </summary>
        /// <remarks>
        /// `in a single transaction` is important because small dust coins might consume a lot of space in a transaction block.<br/>
        /// -> max_send_amount equates to the largest transaction you can make with your balance that still fits in one transaction block.
        /// </remarks>
        [JsonIgnore]
        public decimal max_send_amount_in_xch
        {
            get { return (max_send_amount / GlobalVar.OneChiaInMojos); }
            set { max_send_amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// The amount of pending change (mojos), which representsthe balance change when all pending transactions are completed.<br/>
        /// might also be related to the "locked" balance (?)
        /// </summary>
        /// <remarks>
        /// this might be confusing.<br/>
        /// Lets say you have one coin with worth of 10 xch and you send 1 xch. The pending change is 10 xch. Why?<br/>
        /// the 10xch coin is splitted in two:<br/>
        /// - 1xch coin which you send out<br/>
        /// - 9xch coin which you send to yourself
        /// </remarks>
        public ulong pending_change { get; set; }
        /// <summary>
        /// The amount of pending change (xch), which representsthe balance change when all pending transactions are completed.<br/>
        /// might also be related to the "locked" balance (?)
        /// </summary>
        /// <remarks>
        /// this might be confusing.<br/>
        /// Lets say you have one coin with worth of 10 xch and you send 1 xch. The pending change is 10 xch. Why?<br/>
        /// the 10xch coin is splitted in two:<br/>
        /// - 1xch coin which you send out<br/>
        /// - 9xch coin which you send to yourself
        /// </remarks>
        [JsonIgnore]
        public decimal pending_change_in_xch
        {
            get { return (pending_change / GlobalVar.OneChiaInMojos); }
            set { pending_change = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// The count of pending coin removals (mojos), which represent the number of unconfirmed transactions that will reduce the wallet balance.
        /// </summary>
        public ulong pending_coin_removal_count { get; set; }
        /// <summary>
        /// The count of pending coin removals (xch), which represent the number of unconfirmed transactions that will reduce the wallet balance.
        /// </summary>
        [JsonIgnore]
        public decimal pending_coin_removal_count_in_xch
        {
            get { return (pending_coin_removal_count / GlobalVar.OneChiaInMojos); }
            set { pending_coin_removal_count = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// The spendable balance (mojos), which represents the total balance available for spending without waiting for any pending transactions, in mojo.
        /// </summary>
        /// <remarks>
        /// it is recommended to use <see cref="max_send_amount"/> for calculations since this is the maximum value that can be sent in one transaction (fits one block) whereas
        /// <see cref="spendable_balance"/> is the maximum amount free for spending (in multiple transactions)<br/>
        /// This is related to small/dust coins which might fill one block
        /// </remarks>
        public ulong spendable_balance { get; set; }
        /// <summary>
        /// The spendable balance (xch), which represents the total balance available for spending without waiting for any pending transactions, in xch.
        /// </summary>
        /// <remarks>
        /// it is recommended to use <see cref="max_send_amount"/> for calculations since this is the maximum value that can be sent in one transaction (fits one block) whereas
        /// <see cref="spendable_balance"/> is the maximum amount free for spending (in multiple transactions)<br/>
        /// This is related to small/dust coins which might fill one block
        /// </remarks>
        [JsonIgnore]
        public decimal spendable_balance_in_xch
        {
            get { return (spendable_balance / GlobalVar.OneChiaInMojos); }
            set { spendable_balance = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// represents the presumed total balance (mojos) which is in the wallet, including unconfirmed transactions<br/>
        /// in other words: <br/>
        /// confirmed_wallet_balance + pending incoming transactions - pending outgoing transactions<br/><br/>
        /// in mojo.
        /// </summary>
        public ulong unconfirmed_wallet_balance { get; set; }
        /// <summary>
        /// represents the presumed total balance (xch) which is in the wallet, including unconfirmed transactions<br/>
        /// in other words: <br/>
        /// confirmed_wallet_balance + pending incoming transactions - pending outgoing transactions<br/><br/>
        /// in ych.
        /// </summary>
        [JsonIgnore]
        public decimal unconfirmed_wallet_balance_in_xch
        {
            get { return (unconfirmed_wallet_balance / GlobalVar.OneChiaInMojos); }
            set { unconfirmed_wallet_balance = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// The count of unspent coins (mojos), which represent the number of individual coin records that contribute to the wallet's total balance.
        /// </summary>
        /// <remarks>
        /// this has nothing to do with cats/tokens/currencies it rather represents unit packets of a given currency. 
        /// (as if you have many coins of one currency in your wallet)
        /// </remarks>
        public ulong unspent_coin_count { get; set; }
        /// <summary>
        /// The count of unspent coins (xch), which represent the number of individual coin records that contribute to the wallet's total balance.
        /// </summary>
        /// <remarks>
        /// this has nothing to do with cats/tokens/currencies it rather represents unit packets of a given currency. 
        /// (as if you have many coins of one currency in your wallet)
        /// </remarks>
        [JsonIgnore]
        public decimal unspent_coin_count_in_xch
        {
            get { return (unspent_coin_count / GlobalVar.OneChiaInMojos); }
            set { unspent_coin_count = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// The Wallet ID, which is a local unique identifier for wallets associated to one fingerprint. Primary (XCH) wallet should have the ID 1
        /// </summary>
        /// <remarks>The wallet id is not a sufficient identifier without specifying the fingerprint. 
        /// For most RPC requests, when leaving empty, the currently logged in Fingerprint is assumed.
        /// </remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// Gets or sets the wallet type, which indicates the type of wallet (e.g., standard, nft, did, ...).
        /// </summary>
        public WalletType wallet_type { get; set; }
    }
}
