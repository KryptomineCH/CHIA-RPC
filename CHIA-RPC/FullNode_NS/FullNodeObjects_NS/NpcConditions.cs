using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents the conditions needed for executing a transaction in the network payment controller (NPC).
    /// </summary>
    public class NpcConditions : ObjectTemplate<NpcConditions>
    {
        /// <summary>
        /// the amount that gets added with the condition (mojos)_
        /// </summary>
        public ulong? addition_amount { get; set; }
        /// <summary>
        /// Represents the unsafe aggregated signature for the transaction. This is generally the aggregation of all the individual signatures from multiple signers.
        /// </summary>
        public object[]? agg_sig_unsafe { get; set; }

        /// <summary>
        /// Represents a condition that the transaction must be included in a block before a certain absolute block height. This condition is optional and can be null.
        /// </summary>
        public object? before_height_absolute { get; set; }

        /// <summary>
        /// Represents a condition that the transaction must be included in a block before a certain absolute time in seconds from the genesis block. This condition is optional and can be null.
        /// </summary>
        public object? before_seconds_absolute { get; set; }

        /// <summary>
        /// Represents the total cost of the transaction. This cost includes the fees required to process the transaction on the network.
        /// </summary>
        public ulong? cost { get; set; }

        /// <summary>
        /// Represents the absolute block height when this transaction becomes valid. This is typically used to delay the validity of a transaction until a certain block height is reached.
        /// </summary>
        public ulong? height_absolute { get; set; }

        /// <summary>
        /// the amount that gets removed with the condition (mojos)_
        /// </summary>
        public ulong? removal_amount { get; set; }

        /// <summary>
        /// Represents the reserve fee for the transaction. This is the fee that is held in reserve for future transactions.
        /// </summary>
        public ulong? reserve_fee { get; set; }

        /// <summary>
        /// Represents the absolute time in seconds from the genesis block when this transaction becomes valid. This is typically used to delay the validity of a transaction until a certain time has passed.
        /// </summary>
        public ulong? seconds_absolute { get; set; }

        /// <summary>
        /// Represents an array of all the individual spends that make up the transaction. Each spend is a transfer of coins from one puzzle hash to another.
        /// </summary>
        public NpcSpend[]? spends { get; set; }
    }

}
