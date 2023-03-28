using CHIA_RPC.FullNode_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetCoinRecordsByParentIDs
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"parent_ids\":[\"0x83103a520d363d9356d2bba5be786f56ca83cdccdaad1f7db74cabe3a6ec6195\",\"0xccd5bb71183532bff220ba46c268991a00000000000000000000000000000061\"],\"start_height\":4,\"end_height\":1900000,\"include_spent_coins\":true}"
            ,"{\"start_height\":4, \"end_height\": 1900000, \"include_spent_coins\": true, \"parent_ids\": [\"0x83103a520d363d9356d2bba5be786f56ca83cdccdaad1f7db74cabe3a6ec6195\", \"0xccd5bb71183532bff220ba46c268991a00000000000000000000000000000061\"]}"
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"coin_records\": [\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 6164491200000,\r\n                \"parent_coin_info\": \"0x83103a520d363d9356d2bba5be786f56ca83cdccdaad1f7db74cabe3a6ec6195\",\r\n                \"puzzle_hash\": \"0xfbefc3b96a0c2d1dfe8f4dce7c546fd849a3b0b5cf4d75a794f07ac6bb96a80e\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 472472,\r\n            \"spent\": true,\r\n            \"spent_block_index\": 472488,\r\n            \"timestamp\": 1624451109\r\n        },\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1750000000000,\r\n                \"parent_coin_info\": \"0xccd5bb71183532bff220ba46c268991a00000000000000000000000000000061\",\r\n                \"puzzle_hash\": \"0x8f3dff600992a0b77aefbe8eb81dd4f233b9126f3b67557594b5a927d6e6d588\"\r\n            },\r\n            \"coinbase\": true,\r\n            \"confirmed_block_index\": 101,\r\n            \"spent\": true,\r\n            \"spent_block_index\": 341109,\r\n            \"timestamp\": 1616164827\r\n        },\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1016446400000,\r\n                \"parent_coin_info\": \"0x83103a520d363d9356d2bba5be786f56ca83cdccdaad1f7db74cabe3a6ec6195\",\r\n                \"puzzle_hash\": \"0x4ed688a013a7059d3619440c6f73d9c3759cdd8c55ece7ec86ded295aa2da8fe\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 472472,\r\n            \"spent\": true,\r\n            \"spent_block_index\": 2472263,\r\n            \"timestamp\": 1624451109\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };


        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetCoinRecordsByParentIDs_RPC> helper = new Test_RPCClasses<GetCoinRecordsByParentIDs_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetCoinRecordsByParentIDs_RPC> helper = new Test_RPCClasses<GetCoinRecordsByParentIDs_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {

            Test_ResponseClasses<GetCoinRecords_Response> helper = new Test_ResponseClasses<GetCoinRecords_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetCoinRecords_Response> helper = new Test_ResponseClasses<GetCoinRecords_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
