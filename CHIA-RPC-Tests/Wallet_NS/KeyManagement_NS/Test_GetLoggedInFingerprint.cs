using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.KeyManagement_NS
{
    public class Test_GetLoggedInFingerprint
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"fingerprint\": 2818719465,\r\n    \"success\": true\r\n}"
        };
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
