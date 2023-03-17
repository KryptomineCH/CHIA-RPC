using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block_spends"/>
    /// </remarks>
    public class Spend : ObjectTemplate<Spend>
    {
        public Coin coin { get; set; }
        public string puzzle_reveal { get; set; }
        public string solution { get; set; }
    }
}
