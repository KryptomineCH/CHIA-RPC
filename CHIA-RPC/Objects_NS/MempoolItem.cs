using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    public class MempoolItem : ObjectTemplate<MempoolItem>
    {
        public Coin[] additions { get; set; }
        public ulong cost { get; set; }
        public ulong fee { get; set; }
        public NpcResult npc_result { get; set; }
        public string program { get; set; }
        public Coin[] removals { get; set; }
        public SpendBundle spend_bundle { get; set; }
        public string spend_bundle_name { get; set; }
    }
}
