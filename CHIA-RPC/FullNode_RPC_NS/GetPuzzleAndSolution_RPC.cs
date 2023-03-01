using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// a coin's spend record by its coin id, sometimes referred to as coin name. 
    /// Coin IDs can be calculated by hashing the coin. The puzzle and solution are provided in CLVM format.
    /// </summary>
    public class GetPuzzleAndSolution_Response : ResponseTemplate<GetPuzzleAndSolution_Response>
    {
        /// <summary>
        /// A collection of coin records returned from the response.
        /// </summary>
        public CoinRecord[] coin_records { get; set; }
    }
    /// <summary>
    /// Retrieves a coin's spend record by its coin id, sometimes referred to as coin name. 
    /// Coin IDs can be calculated by hashing the coin. The puzzle and solution are provided in CLVM format.
    /// </summary>
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
