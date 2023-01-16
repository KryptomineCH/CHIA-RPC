using CHIA_RPC.Objects_NS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHIA_RPC.FullNode_RPC_NS
{
    public class GetAllMempoolItems_Response
    {
        public MempoolItems mempool_items { get; set; }

    }
    public class MempoolItems
    {
        public Dictionary<string, Item> items { get; set; }
    }

    public class Item
    {
        public List<Coin> additions { get; set; }
        public int cost { get; set; }
        public int fee { get; set; }
        public NpcResult npc_result { get; set; }
        public string program { get; set; }
    }
}
