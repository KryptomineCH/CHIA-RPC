using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_CoinRecord
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"coin\": {\r\n    \"amount\": 921800500,\r\n    \"parent_coin_info\": \"0x055c0286a0eb881f2e950ce4ee30870868d1a951a0e0eb4dc52de5472a9c8b91\",\r\n    \"puzzle_hash\": \"0xb1736654875b1c49b4077b89580c4447f12f1e86fb85d488d7efddd5c6e06be0\"\r\n  },\r\n  \"coinbase\": false,\r\n  \"confirmed_block_index\": 922637,\r\n  \"spent\": true,\r\n  \"spent_block_index\": 922641,\r\n  \"timestamp\": 1632832094\r\n}"

        };

        [Fact]
        public void Test_CoinSerialisation()
        {
            Test_ObjectClasses<CoinRecord> helper = new Test_ObjectClasses<CoinRecord>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_CoinDiskIO()
        {
            Test_ObjectClasses<CoinRecord> helper = new Test_ObjectClasses<CoinRecord>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
