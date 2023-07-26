using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Runtime.CompilerServices;

namespace CHIA_RPC.Wallet_NS.PoolWallet_NS
{
    /// <summary>
    /// Request to leave a pool and begin self-pooling.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#pw_self_pool"/></remarks>
    /// <returns><see cref="PwJoinPool_Response"/></returns>
    public class PwSelfPool_RPC : RPCTemplate<PwSelfPool_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public PwSelfPool_RPC() { /* for serialisation */ }
        /// <summary>
        /// Request to leave a pool and begin self-pooling.
        /// </summary>
        /// <param name="wallet_id">The Wallet ID to use for self-pooling (must be of type POOLING_WALLET)</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public PwSelfPool_RPC(ulong wallet_id, ulong? fee = null)
        {
            this.wallet_id = wallet_id;
            this.fee = fee;
        }
        /// <summary>
        /// Request to leave a pool and begin self-pooling.
        /// </summary>
        /// <param name="walletID">The Wallet ID to use for self-pooling (must be of type POOLING_WALLET)</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public PwSelfPool_RPC(WalletID_RPC walletID, ulong? fee = null)
        {
            this.wallet_id = walletID.wallet_id;
            this.fee = fee;
        }

        /// <summary>
        /// The Wallet ID to use for self-pooling (must be of type POOLING_WALLET)
        /// </summary>
        public ulong? wallet_id { get; init; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong? fee { get; init; }
        /// <summary>
        /// converts this to a PwSelfPool_RPC
        /// </summary>
        /// <param name="walletID"></param>

        public static implicit operator PwSelfPool_RPC(WalletID_RPC walletID)
        {
            return new PwSelfPool_RPC(walletID.wallet_id);
        }
    }

}
