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
        public Transaction fee_transaction { get; set; }

        /// <summary>
        /// Represents the total fee.
        /// </summary>
        public ulong total_fee { get; set; }

        /// <summary>
        /// Represents a transaction.
        /// </summary>
        public Transaction transaction { get; set; }
    }
    /// <summary>
    /// Join a pool
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#pw_join_pool"/></remarks>
    /// <returns><see cref="PwJoinPool_Response"/></returns>
    public class PwJoinPool_RPC : RPCTemplate<PwJoinPool_RPC>
    {
        /// <summary>
        /// The Wallet ID to use to join the pool (must be of type POOLING_WALLET)
        /// </summary>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// This is the target of where rewards will be sent to from the singleton. Controlled by the pool
        /// </summary>
        public string target_puzzlehash { get; set; }
        /// <summary>
        /// The URL of the pool to join
        /// </summary>
        public string pool_url { get; set; }
        /// <summary>
        /// The number of blocks required to wait when attempting to leave the pool
        /// </summary>
        public ulong relative_lock_height { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong? fee { get; set; }
    }

}
