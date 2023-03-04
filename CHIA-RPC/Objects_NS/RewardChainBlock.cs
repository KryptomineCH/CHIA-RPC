﻿
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
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
    public class Vdf : ObjectTemplate<Vdf>
    {
        public string challenge { get; set; }
        public ulong number_of_iterations { get; set; }
        public OutputData output { get; set; }

        public class OutputData : ObjectTemplate<OutputData>
        {
            public string data { get; set; }
        }
    }
}
