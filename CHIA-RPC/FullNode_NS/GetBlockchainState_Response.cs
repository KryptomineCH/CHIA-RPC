using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// represents the server response containing the blockchain state as well as request success information
    /// </summary>
    /// <remarks>
    /// Request is Parameterless<br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/>
    /// </remarks>
    public class GetBlockchainState_Response : ResponseTemplate<GetBlockchainState_Response>
    {
        public BlockchainState blockchain_state { get; set; }
    }
}
