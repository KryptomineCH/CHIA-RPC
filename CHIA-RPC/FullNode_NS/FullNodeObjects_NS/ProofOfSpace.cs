using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_blocks"/>
    /// </remarks>
    public class ProofOfSpace : ObjectTemplate<ProofOfSpace>
    {
        public string challenge { get; set; }
        public string plot_public_key { get; set; }
        public string pool_contract_puzzle_hash { get; set; }
        public object pool_public_key { get; set; }
        public string proof { get; set; }
        public ulong size { get; set; }
    }
}
