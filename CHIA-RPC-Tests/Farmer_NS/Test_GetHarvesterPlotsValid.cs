using CHIA_RPC.Farmer_NS;
using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_GetHarvesterPlotsValid
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"node_id\": \"0xbefeeb05fa599f07c5be2b94b2d872b2516f03101ed49cc53312f086de197913\", \"page\": 0, \"page_size\": 1}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"node_id\": \"befeeb05fa599f07c5be2b94b2d872b2516f03101ed49cc53312f086de197913\",\r\n    \"page\": 0,\r\n    \"page_count\": 1,\r\n    \"plots\": [\r\n        {\r\n            \"file_size\": 674281385,\r\n            \"filename\": \"/plots/plot-k25-2023-03-01-14-52-160798793b22b998133bbf5b2021ed70d24feb0e20d040668c685df2c7caf76a.plot\",\r\n            \"plot_id\": \"0x160798793b22b998133bbf5b2021ed70d24feb0e20d040668c685df2c7caf76a\",\r\n            \"plot_public_key\": \"0xa82069430a7ef8a6491f8b3a5ec64553a33b86e0a713ad03106879231ae77161a0b860df659dbfbb1cc07b6343e95d62\",\r\n            \"pool_contract_puzzle_hash\": \"0xf5daa5a0d83c6a628782a386aa1f94ff041e29c4da4b9b97f91f4d46563d8e9b\",\r\n            \"pool_public_key\": null,\r\n            \"size\": 25,\r\n            \"time_modified\": 1677653720\r\n        }\r\n    ],\r\n    \"success\": true,\r\n    \"total_count\": 1\r\n}"
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
            
            Test_ResponseClasses<GetHarvesterPlots_Response> helper = new Test_ResponseClasses<GetHarvesterPlots_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetHarvesterPlots_Response> helper = new Test_ResponseClasses<GetHarvesterPlots_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
