using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// a coin's spend record by its coin id, sometimes referred to as coin name. 
    /// Coin IDs can be calculated by hashing the coin. The puzzle and solution are provided in CLVM format.
    /// </summary>
    /// <remarks>
    /// request uses a <see cref="GetPuzzleAndSolution_RPC"/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_puzzle_and_solution"/>
    /// </remarks>
    public class GetPuzzleAndSolution_Response : ResponseTemplate<GetPuzzleAndSolution_Response>
    {
        /// <summary>
        /// The puzzle and solution are provided in CLVM format.
        /// </summary>
        public CoinSolution coin_solution { get; set; }
    }
    /// <summary>
    /// Retrieves a coin's spend record by its coin id, sometimes referred to as coin name. 
    /// Coin IDs can be calculated by hashing the coin. The puzzle and solution are provided in CLVM format.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_puzzle_and_solution"/></remarks>
    /// <returns><see cref="GetPuzzleAndSolution_Response"/></returns>
    public class GetPuzzleAndSolution_RPC : RPCTemplate<GetPuzzleAndSolution_RPC>
    {
        /// <summary>
        /// the coin id too look up
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// the height to search for
        /// </summary>
        public ulong height { get; set; }
    }
}
