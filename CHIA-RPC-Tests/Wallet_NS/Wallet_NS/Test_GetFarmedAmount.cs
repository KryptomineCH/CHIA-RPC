using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_GetFarmedAmount
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"farmed_amount\": 0,\r\n    \"farmer_reward_amount\": 0,\r\n    \"fee_amount\": 0,\r\n    \"last_height_farmed\": 0,\r\n    \"pool_reward_amount\": 0,\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetFarmedAmount_Response> helper = new Test_ResponseClasses<GetFarmedAmount_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetFarmedAmount_Response> helper = new Test_ResponseClasses<GetFarmedAmount_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
