using CHIA_RPC.FullNode_NS;
using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_RewardClaim
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"amount\": 1750000000000,\r\n  \"parent_coin_info\": \"0xccd5bb71183532bff220ba46c268991a00000000000000000000000000000061\",\r\n  \"puzzle_hash\": \"0x8f3dff600992a0b77aefbe8eb81dd4f233b9126f3b67557594b5a927d6e6d588\"\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<RewardClaim> helper = new Test_ObjectClasses<RewardClaim>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<RewardClaim> helper = new Test_ObjectClasses<RewardClaim>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
