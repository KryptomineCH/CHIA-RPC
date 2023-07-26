using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.WalletManagement_NS;

namespace CHIA_RPC.Wallet_NS.PoolWallet_NS
{
    /// <summary>
    /// Create a new wallet for pooling
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#create_new_wallet"/></remarks>
    /// <returns><see cref="CreateNewWallet_Response"/></returns>
    public class CreateNewPoolWallet_RPC : RPCTemplate<CreateNewPoolWallet_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CreateNewPoolWallet_RPC() { /* for serialisation */ }

        /// <summary>
        /// Create a new wallet for pooling
        /// </summary>
        /// <param name="initial_target_state">This info should be sent from the daemon. </param>
        /// <param name="p2_singleton_delayed_ph">This is the puzzle hash to which payouts will go</param>
        /// <param name="p2_singleton_delay_time">The time (in seconds) to delay payments [Default: None ]</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public CreateNewPoolWallet_RPC( string initial_target_state, string p2_singleton_delayed_ph, string p2_singleton_delay_time, ulong? fee = null)
        {
            this.initial_target_state = initial_target_state;
            this.p2_singleton_delayed_ph = p2_singleton_delayed_ph;
            this.p2_singleton_delay_time = p2_singleton_delay_time;
            this.fee = fee;
        }

        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? wallet_type { get; set; } = "pool_wallet";
        /// <summary>
        /// Must be either new of recovery. However, recovery has not been implemented, so currently (version 1.6) it will automatically fail
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? mode { get; set; } = "new";
        /// <summary>
        /// This info should be sent from the daemon. 
        /// <list type="bullet">
        /// <item>PoolState is a type that is serialized to the blockchain to track the state of the user's pool singleton.</item>
        /// <item>target_puzzle_hash is either the pool address, or the self-pooling address that pool rewards will be paid to.</item>
        /// <item>target_puzzle_hash is NOT the p2_singleton puzzle that block rewards are sent to.</item>
        /// <item>The p2_singleton address is the initial address, and the target_puzzle_hash is the final destination.</item>
        /// <item>relative_lock_height is zero when in SELF_POOLING state</item>
        /// </list>
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? initial_target_state { get; set; }
        /// <summary>
        /// *Required if mode is new. This is the puzzle hash to which payouts will go
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? p2_singleton_delayed_ph { get; set; }
        /// <summary>
        /// The time (in seconds) to delay payments [Default: None ]
        /// </summary>
        public string? p2_singleton_delay_time { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}
