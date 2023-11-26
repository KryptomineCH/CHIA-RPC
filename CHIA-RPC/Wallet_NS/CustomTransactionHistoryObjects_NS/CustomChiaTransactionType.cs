namespace CHIA_RPC.Wallet_NS.CustomTransactionHistoryObjects_NS
{
    public enum CustomChiaTransactionType
    {
        /// <summary>
        /// a standard transaction of one asset (incoming or outgoing)
        /// </summary>
        /// <remarks>
        /// if transafer is outgoing cat with a fee, you will find another outgoing xch transaction for the fee
        /// </remarks>
        Transfer,
        /// <summary>
        /// a trade transaction involving at least 2 assets
        /// </summary>
        /// <remarks>
        /// at least 1 received and 1 sent
        /// </remarks>
        Trade,
        /// <summary>
        /// defines a neutral transaction, sending coins through a blockchain back to oneself.<br/><br/>
        /// used for:<br/>
        /// - cancaellation of a pending transaction of offer<br/>
        /// - merging coins together<br/>
        /// - splitting coins apart
        /// </summary>
        /// <remarks>Fees might still ocurr</remarks>
        Neutral
    }
}
