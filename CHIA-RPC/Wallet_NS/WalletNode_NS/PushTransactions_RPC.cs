using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.WalletNode_NS
{
    /// <summary>
    /// Push multiple transactions to the blockchain
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#push_transactions"/></remarks>
    /// <returns>?</returns>
    public class PushTransactions_RPC : RPCTemplate<PushTransactions_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public PushTransactions_RPC() { /* for serialisation */ }
        /// <summary>
        /// Push multiple transactions to the blockchain
        /// </summary>
        /// <param name="transactions">An array of SpendBundles (transactions) to push</param>
        public PushTransactions_RPC(SpendBundle[] transactions)
        {
            this.transactions = transactions;
        }

        /// <summary>
        /// An array of SpendBundles (transactions) to push
        /// </summary>
        public SpendBundle[]? transactions { get; set; }

        /// <summary>
        /// Implicit conversion from SpendBundle[] to PushTransactions_RPC.
        /// </summary>
        /// <param name="response">PushTransactions_RPC object</param>
        public static implicit operator PushTransactions_RPC(SpendBundle[] response)
        {
            return new PushTransactions_RPC(response);
        }
    }
}
