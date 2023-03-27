using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_AddMirror
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"id\":\"0x1ad0908e248f48cc3e9b3cf8f68c748d2e3c5a2a933765032d3222086231ea5e\", \"urls\":[\"http://www.example.com:8575\", \"http://www.example2.com:8575\"], \"amount\":1000000}",
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<AddMirror_RPC> helper = new Test_RPCClasses<AddMirror_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<AddMirror_RPC> helper = new Test_RPCClasses<AddMirror_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
