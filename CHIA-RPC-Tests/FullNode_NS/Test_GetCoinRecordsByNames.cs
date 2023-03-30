using CHIA_RPC.FullNode_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetCoinRecordsByNames
    {
        private string[] ExpectedRPCResults = new string[]
        {
             "{\"start_height\": 400000, \"end_height\": 1900000, \"include_spent_coins\": true, \"names\":[\"0x83103a520d363d9356d2bba5be786f56ca83cdccdaad1f7db74cabe3a6ec6195\", \"0x3a071ea8bb51d724bf3841fae40370ff18fe1e71a890b731ed1e67f026550995\"]}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"coin_records\": [\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 126,\r\n                \"parent_coin_info\": \"0x6a16808f534325b809df04f64277c84b7e6f3d01b84ba7146858e3546ab97db4\",\r\n                \"puzzle_hash\": \"0x8949f28258c35e47dceebf3a14a206c389ec1b85261ba217688e7b8303eb9b0f\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 1856394,\r\n            \"spent\": true,\r\n            \"spent_block_index\": 1872533,\r\n            \"timestamp\": 1650315703\r\n        },\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 7180937600000,\r\n                \"parent_coin_info\": \"0x459d10d2d2c9eef036825b7b4a8a7618b0e3137641ab6abde515c0af0ddf9f85\",\r\n                \"puzzle_hash\": \"0xabd433d8744b06a4cf2b5872a951bf66358af6f6bcb54075a85708aff6e90ed8\"\r\n            },\r\n            \"coinbase\": false,\r\n            \"confirmed_block_index\": 472449,\r\n            \"spent\": true,\r\n            \"spent_block_index\": 472472,\r\n            \"timestamp\": 1624450760\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetCoinRecordsByNames_RPC> helper = new Test_RPCClasses<GetCoinRecordsByNames_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetCoinRecordsByNames_RPC> helper = new Test_RPCClasses<GetCoinRecordsByNames_RPC>();
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
