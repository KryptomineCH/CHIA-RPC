using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_GetKvDiff
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"id\":\"0x1163ac212bd5fe00efa86f8d3c4958cda08924870800d72dc332f508a1b2e35a\", \"hash_1\":\"0x7e193b814080e50aa7780bcf71fd0422a0397ad3e57dc1eac71d93183efb39ba\", \"hash_2\":\"0x2477500c19f0ddfb147049769ce54425a4c4e2994a25e63e51c389cb8f0e912f\"}",
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"diff\": [\r\n    {\r\n      \"key\": \"0004\",\r\n      \"type\": \"DELETE\",\r\n      \"value\": \"123abc\"\r\n    },\r\n    {\r\n      \"key\": \"0002\",\r\n      \"type\": \"INSERT\",\r\n      \"value\": \"0123456789abcdef\"\r\n    }\r\n  ],\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetKvDiff_RPC> helper = new Test_RPCClasses<GetKvDiff_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetKvDiff_RPC> helper = new Test_RPCClasses<GetKvDiff_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetKvDiff_Response> helper = new Test_ResponseClasses<GetKvDiff_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetKvDiff_Response> helper = new Test_ResponseClasses<GetKvDiff_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
