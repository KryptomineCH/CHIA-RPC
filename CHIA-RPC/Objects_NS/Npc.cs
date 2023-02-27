
namespace CHIA_RPC.Objects_NS
{
    public class NpcResult
    {
        public int clvm_cost { get; set; }
        public object error { get; set; }
        public Npc[] npc_list { get; set; }
    }

    public class Npc
    {
        public string coin_name { get; set; }
        public Condition[][] conditions { get; set; }
        public string puzzle_hash { get; set; }
    }

    public class Condition
    {
        public string opcode { get; set; }
        public object[] vars { get; set; }
    }
}
