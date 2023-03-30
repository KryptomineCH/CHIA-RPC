using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_Subscriptions
    {

        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"store_ids\": [\r\n    \"9166b9bed97e0ce9b5d79564e8dba2975ae0637994e8908a31aaddd7a29bfb90\",\r\n    \"a4a9a945a7511911aeaaefc9e6627831b1c30b1919c92c738592923f30fe3735\",\r\n    \"550386f956c9932210c38c674e42dca9db9655b8155069540feaac91833c664b\",\r\n    \"1163ac212bd5fe00efa86f8d3c4958cda08924870800d72dc332f508a1b2e35a\",\r\n    \"8f6ed792bbbf5216f8e55064793f74ce01286b9c1d542cc4a357cf7f8712df1d\"\r\n  ],\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<Subscriptions_Response> helper = new Test_ResponseClasses<Subscriptions_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Subscriptions_Response> helper = new Test_ResponseClasses<Subscriptions_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
