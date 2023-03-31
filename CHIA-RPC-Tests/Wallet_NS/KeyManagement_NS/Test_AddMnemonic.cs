using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.KeyManagement;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.KeyManagement_NS
{
    public class Test_AddMnemonic
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"mnemonic\": [\"hint\", \"dice\", \"session\", \"fun\", \"budget\", \"strong\", \"album\", \"lava\", \"tackle\", \"sudden\", \"garage\", \"people\", \"bundle\", \"federal\", \"chest\", \"process\", \"vicious\", \"behave\", \"nephew\", \"zero\", \"vital\", \"ocean\", \"artist\", \"lawsuit\"]}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"fingerprint\": 874731676,\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_ResponseClasses<GenerateMnemonic_Response> helper = new Test_ResponseClasses<GenerateMnemonic_Response>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_ResponseClasses<GenerateMnemonic_Response> helper = new Test_ResponseClasses<GenerateMnemonic_Response>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<FingerPrint_Response> helper = new Test_ResponseClasses<FingerPrint_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<FingerPrint_Response> helper = new Test_ResponseClasses<FingerPrint_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
