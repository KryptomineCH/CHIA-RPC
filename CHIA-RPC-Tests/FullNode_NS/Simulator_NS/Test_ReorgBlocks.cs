using CHIA_RPC.FullNode_NS.Simulator_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS.Simulator_NS
{
    public class Test_ReorgBlocks
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"num_of_blocks_to_rev\": 3, \"num_of_new_blocks\": 5, \"random_seed\": \"aaaaaa\"}"
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"new_peak_height\": 18,\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<ReorgBlocks_RPC> helper = new Test_RPCClasses<ReorgBlocks_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<ReorgBlocks_RPC> helper = new Test_RPCClasses<ReorgBlocks_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<NewPeakHeight_Response> helper = new Test_ResponseClasses<NewPeakHeight_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<NewPeakHeight_Response> helper = new Test_ResponseClasses<NewPeakHeight_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
