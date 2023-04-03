using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_GetCurrentDerivationIndex
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"index\": 435,\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<Index_Response> helper = new Test_ResponseClasses<Index_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Index_Response> helper = new Test_ResponseClasses<Index_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
