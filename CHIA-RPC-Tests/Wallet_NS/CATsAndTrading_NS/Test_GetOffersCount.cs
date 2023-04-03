using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.CATsAndTrading_NS
{
    public class Test_GetOffersCount
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"my_offers_count\": 0,\r\n    \"success\": true,\r\n    \"taken_offers_count\": 1,\r\n    \"total\": 1\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetOffersCount_Response> helper = new Test_ResponseClasses<GetOffersCount_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetOffersCount_Response> helper = new Test_ResponseClasses<GetOffersCount_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
