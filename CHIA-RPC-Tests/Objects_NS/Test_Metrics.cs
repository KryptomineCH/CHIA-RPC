using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_Metrics
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"compact_blocks\": 1347047,\r\n  \"hint_count\": 1072468,\r\n  \"uncompact_blocks\": 494593\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<Metrics> helper = new Test_ObjectClasses<Metrics>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<Metrics> helper = new Test_ObjectClasses<Metrics>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
