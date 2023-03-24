using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.Simulator_NS
{
    /// <summary>
    /// Response from get_all_puzzle_hashes RPC.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/simulator-rpc#get_all_puzzle_hashes"/><br/><br/>
    /// Uses:<br/>The request has no parameters
    /// </remarks>
    public class GetAllPuzzleHashes_Response : ResponseTemplate<GetAllPuzzleHashes_Response>
    {
        /// <summary>
        /// Dictionary containing puzzle hashes used in the blockchain as keys,
        /// and a two-element array with total unspent amount and count of unspent coins as values.
        /// </summary>
        public Dictionary<string, ulong[]> puzzle_hashes { get; init; }
    }
}
