using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS.Simulator_NS
{
    /// <summary>
    /// Represents the response for the Get All Coins API.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/simulator-rpc#get_all_coins"/><br/><br/>
    /// Uses:<br/><see cref="GetAllCoins_RPC"/>
    /// </remarks>
    public class GetAllCoins_Response : ResponseTemplate<GetAllCoins_Response>
    {
        /// <summary>
        /// A list of coin records.
        /// </summary>
        public CoinRecord[] coin_records { get; set; }
    }

    /// <summary>
    /// Represents the RPC request for the Get All Coins API.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/simulator-rpc#get_all_coins"/></remarks>
    /// <returns><see cref="GetAllCoins_Response"/></returns>
    public class GetAllCoins_RPC : RPCTemplate<GetAllCoins_RPC>
    {
        /// <summary>
        /// Boolean indicating whether to include spent coins in the result.
        /// </summary>
        public bool? include_spent_coins { get; set; }
    }

}
