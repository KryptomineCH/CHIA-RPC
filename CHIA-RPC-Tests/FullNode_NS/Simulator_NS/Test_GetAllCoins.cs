using CHIA_RPC.FullNode_NS.Simulator_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS.Simulator_NS
{
    public class Test_GetAllCoins
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"include_spent_coins\": true}"
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"coin_records\": [\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1750000000000,\r\n                \"parent_coin_info\": \"0xeb8c4d20b322be8d9fddbf9412016bdf00000000000000000000000000000011\",\r\n                \"puzzle_hash\": \"0x5fb3e0ccc23760a7f917a81e7872cc921f9ddbc86582dfb4f64eee66fad5e740\"\r\n            },\r\n            \"coinbase\": true,\r\n            \"confirmed_block_index\": 18,\r\n            \"spent_block_index\": 0,\r\n            \"timestamp\": 1664294613\r\n        },\r\n        {\r\n            \"coin\": {\r\n                \"amount\": 1750000000000,\r\n                \"parent_coin_info\": \"0xeb8c4d20b322be8d9fddbf9412016bdf00000000000000000000000000000007\",\r\n                \"puzzle_hash\": \"0x5fb3e0ccc23760a7f917a81e7872cc921f9ddbc86582dfb4f64eee66fad5e740\"\r\n            },\r\n            \"coinbase\": true,\r\n            \"confirmed_block_index\": 9,\r\n            \"spent_block_index\": 0,\r\n            \"timestamp\": 1664294445\r\n        },   ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<GetAllCoins_RPC> helper = new Test_RPCClasses<GetAllCoins_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetAllCoins_RPC> helper = new Test_RPCClasses<GetAllCoins_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetAllCoins_Response> helper = new Test_ResponseClasses<GetAllCoins_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetAllCoins_Response> helper = new Test_ResponseClasses<GetAllCoins_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
