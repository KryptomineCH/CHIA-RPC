using CHIA_RPC.Datalayer_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_CreateDataStore
    {
        private string[] ExpectedRPCResults = new string[]
        {
             "{\"fee\":\"1000\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"id\": \"31264f736a07683097a4b1bbedfa3b4d12631af1595b3905907a441bafb79c61\",\r\n  \"success\": true,\r\n  \"txs\": [\r\n    {\r\n      \"additions\": [\r\n        {\r\n          \"amount\": 1,\r\n          \"parent_coin_info\": \"0x7a97a37cac145bd13b4da93c496dc32e83a526918727e0f6a1c305af996726e9\",\r\n          \"puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\"\r\n        },\r\n        {\r\n          \"amount\": 10983998895994,\r\n          \"parent_coin_info\": \"0x7a97a37cac145bd13b4da93c496dc32e83a526918727e0f6a1c305af996726e9\",\r\n          \"puzzle_hash\": \"0xdc2d295cce761abd4123d03e7135c670d6c0ad39ec4e66503cec336439e8a2fb\"\r\n        },\r\n        {\r\n          \"amount\": 1,\r\n          \"parent_coin_info\": \"0x31264f736a07683097a4b1bbedfa3b4d12631af1595b3905907a441bafb79c61\",\r\n          \"puzzle_hash\": \"0xba017f832d945b23f7b0a3dc4850a3bb9aff6e92cd2a333a7987b60ced1dab0a\"\r\n        }\r\n      ],\r\n      \"amount\": 1,\r\n      \"confirmed\": false,\r\n      \"confirmed_at_height\": 0,\r\n      \"created_at_time\": 1660784389,\r\n      \"fee_amount\": 1000,\r\n      \"memos\": [],\r\n      \"name\": \"0x76d1e179a15f097c116e75c73486c3d47f7ebbb4791b5216a2828807f4ad9a5f\",\r\n      \"removals\": [\r\n        {\r\n          \"amount\": 10983998896995,\r\n          \"parent_coin_info\": \"0x110a907b5676553746e75623dd32ad231c080e9dabe50a99bc43beebaaa13531\",\r\n          \"puzzle_hash\": \"0x3f5ea6f0f46c1d76fbc72e4116895536f7b7b167f9d9e5a38d708ad3e3fd434a\"\r\n        },\r\n        {\r\n          \"amount\": 1,\r\n          \"parent_coin_info\": \"0x7a97a37cac145bd13b4da93c496dc32e83a526918727e0f6a1c305af996726e9\",\r\n          \"puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\"\r\n        }\r\n      ],\r\n      \"sent\": 10,\r\n      \"sent_to\": [],\r\n      \"spend_bundle\": {\r\n        \"aggregated_signature\": \"0xb600c2cd9ddafb6655e14fe99b293a742746ba82ef3f05b8bb3a375af0d3824011a1909348a16745e19f826aceb2534e08c0d939f01eb92f9bfac5eb8cf0c97bad353d5e0fa89f95f329c45c5797d59fe4b1a8ce23fa6a64bd2ac385170fedd5\",\r\n        \"coin_spends\": [\r\n          {\r\n            \"coin\": {\r\n              \"amount\": 10983998896995,\r\n              \"parent_coin_info\": \"0x110a907b5676553746e75623dd32ad231c080e9dabe50a99bc43beebaaa13531\",\r\n              \"puzzle_hash\": \"0x3f5ea6f0f46c1d76fbc72e4116895536f7b7b167f9d9e5a38d708ad3e3fd434a\"\r\n            },\r\n            \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b0a50a6518ead71676147c2ee69111eaf7ad247fc624f4ae8e7c2a7fdfd28c8a31560183506bfa9c657af220e0caacc378ff018080\",\r\n            \"solution\": \"0xff80ffff01ffff33ffa0eff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9ff0180ffff33ffa0dc2d295cce761abd4123d03e7135c670d6c0ad39ec4e66503cec336439e8a2fbff8609fd695a377a80ffff34ff8203e880ffff3cffa0b7fe85c45d675c4798e49b89c334dc345acdecb7955467e849c367b47495700e80ffff3dffa0cb7418c46c146ecf8515b5ec562c8d6884c6ff5a28daecfdb4a37301b3b92bb38080ff8080\"\r\n          },\r\n          {\r\n            \"coin\": {\r\n              \"amount\": 1,\r\n              \"parent_coin_info\": \"0x7a97a37cac145bd13b4da93c496dc32e83a526918727e0f6a1c305af996726e9\",\r\n              \"puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\"\r\n            },\r\n            \"puzzle_reveal\": \"0xff02ffff01ff04ffff04ff04ffff04ff05ffff04ff0bff80808080ffff04ffff04ff0affff04ffff02ff0effff04ff02ffff04ffff04ff05ffff04ff0bffff04ff17ff80808080ff80808080ff808080ff808080ffff04ffff01ff33ff3cff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff0effff04ff02ffff04ff09ff80808080ffff02ff0effff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080\",\r\n            \"solution\": \"0xffa0ba017f832d945b23f7b0a3dc4850a3bb9aff6e92cd2a333a7987b60ced1dab0aff01ffffa00000000000000000000000000000000000000000000000000000000000000000ffa0a5927d1773b24c508abb547f7fb803c57841dc2ef85c3074707355830ddb1f7e8080\"\r\n          }\r\n        ]\r\n      },\r\n      \"to_puzzle_hash\": \"0x0202020202020202020202020202020202020202020202020202020202020202\",\r\n      \"trade_id\": null,\r\n      \"type\": 0,\r\n      \"wallet_id\": 0\r\n    },\r\n    {\r\n      \"additions\": [\r\n        {\r\n          \"amount\": 1,\r\n          \"parent_coin_info\": \"0x7a97a37cac145bd13b4da93c496dc32e83a526918727e0f6a1c305af996726e9\",\r\n          \"puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\"\r\n        },\r\n        {\r\n          \"amount\": 10983998895994,\r\n          \"parent_coin_info\": \"0x7a97a37cac145bd13b4da93c496dc32e83a526918727e0f6a1c305af996726e9\",\r\n          \"puzzle_hash\": \"0xdc2d295cce761abd4123d03e7135c670d6c0ad39ec4e66503cec336439e8a2fb\"\r\n        }\r\n      ],\r\n      \"amount\": 1,\r\n      \"confirmed\": false,\r\n      \"confirmed_at_height\": 0,\r\n      \"created_at_time\": 1660784389,\r\n      \"fee_amount\": 1000,\r\n      \"memos\": [],\r\n      \"name\": \"0xa3128e387ecc892f9b4d7e0178ee3fab5620659b0dabcf34dd3305e0e10d221d\",\r\n      \"removals\": [\r\n        {\r\n          \"amount\": 10983998896995,\r\n          \"parent_coin_info\": \"0x110a907b5676553746e75623dd32ad231c080e9dabe50a99bc43beebaaa13531\",\r\n          \"puzzle_hash\": \"0x3f5ea6f0f46c1d76fbc72e4116895536f7b7b167f9d9e5a38d708ad3e3fd434a\"\r\n        }\r\n      ],\r\n      \"sent\": 0,\r\n      \"sent_to\": [],\r\n      \"spend_bundle\": null,\r\n      \"to_puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\",\r\n      \"trade_id\": null,\r\n      \"type\": 1,\r\n      \"wallet_id\": 1\r\n    }\r\n  ]\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<CreateDataStore_RPC> helper = new Test_RPCClasses<CreateDataStore_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<CreateDataStore_RPC> helper = new Test_RPCClasses<CreateDataStore_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<CreateDataStore_Response> helper = new Test_ResponseClasses<CreateDataStore_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<CreateDataStore_Response> helper = new Test_ResponseClasses<CreateDataStore_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
