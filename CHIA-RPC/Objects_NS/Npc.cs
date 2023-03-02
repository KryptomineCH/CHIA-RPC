using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    public class NpcResult : ObjectTemplate<NpcResult>
    {
        public int clvm_cost { get; set; }
        public object? error { get; set; }
        public Npc[] npc_list { get; set; }
    }

    public class Npc : ObjectTemplate<Npc>
    {
        public string coin_name { get; set; }
        public object[][] conditions { get; set; }
        public string puzzle_hash { get; set; }
    }
}
