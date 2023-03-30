using CHIA_RPC.Farmer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_GetHarvesterPlotsDuplicates
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"node_id\": \"0xbefeeb05fa599f07c5be2b94b2d872b2516f03101ed49cc53312f086de197913\", \"page\": 0, \"page_size\": 1}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"node_id\": \"befeeb05fa599f07c5be2b94b2d872b2516f03101ed49cc53312f086de197913\",\r\n    \"page\": 0,\r\n    \"page_count\": 1,\r\n    \"plots\": [],\r\n    \"success\": true,\r\n    \"total_count\": 0\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetHarvesterPlots_RPC> helper = new Test_RPCClasses<GetHarvesterPlots_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetHarvesterPlots_RPC> helper = new Test_RPCClasses<GetHarvesterPlots_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetHarvesterPlotsInvalid_Response> helper = new Test_ResponseClasses<GetHarvesterPlotsInvalid_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetHarvesterPlotsInvalid_Response> helper = new Test_ResponseClasses<GetHarvesterPlotsInvalid_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
