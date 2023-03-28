using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    public class NpcConditions : ObjectTemplate<NpcConditions>
    {
        public object[] agg_sig_unsafe { get; set; }
        public object before_height_absolute { get; set; }
        public object before_seconds_absolute { get; set; }
        public ulong cost { get; set; }
        public ulong height_absolute { get; set; }
        public ulong reserve_fee { get; set; }
        public ulong seconds_absolute { get; set; }
        public NpcSpend[] spends { get; set; }
    }
}
