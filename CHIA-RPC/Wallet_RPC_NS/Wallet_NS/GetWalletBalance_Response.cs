using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
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
        public WalletBalanceInfo wallet_balance { get; set; }
    }
    public class WalletBalanceInfo
    {
        /// <summary>
        /// the confirmed wallet balance, which represents the total balance available for spending, in mojo.
        /// </summary>
        public ulong confirmed_wallet_balance { get; set; }

        /// <summary>
        /// the fingerprint, which is a unique identifier for the wallet (usually the first 4 bytes of the public key).
        /// </summary>
        public ulong fingerprint { get; set; }

        /// <summary>
        /// The maximum amount of Chia that can be sent in a single transaction, in mojo.
        /// </summary>
        public ulong max_send_amount { get; set; }

        /// <summary>
        /// The amount of pending change, which represents the unconfirmed balance that will be available for spending once confirmed, in mojo.
        /// </summary>
        public ulong pending_change { get; set; }

        /// <summary>
        /// The count of pending coin removals, which represent the number of unconfirmed transactions that will reduce the wallet balance.
        /// </summary>
        public ulong pending_coin_removal_count { get; set; }

        /// <summary>
        /// The spendable balance, which represents the total balance available for spending without waiting for any pending transactions, in mojo.
        /// </summary>
        public ulong spendable_balance { get; set; }

        /// <summary>
        /// The unconfirmed wallet balance, which represents the total balance including both confirmed and unconfirmed transactions, in mojo.
        /// </summary>
        public ulong unconfirmed_wallet_balance { get; set; }

        /// <summary>
        /// The count of unspent coins, which represent the number of individual coin records that contribute to the wallet's total balance.
        /// </summary>
        public ulong unspent_coin_count { get; set; }

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
