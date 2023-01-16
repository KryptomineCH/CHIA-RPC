using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHIA_RPC.Objects_NS
{
    public class NpcResult
    {
        public ulong clvm_cost { get; set; }
        public object error { get; set; }
        public List<Npc> npc_list { get; set; }
    }

    public class Npc
    {
        public string coin_name { get; set; }
        public List<List<object>> conditions { get; set; }
        public string puzzle_hash { get; set; }
    }
}
