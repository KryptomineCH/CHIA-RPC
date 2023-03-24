
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.PoolWallet_NS
{
    /// <summary>
    /// RPC request for absorbing unspent coinbase rewards to a pool wallet
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#pw_absorb_rewards"/></remarks>
    /// <returns>?</returns>
    public class PwAbsorbRewardsRPC : RPCTemplate<PwAbsorbRewardsRPC>
    {
        /// <summary>
        /// The Wallet ID to which to absorb funds (must be of type POOLING_WALLET)
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The maximum number of reward transactions to roll into the absorb transaction [Default: no maximum]
        /// </summary>
        public ulong? max_spends_in_tx { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong? fee { get; set; }
    }
}
