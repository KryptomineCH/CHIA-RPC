using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// represents the server response containing the blockchain state as well as request success information
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/><br/><br/>
    /// Uses:<br/>the request does not have parameters
    /// </remarks>
    public class GetBlockchainState_Response : ResponseTemplate<GetBlockchainState_Response>
    {
        /// <summary>
        /// This is used to capture various attributes about the blockchain's state at any given moment.
        /// It includes information such as the maximum cost of a block, difficulty, and the state of the mempool.
        /// For more details about this information, refer to Chia's full node RPC documentation:<br/>
        /// <see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/>
        /// </summary>
        public BlockchainState? blockchain_state { get; set; }
    }
}
