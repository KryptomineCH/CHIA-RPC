using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.PoolWallet_NS
{
    /// <summary>
    /// Request to leave a pool and begin self-pooling.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#pw_self_pool"/></remarks>
    /// <returns><see cref="PwJoinPool_Response"/></returns>
    public class PwSelfPool_RPC : RPCTemplate<PwSelfPool_RPC>
    {
        /// <summary>
        /// The Wallet ID to use for self-pooling (must be of type POOLING_WALLET)
        /// </summary>
        public ulong wallet_id { get; init; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong? fee { get; init; }
    }

}
