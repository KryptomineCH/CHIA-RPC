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
    public class RewardChainBlock : ObjectTemplate<RewardChainBlock>
    {
        public Vdf challenge_chain_ip_vdf { get; set; }
        public string challenge_chain_sp_signature { get; set; }
        public Vdf challenge_chain_sp_vdf { get; set; }
        public ulong? height { get; set; }
        public Vdf infused_challenge_chain_ip_vdf { get; set; }
        public bool? is_transaction_block { get; set; }
        public string pos_ss_cc_challenge_hash { get; set; }
        public ProofOfSpace proof_of_space { get; set; }
        public Vdf reward_chain_ip_vdf { get; set; }
        public string reward_chain_sp_signature { get; set; }
        public Vdf reward_chain_sp_vdf { get; set; }
        public ulong signage_point_index { get; set; }
        public ulong total_iters { get; set; }
        public ulong? weight { get; set; }
    }
}    
