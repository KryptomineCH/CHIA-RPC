namespace CHIA_RPC.Wallet_NS.CustomTransactionHistoryObjects_NS
{
    public enum CustomChiaTransactionType
    {
        /// <summary>
        /// defines a standard xch stransfer
        /// </summary>
        Standard,
        /// <summary>
        /// Defines a Cat Transfer
        /// </summary>
        Cat,
        /// <summary>
        /// Defines a Trade (offer)
        /// </summary>
        Trade,
        /// <summary>
        /// defines a neutral transaction, mostly used for cancellations<br/>
        /// (by sending the coin of a transaction to yourself before the original Transaction executes)<br/>
        /// </summary>
        /// <remarks>Fees might still ocurr</remarks>
        Neutral
    }
}
