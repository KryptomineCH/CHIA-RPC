using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_PoolTarget
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"max_height\": 0,\r\n  \"puzzle_hash\": \"0x71afdce401a0f2a6f03de6287902eacfa38502d6667b04da36e32c3930171ce4\"\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<PoolTarget> helper = new Test_ObjectClasses<PoolTarget>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<PoolTarget> helper = new Test_ObjectClasses<PoolTarget>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
