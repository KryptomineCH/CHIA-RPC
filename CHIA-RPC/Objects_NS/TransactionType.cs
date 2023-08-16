namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// An enumeration of Chia Transaction types
    /// </summary>
    /// <remarks>
    /// As of right now, no Documentation.<br/>
    /// More types may be added in the future. See <see href="https://docs.chia.net/walletconnect-commands#transactiontype"/> for an up-to-date list of valid types.
    /// </remarks>
    public enum TransactionType
    {
        /// <summary>
        /// Represents a standard incoming transaction.
        /// </summary>
        INCOMING = 0,

        /// <summary>
        /// Represents a standard outgoing transaction.
        /// </summary>
        OUTGOING = 1,

        /// <summary>
        /// Represents the reward for farming a block.
        /// </summary>
        COINBASE_REWARD = 2,

        /// <summary>
        /// Represents the transactions fees from a farmed block.
        /// </summary>
        FEE_REWARD = 3,

        /// <summary>
        /// as of right now, unknown (is this a offer?).
        /// </summary>
        INCOMING_TRADE = 4,

        /// <summary>
        /// as of right now, unknown (is this a offer?).
        /// </summary>
        OUTGOING_TRADE = 5,
    }

}
