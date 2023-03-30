using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_Coin
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"amount\": 3968760041,\r\n  \"parent_coin_info\": \"0xbf71e1d17630e3793321944b5825b5b573ac28c03113498baae997e0781f0278\",\r\n  \"puzzle_hash\": \"0x3be9de8637a998987687d6e3f1df95b6bcde6a2cbc7ed96b40fbc9d76bb5033d\"\r\n}",
            "{\r\n  \"amount\": 3981342052,\r\n  \"parent_coin_info\": \"0x0252418f0ad7a0009dc055a48a2aaff897f4ea6289b57f1ed9c0d8c7a5b5e6a8\",\r\n  \"puzzle_hash\": \"0xdd259fada9e1fbfb1499df0755462222f31ec512404842b5c7dac26b9a5cb29a\"\r\n}"
        };

        [Fact]
        public void Test_CoinSerialisation()
        {
            Test_ObjectClasses<Coin> helper = new Test_ObjectClasses<Coin>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_CoinDiskIO()
        {
            Test_ObjectClasses<Coin> helper = new Test_ObjectClasses<Coin>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
