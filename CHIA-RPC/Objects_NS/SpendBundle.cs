using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json;
namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// A SpendBundle represents a set of CoinSpend objects wrapped together with an aggregate signature. 
    /// It's a fundamental concept in Chia's blockchain protocol and is used by both full node and wallet node. 
    /// In essence, it is a transaction in the Chia network. It contains all the information needed to validate the spends, including the proofs of ownership of the coins being spent.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/>
    /// <see href="https://docs.chia.net/full-node-rpc#push_tx"/>
    /// </remarks>
    public class SpendBundle : ObjectTemplate<SpendBundle>
    {
        /// <summary>
        /// The aggregated_signature is the aggregate of all the signatures for the CoinSpends in the SpendBundle. 
        /// It's used to validate the authenticity of the transaction.
        /// </summary>
        public string? aggregated_signature { get; set; }

        /// <summary>
        /// An array of CoinSpend objects that represent the coins being spent in this transaction. 
        /// Each CoinSpend includes the coin being spent and the puzzle and solution for that coin.
        /// </summary>
        public CoinSpend[]? coin_spends { get; set; }

        /// <summary>
        /// An array of CoinSpend objects that represent the solutions for the coins being spent in this transaction.
        /// These solutions will be validated against the puzzles to verify the authenticity of the transaction.
        /// </summary>
        public CoinSpend[]? coin_solutions { get; set; }

        /// <summary>
        /// Returns a JSON representation of the SpendBundle.
        /// </summary>
        /// <returns>The JSON representation of the SpendBundle as a string.</returns>
        public override string ToString()
        {
            string json = JsonSerializer.Serialize(this);
            return json;
        }
    }
}
