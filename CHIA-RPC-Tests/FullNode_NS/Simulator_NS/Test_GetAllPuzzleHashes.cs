using CHIA_RPC.FullNode_NS;
using CHIA_RPC.FullNode_NS.Simulator_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS.Simulator_NS
{
    public class Test_GetAllPuzzleHashes
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"puzzle_hashes\": {\r\n    \"000000000000000000000000000000000000000000000000000000000000dead\": [\r\n      6000000000000, 6\r\n    ],\r\n    \"5fb3e0ccc23760a7f917a81e7872cc921f9ddbc86582dfb4f64eee66fad5e740\": [\r\n      21000034000000000000, 36\r\n    ],\r\n    \"645d29742666424eb58353901f2bcadb4f5fb356df4c436ebf053f954b182bc4\": [\r\n      6000000000000, 6\r\n    ]\r\n  },\r\n  \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetAllPuzzleHashes_Response> helper = new Test_ResponseClasses<GetAllPuzzleHashes_Response>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetAllPuzzleHashes_Response> helper = new Test_ResponseClasses<GetAllPuzzleHashes_Response>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
