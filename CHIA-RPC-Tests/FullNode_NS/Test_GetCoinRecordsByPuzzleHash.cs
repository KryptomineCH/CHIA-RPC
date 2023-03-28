using CHIA_RPC.FullNode_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetCoinRecordsByPuzzleHash
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"puzzle_hash\":\"b1736654875b1c49b4077b89580c4447f12f1e86fb85d488d7efddd5c6e06be0\",\"start_height\":800000,\"end_height\":1000000,\"include_spent_coins\":true}",
            "{\"puzzle_hash\": \"0x6bde1e0c6f9d3b93dc5e7e878723257ede573deeed59e3b4a90f5c86de1a0bd3\", \"start_height\": 3343000, \"end_height\": 3343335, \"include_spent_coins\": true}"
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"coin_records\": [\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1750000000000,\r\n                \"parent_coin_info\": \"0xd13487ef15fb62b578fa9bb5fce8b97fbcb4b3d954827ab4a31561ea3cb1e460\",\r\n                \"puzzle_hash\": \"0x6bde1e0c6f9d3b93dc5e7e878723257ede573deeed59e3b4a90f5c86de1a0bd3\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 3343284,\r\n            \"spent\": true,\r\n            \"spent_block_index\": 3343449,\r\n            \"timestamp\": 1678152756\r\n        },\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1750000000000,\r\n                \"parent_coin_info\": \"0x210a46e3b3460ab75383de012f0085a88aa4559a1f40e1e55da9346e90594120\",\r\n                \"puzzle_hash\": \"0x6bde1e0c6f9d3b93dc5e7e878723257ede573deeed59e3b4a90f5c86de1a0bd3\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 3343197,\r\n            \"spent\": true,\r\n            \"spent_block_index\": 3343449,\r\n            \"timestamp\": 1678151268\r\n        },\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1750000000000,\r\n                \"parent_coin_info\": \"0xb4b179b58837b7a6ca3012495844d345d7f6059fd11f9aa5ccfd64ba598729ea\",\r\n                \"puzzle_hash\": \"0x6bde1e0c6f9d3b93dc5e7e878723257ede573deeed59e3b4a90f5c86de1a0bd3\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 3343293,\r\n            \"spent\": false,\r\n            \"spent_block_index\": 0,\r\n            \"timestamp\": 1678152889\r\n        },\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1750000000000,\r\n                \"parent_coin_info\": \"0xfc0569d4aa5a573efdbeedc4a4e496daff8ded20c9d799261e07c88dd529944a\",\r\n                \"puzzle_hash\": \"0x6bde1e0c6f9d3b93dc5e7e878723257ede573deeed59e3b4a90f5c86de1a0bd3\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 3343050,\r\n            \"spent\": true,\r\n            \"spent_block_index\": 3343240,\r\n            \"timestamp\": 1678148511\r\n        },\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1750000000000,\r\n                \"parent_coin_info\": \"0x9af31c8e1f5cf2af216f807cf42e84d92c436d91617724e117e9effbc13c9e34\",\r\n                \"puzzle_hash\": \"0x6bde1e0c6f9d3b93dc5e7e878723257ede573deeed59e3b4a90f5c86de1a0bd3\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 3343334,\r\n            \"spent\": true,\r\n            \"spent_block_index\": 3343449,\r\n            \"timestamp\": 1678153722\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetCoinRecordsByPuzzleHash_RPC> helper = new Test_RPCClasses<GetCoinRecordsByPuzzleHash_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetCoinRecordsByPuzzleHash_RPC> helper = new Test_RPCClasses<GetCoinRecordsByPuzzleHash_RPC>();
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