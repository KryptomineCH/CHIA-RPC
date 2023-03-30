using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_GetRoots
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"ids\":[\"8f6ed792bbbf5216f8e55064793f74ce01286b9c1d542cc4a357cf7f8712df1d\", \"0x1ad0908e248f48cc3e9b3cf8f68c748d2e3c5a2a933765032d3222086231ea5e\"]}",
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"root_hashes\": [\r\n    {\r\n      \"confirmed\": true,\r\n      \"hash\": \"0x0000000000000000000000000000000000000000000000000000000000000000\",\r\n      \"id\": \"0x8f6ed792bbbf5216f8e55064793f74ce01286b9c1d542cc4a357cf7f8712df1d\",\r\n      \"timestamp\": 1660672031\r\n    },\r\n    {\r\n      \"confirmed\": true,\r\n      \"hash\": \"0xb5420e65846ded936d1e4855c066247fc461a3b281cd9e0e69f3cfa4df529ba2\",\r\n      \"id\": \"0x1ad0908e248f48cc3e9b3cf8f68c748d2e3c5a2a933765032d3222086231ea5e\",\r\n      \"timestamp\": 1660724174\r\n    }\r\n  ],\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetRoots_RPC> helper = new Test_RPCClasses<GetRoots_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetRoots_RPC> helper = new Test_RPCClasses<GetRoots_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetRoots_Response> helper = new Test_ResponseClasses<GetRoots_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetRoots_Response> helper = new Test_ResponseClasses<GetRoots_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
