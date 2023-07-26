
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.Simulator_NS
{
    /// <summary>
    /// Represents the response for the Get Farming Puzzle Hash RPC API.<br/>
    /// You can then use cdv encode to convert this puzzle hash to an address:
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/simulator-rpc#get_farming_ph"/><br/><br/>
    /// Uses:<br/>The request has no parameters
    /// </remarks>
    public class GetFarmingPh_Response : ResponseTemplate<GetFarmingPh_Response>
    {
        /// <summary>
        /// The puzzle hash used by the farmer.
        /// </summary>
        public string? puzzle_hash { get; set; }
    }

}
