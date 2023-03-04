using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC.General;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_RPC_NS
{
    public class Test_GetCoinRecordsByHint
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"hint\":\"0x6916079cc35f377e96fa34af87d14f58ce1f08d864f93e89bbdd04a26f591540\",\"start_height\":400000,\"end_height\":1900000,\"include_spent_coins\":true}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"coin_records\": [\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 10000,\r\n        \"parent_coin_info\": \"0x13eb187994e143a122c868d47e3e1201ddaf8fbaee13e6b04293ff527ec7b8e8\",\r\n        \"puzzle_hash\": \"0xd229b55df95852e99f1c2708a7248380676ead58fd6a3cbfb44c870204506751\"\r\n      },\r\n      \"coinbase\": false,\r\n      \"confirmed_block_index\": 1868037,\r\n      \"spent\": true,\r\n      \"spent_block_index\": 1868399,\r\n      \"timestamp\": 1650533680\r\n    },\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 10000,\r\n        \"parent_coin_info\": \"0x7fcc1791720603314f134cf47dc80c2d36bae1dd236eada570993d285f7437a5\",\r\n        \"puzzle_hash\": \"0xd229b55df95852e99f1c2708a7248380676ead58fd6a3cbfb44c870204506751\"\r\n      },\r\n      \"coinbase\": false,\r\n      \"confirmed_block_index\": 1872712,\r\n      \"spent\": false,\r\n      \"spent_block_index\": 0,\r\n      \"timestamp\": 1650620445\r\n    }\r\n  ],\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {

            Test_RPCClasses<GetCoinRecordsByHint_RPC> helper = new Test_RPCClasses<GetCoinRecordsByHint_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetCoinRecordsByHint_RPC> helper = new Test_RPCClasses<GetCoinRecordsByHint_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {

            Test_ResponseClasses<GetCoinRecordsByNames_Response> helper = new Test_ResponseClasses<GetCoinRecordsByNames_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetCoinRecordsByNames_Response> helper = new Test_ResponseClasses<GetCoinRecordsByNames_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
