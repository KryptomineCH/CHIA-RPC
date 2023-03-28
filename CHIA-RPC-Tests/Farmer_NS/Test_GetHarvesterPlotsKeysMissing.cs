using CHIA_RPC.Farmer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_GetHarvesterPlotsKeysMissing
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"node_id\": \"0xbefeeb05fa599f07c5be2b94b2d872b2516f03101ed49cc53312f086de197913\", \"page\": 0, \"page_size\": 1}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"node_id\": \"befeeb05fa599f07c5be2b94b2d872b2516f03101ed49cc53312f086de197913\",\r\n    \"page\": 0,\r\n    \"page_count\": 4,\r\n    \"plots\": [\r\n        \"/plots/plot-k25-2022-07-11-19-06-4d6433c28333540ddf8fe23915b9128363a123967676b69a8dd6c740b758e236.plot\",\r\n        \"/plots/plot-k25-2022-07-11-19-08-a3f6d15955bf3b7d1f3b8f822956e8c8d6187a06144a88758ea2f8c8cd89cb31.plot\",\r\n        \"/plots/plot-k25-2022-07-11-19-11-401393c153a0335ab4a846b39413ba7bef9f140dfd36f658e72050aa08abf6e7.plot\",\r\n        \"/plots/plot-k25-2022-07-11-19-13-b3e7169303d6d7697f80f92d72d28a00537215e66316e12c6a5e2cf69889c88f.plot\",\r\n        \"/plots/plot-k25-2022-07-11-19-15-7769e4a90f6c10cfed2cdb2e37755e92fe73febf265d8528cf333ff01406ca5f.plot\"\r\n    ],\r\n    \"success\": true,\r\n    \"total_count\": 18\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetHarvesterPlots_RPC> helper = new Test_RPCClasses<GetHarvesterPlots_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetHarvesterPlots_RPC> helper = new Test_RPCClasses<GetHarvesterPlots_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetHarvesterPlotsInvalid_Response> helper = new Test_ResponseClasses<GetHarvesterPlotsInvalid_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetHarvesterPlotsInvalid_Response> helper = new Test_ResponseClasses<GetHarvesterPlotsInvalid_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
