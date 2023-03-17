using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_Foliage
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"foliage_block_data\": {\r\n    \"extension_data\": \"0x0000000000000000000000000000000000000000000000000000000003a2c7c9\",\r\n    \"farmer_reward_puzzle_hash\": \"0xe2f70baf739bdaf59e360d3a3e2d4ff8cb89f150d9b60b8e91b870e41b58f2fa\",\r\n    \"pool_signature\": null,\r\n    \"pool_target\": {\r\n      \"max_height\": 0,\r\n      \"puzzle_hash\": \"0x71afdce401a0f2a6f03de6287902eacfa38502d6667b04da36e32c3930171ce4\"\r\n    },\r\n    \"unfinished_reward_block_hash\": \"0x293f38e7932dce9e8216820baf873c76836c8ffeb9ef24549a653f2c77a948d0\"\r\n  },\r\n  \"foliage_block_data_signature\": \"0x81fbc2b4d7d18e85db97e83f254ba6546cb08c80f50de1c7353d20a07d574d0d1c084273a1ef4822e164be450abb2dfe133e7d2d90727a43baae9ad858765b30eea9afaf809563760a07dc3fce343222af857b9af5f4d37f79a832e32f335335\",\r\n  \"foliage_transaction_block_hash\": null,\r\n  \"foliage_transaction_block_signature\": null,\r\n  \"prev_block_hash\": \"0x902ca8dfdd08e79dec3c96837f4e99162508ffaeff730c68af1fde9b86cbf61b\",\r\n  \"reward_block_hash\": \"0x5566434842f375434f9a558a3de5907db44903036c3de1573852afffbd1991bd\"\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<Foliage> helper = new Test_ObjectClasses<Foliage>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<Foliage> helper = new Test_ObjectClasses<Foliage>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
