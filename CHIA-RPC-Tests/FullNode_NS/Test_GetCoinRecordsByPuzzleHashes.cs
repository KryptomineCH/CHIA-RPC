using CHIA_RPC.FullNode_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetCoinRecordsByPuzzleHashes
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"puzzle_hashes\":[\"0x6776391535247e1617ee17cabc6a13932faa3d3f2094a55fe95ccefcbb1a749a\",\"0x37bde5f12f697eac8b4f2093656814ce3f05a485702bd1cbd6e436652d99dd96\",\"0xd51afe647b6cb50f4feaa437c1e51d13ee0019831498f5a01418daece0d20a37\"],\"start_height\":400000,\"end_height\":1900000,\"include_spent_coins\":false}"
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"coin_records\": [\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 2499841800000,\r\n                \"parent_coin_info\": \"0x0c614ccc3714b6e9c21846aae8019d85e1dd4dcd4a2ba58149aefd94bb745db3\",\r\n                \"puzzle_hash\": \"0x71c79abd24b6cf63a92a5d8d1ca88014fd3b39cb3c300876370aac477a13b598\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 3343375,\r\n            \"spent\": false,\r\n            \"spent_block_index\": 0,\r\n            \"timestamp\": 1678154445\r\n        },\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 2416791265997,\r\n                \"parent_coin_info\": \"0x605dd680d2cf4714c022348b1f591641a1d31154c6e5e8d87051e34716f43cfb\",\r\n                \"puzzle_hash\": \"0x71c79abd24b6cf63a92a5d8d1ca88014fd3b39cb3c300876370aac477a13b598\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 3343378,\r\n            \"spent\": false,\r\n            \"spent_block_index\": 0,\r\n            \"timestamp\": 1678154484\r\n        },\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1750000000000,\r\n                \"parent_coin_info\": \"0xb4b179b58837b7a6ca3012495844d345d7f6059fd11f9aa5ccfd64ba598729ea\",\r\n                \"puzzle_hash\": \"0x6bde1e0c6f9d3b93dc5e7e878723257ede573deeed59e3b4a90f5c86de1a0bd3\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 3343293,\r\n            \"spent\": false,\r\n            \"spent_block_index\": 0,\r\n            \"timestamp\": 1678152889\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetCoinRecordsByPuzzleHashes_RPC> helper = new Test_RPCClasses<GetCoinRecordsByPuzzleHashes_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetCoinRecordsByPuzzleHashes_RPC> helper = new Test_RPCClasses<GetCoinRecordsByPuzzleHashes_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {

            Test_ResponseClasses<GetCoinRecords_Response> helper = new Test_ResponseClasses<GetCoinRecords_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetCoinRecords_Response> helper = new Test_ResponseClasses<GetCoinRecords_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
