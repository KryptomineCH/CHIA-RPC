using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC.General;

namespace CHIA_RPC_Tests.FullNode_RPC_NS
{
    public class Test_GetAdditionsAndRemovals
    {
        [Fact]
        public void Test_BuildingRequest()
        {
            string expectedResult = "{\"header_hash\":\"bc89e52aabf264bd1fe4c11ee8aacfc7c03899a3f2604981000bddaedcc7167d\"}";
            HeaderHash_RPC rpc = new HeaderHash_RPC
            {
                header_hash = "bc89e52aabf264bd1fe4c11ee8aacfc7c03899a3f2604981000bddaedcc7167d"
            };
            string rpcString = rpc.ToString();
            Assert.Equal(expectedResult, rpcString);
        }
        [Fact]
        public void Test_SavingRequest()
        {
            HeaderHash_RPC originalRPC = new HeaderHash_RPC
            {
                header_hash = "bc89e52aabf264bd1fe4c11ee8aacfc7c03899a3f2604981000bddaedcc7167d"
            };
            originalRPC.SaveRpcToFile("Test_GetAdditionsAndRemovals_Test_SavingRequest");
            HeaderHash_RPC newRPC = HeaderHash_RPC.LoadRpcFromFile("Test_GetAdditionsAndRemovals_Test_SavingRequest");
            Assert.Equal(originalRPC.ToString(), newRPC.ToString());
        }
        [Fact]
        public void Test_LoadingResponse()
        {
            string expectedResult = "{\r\n  \"additions\": [\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 413530529990,\r\n        \"parent_coin_info\": \"0x35d9841f95f8f32050a76b0e24eefd2764d820c80f966eb30a79a2cb871588d1\",\r\n        \"puzzle_hash\": \"0xebebc91efa8d5f7ed3de7a3c66b6a17abad2208494d053f8ca828c97ec7625c3\"\r\n      },\r\n      \"coinbase\": false,\r\n      \"confirmed_block_index\": 922652,\r\n      \"spent\": false,\r\n      \"spent_block_index\": 0,\r\n      \"timestamp\": 1632832355\r\n    },\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 80838001,\r\n        \"parent_coin_info\": \"0x6ddcbcef132c1f2de149527da87c0eec9aa337c66932b926da1a554c7da9aff3\",\r\n        \"puzzle_hash\": \"0x6d23c175031242cf236f847bfd5ae288259bc17aa7022dad0629298995d9d462\"\r\n      },\r\n      \"coinbase\": false,\r\n      \"confirmed_block_index\": 922652,\r\n      \"spent\": false,\r\n      \"spent_block_index\": 0,\r\n      \"timestamp\": 1632832355\r\n    }\r\n  ],\r\n  \"removals\": [\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 99899995990,\r\n        \"parent_coin_info\": \"0x8e9cac58448e58eee5a0fe8a9c9ab5ba094c6c560f9c340ba8d29905123a0757\",\r\n        \"puzzle_hash\": \"0x37963ebd69b61f042322f8db0b6eed0fa386940c4fac31756c994e0bc5ab3f8e\"\r\n      },\r\n      \"coinbase\": false,\r\n      \"confirmed_block_index\": 922641,\r\n      \"spent\": true,\r\n      \"spent_block_index\": 922652,\r\n      \"timestamp\": 1632832185\r\n    },\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 921799000,\r\n        \"parent_coin_info\": \"0xd78dc3318386f028e090a0f41886983c6e83c7705d1318b93f5309aaa3ddc4b0\",\r\n        \"puzzle_hash\": \"0xc45165adea743c6c31433801e220acd15ed9d1cacfa907a8dd1afacdb4e70da6\"\r\n      },\r\n      \"coinbase\": false,\r\n      \"confirmed_block_index\": 922641,\r\n      \"spent\": true,\r\n      \"spent_block_index\": 922652,\r\n      \"timestamp\": 1632832185\r\n    }\r\n  ],\r\n  \"success\": true,\r\n  \"error\": null\r\n}";
            GetAdditionsAndRemovals_Response rpc = GetAdditionsAndRemovals_Response.LoadResponseFromString(expectedResult);
            string rpcString = rpc.ToString();
            Assert.Equal(expectedResult, rpcString);
        }
        [Fact]
        public void Test_SavingResponse()
        {
            string expectedResult = "{\r\n  \"additions\": [\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 413530529990,\r\n        \"parent_coin_info\": \"0x35d9841f95f8f32050a76b0e24eefd2764d820c80f966eb30a79a2cb871588d1\",\r\n        \"puzzle_hash\": \"0xebebc91efa8d5f7ed3de7a3c66b6a17abad2208494d053f8ca828c97ec7625c3\"\r\n      },\r\n      \"coinbase\": false,\r\n      \"confirmed_block_index\": 922652,\r\n      \"spent\": false,\r\n      \"spent_block_index\": 0,\r\n      \"timestamp\": 1632832355\r\n    },\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 80838001,\r\n        \"parent_coin_info\": \"0x6ddcbcef132c1f2de149527da87c0eec9aa337c66932b926da1a554c7da9aff3\",\r\n        \"puzzle_hash\": \"0x6d23c175031242cf236f847bfd5ae288259bc17aa7022dad0629298995d9d462\"\r\n      },\r\n      \"coinbase\": false,\r\n      \"confirmed_block_index\": 922652,\r\n      \"spent\": false,\r\n      \"spent_block_index\": 0,\r\n      \"timestamp\": 1632832355\r\n    }\r\n  ],\r\n  \"removals\": [\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 99899995990,\r\n        \"parent_coin_info\": \"0x8e9cac58448e58eee5a0fe8a9c9ab5ba094c6c560f9c340ba8d29905123a0757\",\r\n        \"puzzle_hash\": \"0x37963ebd69b61f042322f8db0b6eed0fa386940c4fac31756c994e0bc5ab3f8e\"\r\n      },\r\n      \"coinbase\": false,\r\n      \"confirmed_block_index\": 922641,\r\n      \"spent\": true,\r\n      \"spent_block_index\": 922652,\r\n      \"timestamp\": 1632832185\r\n    },\r\n    {\r\n      \"coin\": {\r\n        \"amount\": 921799000,\r\n        \"parent_coin_info\": \"0xd78dc3318386f028e090a0f41886983c6e83c7705d1318b93f5309aaa3ddc4b0\",\r\n        \"puzzle_hash\": \"0xc45165adea743c6c31433801e220acd15ed9d1cacfa907a8dd1afacdb4e70da6\"\r\n      },\r\n      \"coinbase\": false,\r\n      \"confirmed_block_index\": 922641,\r\n      \"spent\": true,\r\n      \"spent_block_index\": 922652,\r\n      \"timestamp\": 1632832185\r\n    }\r\n  ],\r\n  \"success\": true,\r\n  \"error\": null\r\n}";
            GetAdditionsAndRemovals_Response originalResponse = GetAdditionsAndRemovals_Response.LoadResponseFromString(expectedResult);
            originalResponse.SaveResponseToFile("Test_GetAdditionsAndRemovals_Test_SavingResponse");
            GetAdditionsAndRemovals_Response loadedResponse = GetAdditionsAndRemovals_Response.LoadResponseFromFile("Test_GetAdditionsAndRemovals_Test_SavingResponse");
            Assert.Equal(originalResponse.ToString(), loadedResponse.ToString());
        }
    }
}
