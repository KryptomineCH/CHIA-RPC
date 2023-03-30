using CHIA_RPC.General_NS;
using CHIA_RPC.Harvester_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Harvester_NS
{
    public class Test_DeletePlot
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"filename\": \"/plots/plot-k25-2022-07-11-19-22-a2ece0fd13e017f7b88911be5f91aa1e1866c89964c863f743f5c92e07118805.plot\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DeletePlot_RPC> helper = new Test_RPCClasses<DeletePlot_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DeletePlot_RPC> helper = new Test_RPCClasses<DeletePlot_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
