using CHIA_RPC.FullNode_NS.Simulator_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS.Simulator_NS
{
    public class Test_SetAutoFarming
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"auto_farm\": true}"
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"auto_farm_enabled\": true,\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<SetAutoFarming_RPC> helper = new Test_RPCClasses<SetAutoFarming_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<SetAutoFarming_RPC> helper = new Test_RPCClasses<SetAutoFarming_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<AutoFarming_Response> helper = new Test_ResponseClasses<AutoFarming_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<AutoFarming_Response> helper = new Test_ResponseClasses<AutoFarming_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
