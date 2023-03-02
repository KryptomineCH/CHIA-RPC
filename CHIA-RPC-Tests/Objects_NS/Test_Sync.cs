using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_Sync
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"sync_mode\": false,\r\n  \"sync_progress_height\": 0,\r\n  \"sync_tip_height\": 0,\r\n  \"synced\": false\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<Sync> helper = new Test_ObjectClasses<Sync>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<Sync> helper = new Test_ObjectClasses<Sync>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
