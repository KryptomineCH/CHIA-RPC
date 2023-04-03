using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.CATsAndTrading_NS
{
    public class Test_GetStrayCats
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"stray_cats\": [],\r\n    \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetStrayCats_Response> helper = new Test_ResponseClasses<GetStrayCats_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetStrayCats_Response> helper = new Test_ResponseClasses<GetStrayCats_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
