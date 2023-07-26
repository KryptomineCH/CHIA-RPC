using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents an item in the memory pool of unconfirmed transactions.
    /// </summary>
    /// <remarks>
    /// An unconfirmed transaction is one that is waiting to be included in a future block.
    /// </remarks>
    public class MempoolItem : ObjectTemplate<MempoolItem>
    {
        /// <summary>
        /// The coins which are (or will be) created by this transaction.
        /// </summary>
        /// <remarks>
        /// These coins are represented by the Coin class, which includes properties such as the coin's parent coin info, puzzle hash, and amount.
        /// </remarks>
        public Coin[]? additions { get; set; }

        /// <summary>
        /// The total cost of the transaction.
        /// </summary>
        /// <remarks>
        /// This cost includes any transaction fees and represents the amount deducted from the sender's wallet.
        /// </remarks>
        public ulong? cost { get; set; }

        /// <summary>
        /// The transaction fee that is awarded to the miner who includes the transaction in a block.
        /// </summary>
        public ulong? fee { get; set; }

        /// <summary>
        /// The result of executing the transaction in the Chia virtual machine.
        /// </summary>
        /// <remarks>
        /// This property may include information about any changes to the Chia blockchain state as a result of the transaction.
        /// </remarks>
        public NpcResult? npc_result { get; set; }

        /// <summary>
        /// The serialized program that represents the transaction.
        /// </summary>
        /// <remarks>
        /// This program includes the instructions and data needed to execute the transaction.
        /// </remarks>
        public string? program { get; set; }

        /// <summary>
        /// The coins that are spent from the wallet to create the new coins (additions).
        /// </summary>
        /// <remarks>
        /// These coins are represented by the Coin class, which includes properties such as the coin's parent coin info, puzzle hash, and amount.
        /// </remarks>
        public Coin[]? removals { get; set; }

        /// <summary>
        /// The SpendBundle associated with the transaction.
        /// </summary>
        /// <remarks>
        /// A SpendBundle represents a collection of CoinSpends and includes the aggregated signature.
        /// </remarks>
        public SpendBundle? spend_bundle { get; set; }

        /// <summary>
        /// The name or identifier of the SpendBundle associated with the transaction.
        /// </summary>
        /// <remarks>
        /// This is a unique identifier and is typically used for referencing the SpendBundle in other parts of the system.
        /// </remarks>
        public string? spend_bundle_name { get; set; }
    }

}
