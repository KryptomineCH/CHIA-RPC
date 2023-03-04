using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC_Tests.Testhelpers;
using System.Xml.Schema;

namespace CHIA_RPC_Tests.FullNode_RPC_NS
{
    public class Test_GetRoutes
    {
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"routes\": [\r\n    \"/get_blockchain_state\",\r\n    \"/get_block\",\r\n    \"/healthz\"\r\n  ],\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetRoutes_Response> helper = new Test_ResponseClasses<GetRoutes_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetRoutes_Response> helper = new Test_ResponseClasses<GetRoutes_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
