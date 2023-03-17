using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/></remarks>
    public class ChallengeVdfOutput : ObjectTemplate<ChallengeVdfOutput>
    {
        public string data { get; set; }
    }
}
