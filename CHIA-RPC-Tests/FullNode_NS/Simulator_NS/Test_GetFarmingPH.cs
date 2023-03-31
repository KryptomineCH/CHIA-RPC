using CHIA_RPC.FullNode_NS.Simulator_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS.Simulator_NS
{
    public class Test_GetFarmingPH
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"puzzle_hash\": \"5fb3e0ccc23760a7f917a81e7872cc921f9ddbc86582dfb4f64eee66fad5e740\",\r\n  \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetFarmingPh_Response> helper = new Test_ResponseClasses<GetFarmingPh_Response>();
            helper.Test_Serialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetFarmingPh_Response> helper = new Test_ResponseClasses<GetFarmingPh_Response>();
            helper.Test_DiskIO(ExpectedResults);
        }
    }
}
