using CHIA_RPC.FullNode_NS.Simulator_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS.Simulator_NS
{
    public class Test_FarmBlock
    {
        private string[] ExpectedRPCResults = new string[]
        {
            // Farm a single block:
            "{\"address\": \"txch1v3wjjapxvepyadvr2wgp7272md84lv6kmaxyxm4lq5le2jcc90zqkxhgv6\"}",
            // Farm three transaction blocks:
            "{\"address\": \"txch1v3wjjapxvepyadvr2wgp7272md84lv6kmaxyxm4lq5le2jcc90zqkxhgv6\", \"guarantee_tx_block\": true, \"blocks\": 3}"
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"new_peak_height\": 21,\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<FarmBlock_RPC> helper = new Test_RPCClasses<FarmBlock_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<FarmBlock_RPC> helper = new Test_RPCClasses<FarmBlock_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<FarmBlock_Response> helper = new Test_ResponseClasses<FarmBlock_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<FarmBlock_Response> helper = new Test_ResponseClasses<FarmBlock_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
