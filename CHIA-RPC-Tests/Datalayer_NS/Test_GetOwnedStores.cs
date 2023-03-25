using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_GetOwnedStores
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"store_ids\": [\r\n    \"1163ac212bd5fe00efa86f8d3c4958cda08924870800d72dc332f508a1b2e35a\"\r\n  ],\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetOwnedStores_Response> helper = new Test_ResponseClasses<GetOwnedStores_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetOwnedStores_Response> helper = new Test_ResponseClasses<GetOwnedStores_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
