using CHIA_RPC.Farmer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_SetPayoutInstructions
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"launcher_id\": \"0x55244acf3017c2fc245020b46600827047dce8f54c982adaf95248ff2e955ad8\", \"payout_instructions\": \"19d5a0c14e294e48451959819e8c7407c1a06f4f81c69a943ac86433a9ff29e6\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<SetPayoutInstructions_RPC> helper = new Test_RPCClasses<SetPayoutInstructions_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<SetPayoutInstructions_RPC> helper = new Test_RPCClasses<SetPayoutInstructions_RPC>();
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
