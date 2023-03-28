using CHIA_RPC.Farmer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Farmer_NS
{
    public class Test_GetHarvestersSummary
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"harvesters\": [\r\n        {\r\n            \"connection\": {\r\n                \"host\": \"127.0.0.1\",\r\n                \"node_id\": \"0xbefeeb05fa599f07c5be2b94b2d872b2516f03101ed49cc53312f086de197913\",\r\n                \"port\": 61934\r\n            },\r\n            \"duplicates\": 0,\r\n            \"failed_to_open_filenames\": 0,\r\n            \"last_sync_time\": 1677653735.9421551,\r\n            \"no_key_filenames\": 18,\r\n            \"plots\": 1,\r\n            \"syncing\": null,\r\n            \"total_plot_size\": 674281385\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetHarvestersSummary_Response> helper = new Test_ResponseClasses<GetHarvestersSummary_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetHarvestersSummary_Response> helper = new Test_ResponseClasses<GetHarvestersSummary_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
