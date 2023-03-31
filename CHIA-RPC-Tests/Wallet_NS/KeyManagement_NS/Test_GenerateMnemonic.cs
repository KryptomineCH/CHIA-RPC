using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.KeyManagement;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.KeyManagement_NS
{
    public class Test_GenerateMnemonic
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"mnemonic\": [\r\n        \"hint\",\r\n        \"dice\",\r\n        \"session\",\r\n        \"fun\",\r\n        \"budget\",\r\n        \"strong\",\r\n        \"album\",\r\n        \"lava\",\r\n        \"tackle\",\r\n        \"sudden\",\r\n        \"garage\",\r\n        \"people\",\r\n        \"bundle\",\r\n        \"federal\",\r\n        \"chest\",\r\n        \"process\",\r\n        \"vicious\",\r\n        \"behave\",\r\n        \"nephew\",\r\n        \"zero\",\r\n        \"vital\",\r\n        \"ocean\",\r\n        \"artist\",\r\n        \"lawsuit\"\r\n    ],\r\n    \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GenerateMnemonic_Response> helper = new Test_ResponseClasses<GenerateMnemonic_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GenerateMnemonic_Response> helper = new Test_ResponseClasses<GenerateMnemonic_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
