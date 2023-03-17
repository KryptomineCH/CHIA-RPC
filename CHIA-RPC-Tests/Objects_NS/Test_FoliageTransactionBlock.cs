using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_FoliageTransactionBlock
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"additions_root\": \"0x2c04ae163cf5916b774e2591b075560b6dface2b242d10cbb9f40b134cdf2080\",\r\n  \"filter_hash\": \"0xea0d50f296d1bdaccc00be16e48a310dd4fa1fcf575065761add6366498b3fbf\",\r\n  \"prev_transaction_block_hash\": \"0xf88a87d79c8e65ca559b7e74a9aca3a6f9fc90e6bb9dc6cb4602ed599610876e\",\r\n  \"removals_root\": \"0x409433654e3b7a530da6cf55c93abde2c7a71a2ea9814883ceef956f8fed61ea\",\r\n  \"timestamp\": 1636577488,\r\n  \"transactions_info_hash\": \"0x9f3d9cb990c560fb66d4e09a9da79844ce933a809bc754eb151775f3600b73ed\"\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<FoliageTransactionBlock> helper = new Test_ObjectClasses<FoliageTransactionBlock>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<FoliageTransactionBlock> helper = new Test_ObjectClasses<FoliageTransactionBlock>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
