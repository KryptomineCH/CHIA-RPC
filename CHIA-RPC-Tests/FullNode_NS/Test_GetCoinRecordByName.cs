﻿using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetCoinRecordByName
    {
        private string[] ExpectedRPCResults = new string[]
        {
             "{\"name\":\"0xd78dc3318386f028e090a0f41886983c6e83c7705d1318b93f5309aaa3ddc4b0\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"coin_record\": {\r\n    \"coin\": {\r\n      \"amount\": 921800500,\r\n      \"parent_coin_info\": \"0x055c0286a0eb881f2e950ce4ee30870868d1a951a0e0eb4dc52de5472a9c8b91\",\r\n      \"puzzle_hash\": \"0xb1736654875b1c49b4077b89580c4447f12f1e86fb85d488d7efddd5c6e06be0\"\r\n    },\r\n    \"coinbase\": false,\r\n    \"confirmed_block_index\": 922637,\r\n    \"spent\": true,\r\n    \"spent_block_index\": 922641,\r\n    \"timestamp\": 1632832094\r\n  },\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
            ,"{\r\n    \"coin_record\": {\r\n        \"coin\": {\r\n            \"amount\": 82488031983,\r\n            \"parent_coin_info\": \"0xfdc7526bfc5107e000b4f710c8c5944f11f4e7ce9711c522b6040bc473266313\",\r\n            \"puzzle_hash\": \"0x5198fccb3ca8f14c32a5f05ac50c98209defd2d3ed3ee2a17789a9f6fd7d433b\"\r\n        },\r\n        \"coinbase\": false,\r\n        \"confirmed_block_index\": 3339400,\r\n        \"spent\": true,\r\n        \"spent_block_index\": 3339504,\r\n        \"timestamp\": 1678080343\r\n    },\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetCoinRecordByName_RPC> helper = new Test_RPCClasses<GetCoinRecordByName_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetCoinRecordByName_RPC> helper = new Test_RPCClasses<GetCoinRecordByName_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetCoinRecordByName_Response> helper = new Test_ResponseClasses<GetCoinRecordByName_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetCoinRecordByName_Response> helper = new Test_ResponseClasses<GetCoinRecordByName_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
