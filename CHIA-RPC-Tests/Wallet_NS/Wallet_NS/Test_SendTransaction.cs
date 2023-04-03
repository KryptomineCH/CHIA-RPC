using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_SendTransaction
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 1, \"address\": \"xch1fev2qaclwpcue9kx4p39dzfxpzaavvcz5v3lhx77cxha7f0tjjlsngh5k0\", \"amount\": 1000, \"fee\": 1, \"memos\":[\"memo1\"]}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"transaction\": {\r\n        \"additions\": [\r\n            {\r\n                \"amount\": 1000,\r\n                \"parent_coin_info\": \"0xfecaf9d1cffe1b71f00aee7816ea90562b18307d4461757e23f097703340beb7\",\r\n                \"puzzle_hash\": \"0x4e58a0771f7071cc96c6a86256892608bbd63302a323fb9bdec1afdf25eb94bf\"\r\n            },\r\n            {\r\n                \"amount\": 999996796,\r\n                \"parent_coin_info\": \"0xfecaf9d1cffe1b71f00aee7816ea90562b18307d4461757e23f097703340beb7\",\r\n                \"puzzle_hash\": \"0x138373343443d3cdf6bd033244f32d904dd93e1ad2772f120955c0d8d761b722\"\r\n            }\r\n        ],\r\n        \"amount\": 1000,\r\n        \"confirmed\": false,\r\n        \"confirmed_at_height\": 0,\r\n        \"created_at_time\": 1669261889,\r\n        \"fee_amount\": 1,\r\n        \"memos\": {\r\n            \"029b8689abda7f4ff4871e1cd69eb32725a0cda8520b751bcf774fb681e19bc5\": \"6d656d6f31\"\r\n        },\r\n        \"name\": \"0x94a6b6a2353a8f49b6dc30d7141272df14bc82727fd0d82a18680605b2a90051\",\r\n        \"removals\": [\r\n            {\r\n                \"amount\": 999997797,\r\n                \"parent_coin_info\": \"0x81d6dac68bb566d696a62629e1e08edd5b684d35c3ee8c7164b1c3a457514203\",\r\n                \"puzzle_hash\": \"0xd84faa841550d718863fc1139ff880c8366a546ab7dc567a672a14c7ddf5b4b7\"\r\n            }\r\n        ],\r\n        \"sent\": 0,\r\n        \"sent_to\": [],\r\n        \"spend_bundle\": {\r\n            \"aggregated_signature\": \"0xa95fba5e9e310d1c096bb44e27d98b070b7591be29d3f174ac42bcad39ec5e8a356747851c3df456973c96f55884dbb913247000368b0d1fa3518f11dae0ed45cb8f0961899aa7ee2102c58265d9460a31c33bd896ce9a2ef377bbc6419343b0\",\r\n            \"coin_spends\": [\r\n                {\r\n                    \"coin\": {\r\n                        \"amount\": 999997797,\r\n                        \"parent_coin_info\": \"0x81d6dac68bb566d696a62629e1e08edd5b684d35c3ee8c7164b1c3a457514203\",\r\n                        \"puzzle_hash\": \"0xd84faa841550d718863fc1139ff880c8366a546ab7dc567a672a14c7ddf5b4b7\"\r\n                    },\r\n                    \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b0a5abd588cc5a2c873ee37809ea33432b7a87aaf8370eba7f9806bc1eac517034b3850cc7a4f2550f108b8a124d3dbbc3ff018080\",\r\n                    \"solution\": \"0xff80ffff01ffff33ffa04e58a0771f7071cc96c6a86256892608bbd63302a323fb9bdec1afdf25eb94bfff8203e8ffff856d656d6f318080ffff33ffa0138373343443d3cdf6bd033244f32d904dd93e1ad2772f120955c0d8d761b722ff843b9abd7c80ffff34ff0180ffff3cffa086ec6c5fe3716c6e0b39c0049a3d164f491c3347c4fd36196ecc561b5cf347da8080ff8080\"\r\n                }\r\n            ]\r\n        },\r\n        \"to_address\": \"xch1fev2qaclwpcue9kx4p39dzfxpzaavvcz5v3lhx77cxha7f0tjjlsngh5k0\",\r\n        \"to_puzzle_hash\": \"0x4e58a0771f7071cc96c6a86256892608bbd63302a323fb9bdec1afdf25eb94bf\",\r\n        \"trade_id\": null,\r\n        \"type\": 1,\r\n        \"wallet_id\": 1\r\n    },\r\n    \"transaction_id\": \"0x94a6b6a2353a8f49b6dc30d7141272df14bc82727fd0d82a18680605b2a90051\"\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<SendTransaction_RPC> helper = new Test_RPCClasses<SendTransaction_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<SendTransaction_RPC> helper = new Test_RPCClasses<SendTransaction_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<Transaction_Response> helper = new Test_ResponseClasses<Transaction_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Transaction_Response> helper = new Test_ResponseClasses<Transaction_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
