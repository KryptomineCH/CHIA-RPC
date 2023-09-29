namespace CHIA_RPC.Objects_NS
{
    public enum CustomTransactionType
    {
        /// <summary>
        /// This transaction type means that the amount in the wallet increases
        /// </summary>
        /// <remarks>
        /// it can occurr in the following circumstances:<br/>
        /// - another wallet sends coins to this wallet<br/>
        /// - coins, eg. (xch -> Cat or NFT)  are beeing minted from another wallet into this wallet
        /// </remarks>
        Incoming,
        /// <summary>
        /// This transaction type means that the amount in the wallet decreases
        /// </summary>
        /// <remarks>
        /// in this case, the RemovalAmount - (AdditionsAmount + Fees) equals the sent amount. RemovalAmount - AdditionsAmount equals the deducted wallet balance
        /// it can occurr in the following circumstances:<br/>
        /// - coins are beeing sent to another wallet<br/>
        /// - coins, eg. (xch -> Cat or NFT) are beeing minted from this wallet into another wallet
        /// </remarks>
        Outgoing,
        /// <summary>
        /// This transaction is a neutral transaction. The amount in the wallet does not change
        /// </summary>
        /// <remarks>
        /// it can occur in the following circumstances:<br/>
        /// - when coins are beeing merged or split
        /// - a transaction gets cancelled. This is done by spending the original transactions coin and creating a new coin of the same value
        /// </remarks>
        Neutral,
        Outgoing_Trade,
        Incoming_Trade,
        Fee,
        /// <summary>
        /// Transaction type could not be identified
        /// </summary>
        Unknown

    }
}
