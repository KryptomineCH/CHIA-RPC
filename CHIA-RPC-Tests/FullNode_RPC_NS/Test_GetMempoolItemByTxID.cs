using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_RPC_NS
{
    public class Test_GetMempoolItemByTxID
    {
        private string[] ExpectedRPCResults = new string[]
        {
             "{\"tx_id\":\"0x85ad9dbb26a72028f5d5810b24b6a59e58be48ee4e0aefb846a83606fcb671b3\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"mempool_item\": {\r\n    \"additions\": [\r\n      {\r\n        \"amount\": 12575944,\r\n        \"parent_coin_info\": \"0x9f8f27a7289850d48617d729a13269a120f86be267f4f3f4596d19ee1b23d36e\",\r\n        \"puzzle_hash\": \"0x57b09fa466e876fed06a697b0b82e237ad81424fa809df8c7f41fbcfcc7fcc25\"\r\n      },\r\n      {\r\n        \"amount\": 1533495108,\r\n        \"parent_coin_info\": \"0x9f8f27a7289850d48617d729a13269a120f86be267f4f3f4596d19ee1b23d36e\",\r\n        \"puzzle_hash\": \"0xc9b8fd4e5090d6ad8c77daabbaae6de4df3ff90eee71b8bcdec88bbab7c0f5d4\"\r\n      }\r\n    ],\r\n    \"cost\": 10916864,\r\n    \"fee\": 0,\r\n    \"npc_result\": {\r\n      \"clvm_cost\": 416864,\r\n      \"error\": null,\r\n      \"npc_list\": [\r\n        {\r\n          \"coin_name\": \"0x9f8f27a7289850d48617d729a13269a120f86be267f4f3f4596d19ee1b23d36e\",\r\n          \"conditions\": [\r\n            [\r\n              \"0x33\",\r\n              [\r\n                {\r\n                  \"opcode\": \"CREATE_COIN\",\r\n                  \"vars\": [\r\n                    \"0x57b09fa466e876fed06a697b0b82e237ad81424fa809df8c7f41fbcfcc7fcc25\",\r\n                    \"0x00bfe4c8\",\r\n                    \"0x\"\r\n                  ]\r\n                },\r\n                {\r\n                  \"opcode\": \"CREATE_COIN\",\r\n                  \"vars\": [\r\n                    \"0xc9b8fd4e5090d6ad8c77daabbaae6de4df3ff90eee71b8bcdec88bbab7c0f5d4\",\r\n                    \"0x5b674744\",\r\n                    \"0x\"\r\n                  ]\r\n                }\r\n              ]\r\n            ],\r\n            [\r\n              \"0x32\",\r\n              [\r\n                {\r\n                  \"opcode\": \"AGG_SIG_ME\",\r\n                  \"vars\": [\r\n                    \"0x8aff7a77252f575fc56309ea9a6585eb1d8dd84e13b52a71d2474eef5a2f894c3bf1820063bc8c5bdd9e2f837d3a1156\",\r\n                    \"0x07037719d4c9273ee1a6e824098434e48b0b177a695a43f91360a4d90d1475ac\"\r\n                  ]\r\n                }\r\n              ]\r\n            ]\r\n          ],\r\n          \"puzzle_hash\": \"0x524d517cc746beaa0cc4c39e756a3bb8224806e56b54f068c11b9012374506db\"\r\n        }\r\n      ]\r\n    },\r\n    \"program\": \"0xff01ffffffa046fa86a4b2ba9cf949ef815071c9edf750d8548f11efdca0d253f579a62a5da9ffff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b08aff7a77252f575fc56309ea9a6585eb1d8dd84e13b52a71d2474eef5a2f894c3bf1820063bc8c5bdd9e2f837d3a1156ff018080ff845c272c0cffff80ffff01ffff33ffa057b09fa466e876fed06a697b0b82e237ad81424fa809df8c7f41fbcfcc7fcc25ff8400bfe4c880ffff33ffa0c9b8fd4e5090d6ad8c77daabbaae6de4df3ff90eee71b8bcdec88bbab7c0f5d4ff845b67474480ffff3cffa07b5792ad39b97d08565fa14797462c3096a69bfdd4c4746e72cb130f993d0d7b8080ff8080808080\",\r\n    \"removals\": [\r\n      {\r\n        \"amount\": 1546071052,\r\n        \"parent_coin_info\": \"0x46fa86a4b2ba9cf949ef815071c9edf750d8548f11efdca0d253f579a62a5da9\",\r\n        \"puzzle_hash\": \"0x524d517cc746beaa0cc4c39e756a3bb8224806e56b54f068c11b9012374506db\"\r\n      }\r\n    ],\r\n    \"spend_bundle\": {\r\n      \"aggregated_signature\": \"0x96adbe87e0a0778f5d929bf51c915caee75906969a55588930e51cd9dd97aedb6d17e521ca203e7fb99cf91c8f1c20f80e19cbbb8ce1c888e92f2de9f66a4395b67cce0fa94623c6126d6f5f7e9a3c7feb6cee2ab4cf36c329cadda3018ff635\",\r\n      \"coin_spends\": [\r\n        {\r\n          \"coin\": {\r\n            \"amount\": 1546071052,\r\n            \"parent_coin_info\": \"0x46fa86a4b2ba9cf949ef815071c9edf750d8548f11efdca0d253f579a62a5da9\",\r\n            \"puzzle_hash\": \"0x524d517cc746beaa0cc4c39e756a3bb8224806e56b54f068c11b9012374506db\"\r\n          },\r\n          \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b08aff7a77252f575fc56309ea9a6585eb1d8dd84e13b52a71d2474eef5a2f894c3bf1820063bc8c5bdd9e2f837d3a1156ff018080\",\r\n          \"solution\": \"0xff80ffff01ffff33ffa057b09fa466e876fed06a697b0b82e237ad81424fa809df8c7f41fbcfcc7fcc25ff8400bfe4c880ffff33ffa0c9b8fd4e5090d6ad8c77daabbaae6de4df3ff90eee71b8bcdec88bbab7c0f5d4ff845b67474480ffff3cffa07b5792ad39b97d08565fa14797462c3096a69bfdd4c4746e72cb130f993d0d7b8080ff8080\"\r\n        }\r\n      ],\r\n      \"coin_solutions\": null\r\n    },\r\n    \"spend_bundle_name\": \"0x85ad9dbb26a72028f5d5810b24b6a59e58be48ee4e0aefb846a83606fcb671b3\"\r\n  },\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetMempoolItemByTxID_RPC> helper = new Test_RPCClasses<GetMempoolItemByTxID_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetMempoolItemByTxID_RPC> helper = new Test_RPCClasses<GetMempoolItemByTxID_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetMempoolItemByTxID_Response> helper = new Test_ResponseClasses<GetMempoolItemByTxID_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetMempoolItemByTxID_Response> helper = new Test_ResponseClasses<GetMempoolItemByTxID_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
