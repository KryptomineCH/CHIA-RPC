using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

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
        public ulong cost { get; set; }

        /// <summary>
        /// The transaction fee that is awarded to the miner who includes the transaction in a block.
        /// </summary>
        public ulong? fee { get; set; }
        /// <summary>
        /// the transaction fee in full chia
        /// </summary>
        /// <remarks>This value is derived from the mojos fee_amount</remarks>
        [JsonIgnore]
        public decimal? fee_in_xch
        {
            get { return fee / GlobalVar.OneChiaInMojos; }
            set { fee = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// Calculates the ratio of the transaction fee to the total cost of the transaction.
        /// </summary>
        /// <remarks>
        /// This property provides a decimal representation of the fee per cost, offering insight into the proportion of the total transaction cost that is made up of the transaction fee. If the cost is 0 or the fee is null, the value of this property will be 0, indicating no fee or that the fee does not apply.
        /// </remarks>
        public decimal FeePerCost
        {
            get
            {
                // Check if cost is 0 or fee is null to avoid division by zero or null reference exceptions.
                if (cost == 0 || fee == null)
                {
                    return 0m;
                }

                // Ensure fee is converted to decimal for accurate division and calculation.
                return (decimal)fee / cost;
            }
        }


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
