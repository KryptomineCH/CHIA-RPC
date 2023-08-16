namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// An enumeration of inclusion statuses, used by the peer object
    /// </summary>
    /// <remarks>
    /// More types may be added in the future. 
    /// See <see href="https://docs.chia.net/walletconnect-commands/?_highlight=sent#inclusionstatus"/> for an up-to-date list of valid types.
    /// </remarks>
    public enum InclusionStatus
    {
        /// <summary>
        /// no documentation
        /// </summary>
        SUCCESS = 1,

        /// <summary>
        /// no documentation
        /// </summary>
        PENDING = 2,

        /// <summary>
        /// no documentation
        /// </summary>
        FAILED = 3,
    }
}
