using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents the results of a Non-Player Character (NPC) operation, typically associated with a Chia transaction or block.
    /// </summary>
    /// <remarks>
    /// This is a template for constructing or interpreting data resulting from a NPC operation within the Chia Network.
    /// </remarks>
    public class NpcResult : ObjectTemplate<NpcResult>
    {
        /// <summary>
        /// Conditions associated with this NPC operation result.
        /// </summary>
        /// <remarks>
        /// This is a summary of the conditions imposed by the NPC operation. It can include various kinds of constraints or requirements.
        /// </remarks>
        public NpcConditions? conds { get; set; }

        /// <summary>
        /// The total cost of this NPC operation.
        /// </summary>
        /// <remarks>
        /// This is the cost associated with the execution of the NPC operation and can include fees or resources used.
        /// </remarks>
        public ulong? cost { get; set; }

        /// <summary>
        /// The cost of running the CLVM (Chia Lisp Virtual Machine) for this NPC operation.
        /// </summary>
        /// <remarks>
        /// This represents the computational resources used in the process of executing the smart contract or "puzzle" associated with the NPC operation.
        /// </remarks>
        public ulong? clvm_cost { get; set; }

        /// <summary>
        /// Any error message generated during the NPC operation.
        /// </summary>
        /// <remarks>
        /// This will be populated if there was an error in processing the NPC operation.
        /// </remarks>
        public string? error { get; set; }

        /// <summary>
        /// The list of NPCs associated with this operation result.
        /// </summary>
        /// <remarks>
        /// This can include NPCs that were involved in or affected by the operation.
        /// </remarks>
        public Npc[]? npc_list { get; set; }

        /// <summary>
        /// The coins removed in this NPC operation.
        /// </summary>
        /// <remarks>
        /// This represents the coins that were spent or otherwise removed from circulation as a result of the operation.
        /// </remarks>
        public Coin[]? removals { get; set; }

        /// <summary>
        /// The SpendBundle associated with this NPC operation.
        /// </summary>
        /// <remarks>
        /// A SpendBundle represents a transaction in the Chia Network, which could be associated with this NPC operation.
        /// </remarks>
        public SpendBundle? spend_bundle { get; set; }

        /// <summary>
        /// The name of the SpendBundle associated with this NPC operation.
        /// </summary>
        /// <remarks>
        /// This can be used to identify or reference the associated transaction.
        /// </remarks>
        public string? spend_bundle_name { get; set; }
    }


    /// <summary>
    /// Represents a Non-Player Character (NPC), an object of the Chia Network.
    /// </summary>
    /// <remarks>
    /// This is a template for constructing or interpreting data in the form of a NPC, which are used for various tasks within the Chia Network.
    /// </remarks>
    public class Npc : ObjectTemplate<Npc>
    {
        /// <summary>
        /// The name or identifier of the coin associated with this NPC.
        /// </summary>
        /// <remarks>
        /// This is a unique identifier and is typically used for referencing the coin in other parts of the system.
        /// </remarks>
        public string? coin_name { get; set; }

        /// <summary>
        /// The conditions associated with this NPC.
        /// </summary>
        /// <remarks>
        /// Conditions are constraints or requirements that must be met for a transaction involving this NPC to be valid. They are represented as a two-dimensional object array.
        /// </remarks>
        public object[][]? conditions { get; set; }

        /// <summary>
        /// The puzzle hash associated with this NPC.
        /// </summary>
        /// <remarks>
        /// The puzzle hash is a unique identifier that represents the smart contract or "puzzle" that controls the coin. It is created by hashing the puzzle's function.
        /// </remarks>
        public string? puzzle_hash { get; set; }
    }

}
