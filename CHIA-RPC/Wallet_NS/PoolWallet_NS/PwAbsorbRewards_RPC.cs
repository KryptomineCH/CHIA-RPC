
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.PoolWallet_NS
{
    /// <summary>
    /// RPC request for absorbing unspent coinbase rewards to a pool wallet
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#pw_absorb_rewards"/></remarks>
    /// <returns>?</returns>
    public class PwAbsorbRewards_RPC : RPCTemplate<PwAbsorbRewards_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public PwAbsorbRewards_RPC() { /* for serialisation */ }
        /// <summary>
        /// RPC request for absorbing unspent coinbase rewards to a pool wallet
        /// </summary>
        /// <param name="wallet_id">The Wallet ID to which to absorb funds (must be of type POOLING_WALLET)</param>
        /// <param name="max_spends_in_tx">The maximum number of reward transactions to roll into the absorb transaction [Default: no maximum]</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public PwAbsorbRewards_RPC(ulong wallet_id, ulong? max_spends_in_tx = null, ulong? fee = null)
        {
            this.wallet_id = wallet_id;
            this.max_spends_in_tx = max_spends_in_tx;
            this.fee = fee;
        }

        /// <summary>
        /// The Wallet ID to which to absorb funds (must be of type POOLING_WALLET)
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The maximum number of reward transactions to roll into the absorb transaction [Default: no maximum]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_spends_in_tx { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}
