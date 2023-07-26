using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents a single spend of a coin in a transaction.
    /// </summary>
    /// <remarks>
    /// In a transaction, each coin spend is a transfer of coins from one puzzle hash (source address) to another (destination address). 
    /// The combination of the puzzle reveal and solution verifies that the spender is the rightful owner of the coin being spent. 
    /// More details can be found in the Chia documentation: <see href="https://docs.chia.net/full-node-rpc#get_block_spends"/>.
    /// </remarks>
    public class CoinSpend : ObjectTemplate<CoinSpend>
    {
        /// <summary>
        /// Represents the coin that is being spent in this transaction. This coin was previously outputted (created) in another transaction.
        /// </summary>
        public Coin? coin { get; set; }

        /// <summary>
        /// The 'puzzle reveal' represents the program (smart contract) that controls how the coin can be spent. This is typically a piece of Chialisp code.
        /// </summary>
        public string? puzzle_reveal { get; set; }

        /// <summary>
        /// The 'solution' is the inputs to the puzzle that make it valid. In essence, the solution demonstrates that the conditions set by the puzzle (smart contract) are satisfied, allowing the coin to be spent.
        /// </summary>
        public string? solution { get; set; }
    }

}
