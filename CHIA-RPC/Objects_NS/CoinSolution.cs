
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Represents a coin along with its puzzle reveal and solution in a transaction.
    /// </summary>
    /// <remarks>
    /// CoinSolution encompasses a coin that is being spent, along with the puzzle reveal (the smart contract controlling the spend), and the solution to that puzzle. 
    /// This information together verifies the validity of the transaction.
    /// </remarks>
    public class CoinSolution : ObjectTemplate<CoinSolution>
    {
        /// <summary>
        /// Represents the coin that is being spent in the transaction. The coin was previously outputted (created) in a different transaction.
        /// </summary>
        public Coin? coin { get; set; }

        /// <summary>
        /// The 'puzzle reveal' represents the program (smart contract) that stipulates how the coin can be spent. This is often Chialisp code.
        /// </summary>
        public string? puzzle_reveal { get; set; }

        /// <summary>
        /// The 'solution' is the set of inputs to the puzzle that makes it valid. Essentially, the solution demonstrates that the requirements set out by the puzzle (smart contract) are met, and the coin can be spent.
        /// </summary>
        public string? solution { get; set; }
    }
}
