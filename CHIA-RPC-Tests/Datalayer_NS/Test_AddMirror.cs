using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_GetMirrors
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"id\":\"0x1ad0908e248f48cc3e9b3cf8f68c748d2e3c5a2a933765032d3222086231ea5e\"}",
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"mirrors\": [\r\n    {\r\n      \"amount\": 1000000,\r\n      \"coin_id\": \"11f450c2f706cda88b3373855b3780d36822a7f0e94297eb88de7c63eb0bd4c7\",\r\n      \"launcher_id\": \"1ad0908e248f48cc3e9b3cf8f68c748d2e3c5a2a933765032d3222086231ea5e\",\r\n      \"ours\": true,\r\n      \"urls\": [\"http://www.example.com:8575\", \"http://www.example2.com:8575\"]\r\n    }\r\n  ],\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<ID_RPC> helper = new Test_RPCClasses<ID_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<ID_RPC> helper = new Test_RPCClasses<ID_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetMirrors_Response> helper = new Test_ResponseClasses<GetMirrors_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetMirrors_Response> helper = new Test_ResponseClasses<GetMirrors_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
