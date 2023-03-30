using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_FoliageBlockData
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"extension_data\": \"0x0000000000000000000000000000000000000000000000000000000003a2c7c9\",\r\n  \"farmer_reward_puzzle_hash\": \"0xe2f70baf739bdaf59e360d3a3e2d4ff8cb89f150d9b60b8e91b870e41b58f2fa\",\r\n  \"pool_signature\": null,\r\n  \"pool_target\": {\r\n    \"max_height\": 0,\r\n    \"puzzle_hash\": \"0x71afdce401a0f2a6f03de6287902eacfa38502d6667b04da36e32c3930171ce4\"\r\n  },\r\n  \"unfinished_reward_block_hash\": \"0x293f38e7932dce9e8216820baf873c76836c8ffeb9ef24549a653f2c77a948d0\"\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<FoliageBlockData> helper = new Test_ObjectClasses<FoliageBlockData>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<FoliageBlockData> helper = new Test_ObjectClasses<FoliageBlockData>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
