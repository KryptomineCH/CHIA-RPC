using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;


namespace CHIA_RPC.Wallet_NS.PoolWallet_NS
{
    /// <summary>
    /// Response class for the "pw_status" RPC.
    /// Obtain the status of a pooling wallet
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#pw_status"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class PwStatusResponse : ResponseTemplate<PwStatusResponse>
    {
        /// <summary>
        /// The state of the pooling wallet
        /// </summary>
        public State state { get; init; }
        /// <summary>
        /// List of unconfirmed transactions
        /// </summary>
        public object[] unconfirmed_transactions { get; init; }

        /// <summary>
        /// The state of the pooling wallet
        /// </summary>
        public class State
        {
            /// <summary>
            /// The current state of the wallet
            /// </summary>
            public CurrentState current { get; init; }
            /// <summary>
            /// The current state of the inner wallet
            /// </summary>
            public string current_inner { get; init; }
            /// <summary>
            /// The launcher coin
            /// </summary>
            public Coin launcher_coin { get; init; }
            /// <summary>
            /// The launcher id
            /// </summary>
            public string launcher_id { get; init; }
            /// <summary>
            /// The puzzle hash of the singleton
            /// </summary>
            public string p2_singleton_puzzle_hash { get; init; }
            /// <summary>
            /// The height of the singleton block
            /// </summary>
            public ulong singleton_block_height { get; init; }
            /// <summary>
            /// The target hash
            /// </summary>
            public object target { get; init; }
            /// <summary>
            /// The tip singleton coin id
            /// </summary>
            public string tip_singleton_coin_id { get; init; }

            /// <summary>
            /// The current state of the wallet
            /// </summary>
            public class CurrentState : ObjectTemplate<CurrentState> 
            {
                /// <summary>
                /// The public key of the owner
                /// </summary>
                public string owner_pubkey { get; init; }
                /// <summary>
                /// The pool url
                /// </summary>
                public string pool_url { get; init; }
                /// <summary>
                /// The relative lock height
                /// </summary>
                public ulong relative_lock_height { get; init; }
                /// <summary>
                /// The current state
                /// </summary>
                public ulong state { get; init; }
                /// <summary>
                /// The target puzzle hash
                /// </summary>
                public string target_puzzle_hash { get; init; }
                /// <summary>
                /// The version
                /// </summary>
                public ulong version { get; init; }
            }
        }
    }
}
