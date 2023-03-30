using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetBlockCountMetrics
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"metrics\": {\r\n    \"compact_blocks\": 1347047,\r\n    \"hint_count\": 1072468,\r\n    \"uncompact_blocks\": 494593\r\n  },\r\n  \"success\": true,\r\n  \"error\": null\r\n}",
            "{\r\n    \"metrics\": {\r\n        \"compact_blocks\": 2190434,\r\n        \"hint_count\": 5895366,\r\n        \"uncompact_blocks\": 1135855\r\n    },\r\n    \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetBlockCountMetrics_Response> helper = new Test_ResponseClasses<GetBlockCountMetrics_Response>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetBlockCountMetrics_Response> helper = new Test_ResponseClasses<GetBlockCountMetrics_Response>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
