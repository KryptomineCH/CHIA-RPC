using CHIA_RPC.FullNode_NS.Simulator_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS.Simulator_NS
{
    public class Test_RevertBlocks
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"delete_all_blocks\": true}"
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"new_peak_height\": 1,\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<RevertBlocks_RPC> helper = new Test_RPCClasses<RevertBlocks_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<RevertBlocks_RPC> helper = new Test_RPCClasses<RevertBlocks_RPC>();
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
