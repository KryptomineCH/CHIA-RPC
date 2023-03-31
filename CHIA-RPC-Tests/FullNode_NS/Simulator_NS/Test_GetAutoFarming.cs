using CHIA_RPC.FullNode_NS.Simulator_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS.Simulator_NS
{
    public class Test_GetAutoFarming
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"auto_farm_enabled\": true,\r\n  \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<AutoFarming_Response> helper = new Test_ResponseClasses<AutoFarming_Response>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<AutoFarming_Response> helper = new Test_ResponseClasses<AutoFarming_Response>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
