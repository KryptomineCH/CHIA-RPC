using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
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
