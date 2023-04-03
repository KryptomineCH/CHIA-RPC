using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_SendNotification
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"target\": \"8c436f983d5bcbdb92d6d029a4113da580f2fc43b943e92ddf06a9f54e5f5003\", \"message\": \"fadedcab\", \"amount\": 10000000, \"fee\": 10000000}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"tx\": {\r\n        \"additions\": [\r\n            {\r\n                \"amount\": 10000000,\r\n                \"parent_coin_info\": \"0x7159b046aa0f1af65f561efe6ed1de0beb3341cc28a883892c9bc14d89115ed0\",\r\n                \"puzzle_hash\": \"0x201ef13f780295649cd7e2c8713c575b8dd2568463add6f8d3cfc6b3687d27bd\"\r\n            },\r\n            {\r\n                \"amount\": 249979799998,\r\n                \"parent_coin_info\": \"0x7159b046aa0f1af65f561efe6ed1de0beb3341cc28a883892c9bc14d89115ed0\",\r\n                \"puzzle_hash\": \"0x970afdde67983d39b55475fa1a6bb24eb23e9ba47681fb693e80dee8c9346a83\"\r\n            }\r\n        ],\r\n        \"amount\": 10000000,\r\n        \"confirmed\": false,\r\n        \"confirmed_at_height\": 0,\r\n        \"created_at_time\": 1667386486,\r\n        \"fee_amount\": 10000000,\r\n        \"memos\": {\r\n            \"f74fb363fbdeef3f6bcf7a0664a8ef76ea3e5f22bb4ffc9a1f9ef23b9329ae28\": \"fadedcab\"\r\n        },\r\n        \"name\": \"0x749898b3efcd50882283fb879e80e42cd59340c41943832b4daf896b5e6e80e4\",\r\n        \"removals\": [\r\n            {\r\n                \"amount\": 249999799998,\r\n                \"parent_coin_info\": \"0xf634ab1fc513d90d63c7eed840eb49a034f804b2d910418614776333590aab8c\",\r\n                \"puzzle_hash\": \"0x8c436f983d5bcbdb92d6d029a4113da580f2fc43b943e92ddf06a9f54e5f5003\"\r\n            }\r\n        ],\r\n        \"sent\": 0,\r\n        \"sent_to\": [],\r\n        \"spend_bundle\": {\r\n            \"aggregated_signature\": \"0xb9db8ff2e29f00ec98b17019e13f11daea890a8ef82d1019b7655308c14623a0c15d37504b1e742d0f29132e6225c7f505a2c75f93ea0940f50615c3b83c2b851c5a76f5f027c8d823c85df7bea57e3dd702f03e2d8997173c1bb4ca64b97b87\",\r\n            \"coin_spends\": [\r\n                {\r\n                    \"coin\": {\r\n                        \"amount\": 249999799998,\r\n                        \"parent_coin_info\": \"0xf634ab1fc513d90d63c7eed840eb49a034f804b2d910418614776333590aab8c\",\r\n                        \"puzzle_hash\": \"0x8c436f983d5bcbdb92d6d029a4113da580f2fc43b943e92ddf06a9f54e5f5003\"\r\n                    },\r\n                    \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b0acc98d7c361cb95a6d16a2ee6a5dccb55d3beab9e7dbb52ebd7e4a94a8290166cf8e745d67a6eb36de6687141da09dccff018080\",\r\n                    \"solution\": \"0xff80ffff01ffff33ffa0201ef13f780295649cd7e2c8713c575b8dd2568463add6f8d3cfc6b3687d27bdff8400989680ffffa08c436f983d5bcbdb92d6d029a4113da580f2fc43b943e92ddf06a9f54e5f5003ff84fadedcab8080ffff33ffa0970afdde67983d39b55475fa1a6bb24eb23e9ba47681fb693e80dee8c9346a83ff853a33f509be80ffff34ff840098968080ffff3cffa0ef1272dc555d2fa0b17eb8a2d50dc507ce1f873de3443f3b7e36a3c802b0863b80ffff3dffa0a2d1d50e1bf8bd6f08e02885631ea6cbe7aa91d9de9809b5c37a7858fc0ad94b8080ff8080\"\r\n                },\r\n                {\r\n                    \"coin\": {\r\n                        \"amount\": 10000000,\r\n                        \"parent_coin_info\": \"0x7159b046aa0f1af65f561efe6ed1de0beb3341cc28a883892c9bc14d89115ed0\",\r\n                        \"puzzle_hash\": \"0x201ef13f780295649cd7e2c8713c575b8dd2568463add6f8d3cfc6b3687d27bd\"\r\n                    },\r\n                    \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff04ffff04ff04ffff04ff05ffff04ff0bff80808080ffff04ffff04ff06ffff01ff808080ff808080ffff04ffff01ff333cff018080ffff04ffff01a08c436f983d5bcbdb92d6d029a4113da580f2fc43b943e92ddf06a9f54e5f5003ffff04ffff018400989680ff01808080\",\r\n                    \"solution\": \"0x80\"\r\n                }\r\n            ]\r\n        },\r\n        \"to_address\": \"xch1yq00z0mcq22kf8xhuty8z0zhtwxay45yvwkad7xnelrtx6ray77sshkp7r\",\r\n        \"to_puzzle_hash\": \"0x201ef13f780295649cd7e2c8713c575b8dd2568463add6f8d3cfc6b3687d27bd\",\r\n        \"trade_id\": null,\r\n        \"type\": 1,\r\n        \"wallet_id\": 1\r\n    }\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<SendNotification_RPC> helper = new Test_RPCClasses<SendNotification_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<SendNotification_RPC> helper = new Test_RPCClasses<SendNotification_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<SendNotification_Response> helper = new Test_ResponseClasses<SendNotification_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<SendNotification_Response> helper = new Test_ResponseClasses<SendNotification_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
