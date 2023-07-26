using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.PoolWallet_NS
{
    /// <summary>
    /// Join a pool
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#pw_join_pool"/><br/><br/>
    /// Uses:<br/><see cref="PwJoinPool_RPC"/>
    /// </remarks>
    public class PwJoinPool_Response : ResponseTemplate<PwJoinPool_Response>
    {
        /// <summary>
        /// Represents a fee transaction.
        /// </summary>
        public Transaction_StringMemos? fee_transaction { get; set; }

        /// <summary>
        /// Represents the total fee.
        /// </summary>
        public ulong total_fee { get; set; }

        /// <summary>
        /// Represents a transaction.
        /// </summary>
        public Transaction_StringMemos? transaction { get; set; }
    }
    /// <summary>
    /// Join a pool
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#pw_join_pool"/></remarks>
    /// <returns><see cref="PwJoinPool_Response"/></returns>
    public class PwJoinPool_RPC : RPCTemplate<PwJoinPool_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public PwJoinPool_RPC() { /* for serialisation */ }
        /// <summary>
        /// Join a pool
        /// </summary>
        /// <param name="wallet_id">The Wallet ID to use to join the pool (must be of type POOLING_WALLET)</param>
        /// <param name="target_puzzlehash">This is the target of where rewards will be sent to from the singleton. Controlled by the pool</param>
        /// <param name="pool_url">The URL of the pool to join</param>
        /// <param name="relative_lock_height">The number of blocks required to wait when attempting to leave the pool</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public PwJoinPool_RPC(ulong wallet_id, string target_puzzlehash, string pool_url, ulong relative_lock_height, ulong? fee = null)
        {
            this.wallet_id = wallet_id;
            this.target_puzzlehash = target_puzzlehash;
            this.pool_url = pool_url;
            this.relative_lock_height = relative_lock_height;
            this.fee = fee;
        }

        /// <summary>
        /// The Wallet ID to use to join the pool (must be of type POOLING_WALLET)
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// This is the target of where rewards will be sent to from the singleton. Controlled by the pool
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? target_puzzlehash { get; set; }
        /// <summary>
        /// The URL of the pool to join
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? pool_url { get; set; }
        /// <summary>
        /// The number of blocks required to wait when attempting to leave the pool
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong relative_lock_height { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }

}
