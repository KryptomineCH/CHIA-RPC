using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// a coin's spend record by its coin id, sometimes referred to as coin name. 
    /// Coin IDs can be calculated by hashing the coin. The puzzle and solution are provided in CLVM format.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_puzzle_and_solution"/><br/><br/>
    /// Uses:<br/><see cref="GetPuzzleAndSolution_RPC"/>
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
        /// for serializer
        /// </summary>
        public GetPuzzleAndSolution_RPC() { /* for serialisation */ }
        /// <summary>
        /// Retrieves a coin's spend record by its coin id, sometimes referred to as coin name. 
        /// </summary>
        /// <param name="coin_id">the coin id to look up</param>
        /// <param name="height">the height to search for</param>
        public GetPuzzleAndSolution_RPC(string coin_id, ulong height)
        {
            this.coin_id = coin_id;
            this.height = height;
        }
        /// <summary>
        /// Retrieves a coin's spend record by its coin id, sometimes referred to as coin name. 
        /// </summary>
        /// <param name="coin">the coin to look up</param>
        /// <param name="height">the height to search for</param>
        public GetPuzzleAndSolution_RPC(Coin coin, ulong height)
        {
            this.coin_id = coin.GetCoinID();
            this.height = height;
        }

        /// <summary>
        /// the coin id to look up
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string coin_id { get; set; }

        /// <summary>
        /// the height to search for
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong height { get; set; }
    }
}
