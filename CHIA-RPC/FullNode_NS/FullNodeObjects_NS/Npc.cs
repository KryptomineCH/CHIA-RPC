using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents a MyClass_FarmerObject class that inherits from ObjectTemplate.
    /// </summary>
    public class NpcResult : ObjectTemplate<NpcResult>
    {
        public NpcConditions conds { get; set; }
        public ulong cost { get; set; }
        public ulong clvm_cost { get; set; }
        public string? error { get; set; }
        public Npc[] npc_list { get; set; }
        public Coin[] removals { get; set; }
        public SpendBundle spend_bundle { get; set; }
        public string spend_bundle_name { get; set; }
    }

    public class Npc : ObjectTemplate<Npc>
    {
        public string coin_name { get; set; }
        public object[][] conditions { get; set; }
        public string puzzle_hash { get; set; }
    }
}
