using CHIA_RPC.Wallet_NS.DLWallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DLWallet_NS
{
    public class Test_CreateNewDL
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"fee\": 1, \"root\": \"0x0000000000000000000000000000000000000000000000000000000000000000\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"launcher_id\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\",\r\n    \"success\": true,\r\n    \"transactions\": [\r\n        {\r\n            \"additions\": [\r\n                {\r\n                    \"amount\": 1,\r\n                    \"parent_coin_info\": \"0xe9158d9c2f0769c00cb0cbccfa90536b99253aebf4a0dfecd5d8298ff4ec55fb\",\r\n                    \"puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\"\r\n                },\r\n                {\r\n                    \"amount\": 99990,\r\n                    \"parent_coin_info\": \"0xe9158d9c2f0769c00cb0cbccfa90536b99253aebf4a0dfecd5d8298ff4ec55fb\",\r\n                    \"puzzle_hash\": \"0x7be3f330dd5cbacdee14f124b51ad744d7504cf4426d92b67953a96c9760d869\"\r\n                },\r\n                {\r\n                    \"amount\": 1,\r\n                    \"parent_coin_info\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\",\r\n                    \"puzzle_hash\": \"0xfddfe3a8ded6d3327204e1a4c8b3ac39725082b53556526f788250cf2b541c84\"\r\n                }\r\n            ],\r\n            \"amount\": 1,\r\n            \"confirmed\": false,\r\n            \"confirmed_at_height\": 0,\r\n            \"created_at_time\": 1669340844,\r\n            \"fee_amount\": 1,\r\n            \"memos\": {},\r\n            \"name\": \"0x7854ba54c10bfa855a876ee2679b565b89afcd7fe44aac0da4a79c28e3381210\",\r\n            \"removals\": [\r\n                {\r\n                    \"amount\": 99992,\r\n                    \"parent_coin_info\": \"0x3089e0080a5b752a0db6fb21dd5fa351743e0266d40b2285c3711ef673b3fb3e\",\r\n                    \"puzzle_hash\": \"0xf9ff3866516f3c2c9861170472bca93763ddfa397796a102e5b2556365941228\"\r\n                },\r\n                {\r\n                    \"amount\": 1,\r\n                    \"parent_coin_info\": \"0xe9158d9c2f0769c00cb0cbccfa90536b99253aebf4a0dfecd5d8298ff4ec55fb\",\r\n                    \"puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\"\r\n                }\r\n            ],\r\n            \"sent\": 10,\r\n            \"sent_to\": [],\r\n            \"spend_bundle\": {\r\n                \"aggregated_signature\": \"0xa07b9e756758bfa6128919998bdd5762b6aefdaab1e137c6ffaad10256f281335a9eac6f6650d9eb1dc42ec5bb0f7136101ed8527ff672221b53dd4577464fff3d070a55096394ee6e685abf714f75a6ac8e1e03a84c8ca7ac3977812a5a0abd\",\r\n                \"coin_spends\": [\r\n                    {\r\n                        \"coin\": {\r\n                            \"amount\": 99992,\r\n                            \"parent_coin_info\": \"0x3089e0080a5b752a0db6fb21dd5fa351743e0266d40b2285c3711ef673b3fb3e\",\r\n                            \"puzzle_hash\": \"0xf9ff3866516f3c2c9861170472bca93763ddfa397796a102e5b2556365941228\"\r\n                        },\r\n                        \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b083cfd185d6b15c4f10d5b1e3310fcc8b2287b199ce1f7a47695a2ab19e3b867426c8e67ac027c8060a2a166b2b6ff2edff018080\",\r\n                        \"solution\": \"0xff80ffff01ffff33ffa0eff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9ff0180ffff33ffa07be3f330dd5cbacdee14f124b51ad744d7504cf4426d92b67953a96c9760d869ff8301869680ffff34ff0180ffff3cffa04d9226e507ebb3bdf2fb3c392d20f9ee82e9265d4cbf535e3d125bf594d48ed880ffff3dffa0cca4d8d32569567369d32e18cdef521dcc617fa71a0e9316e0dcfc44fa74f3c38080ff8080\"\r\n                    },\r\n                    {\r\n                        \"coin\": {\r\n                            \"amount\": 1,\r\n                            \"parent_coin_info\": \"0xe9158d9c2f0769c00cb0cbccfa90536b99253aebf4a0dfecd5d8298ff4ec55fb\",\r\n                            \"puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\"\r\n                        },\r\n                        \"puzzle_reveal\": \"0xff02ffff01ff04ffff04ff04ffff04ff05ffff04ff0bff80808080ffff04ffff04ff0affff04ffff02ff0effff04ff02ffff04ffff04ff05ffff04ff0bffff04ff17ff80808080ff80808080ff808080ff808080ffff04ffff01ff33ff3cff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff0effff04ff02ffff04ff09ff80808080ffff02ff0effff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080\",\r\n                        \"solution\": \"0xffa0fddfe3a8ded6d3327204e1a4c8b3ac39725082b53556526f788250cf2b541c84ff01ffffa00000000000000000000000000000000000000000000000000000000000000000ffa0d4580b76e486b061812848a710bd7d4116b34e2c56fc4357cf8ff4ca63106a848080\"\r\n                    }\r\n                ]\r\n            },\r\n            \"to_address\": \"xch1qgpqyqszqgpqyqszqgpqyqszqgpqyqszqgpqyqszqgpqyqszqgpqzc0j4g\",\r\n            \"to_puzzle_hash\": \"0x0202020202020202020202020202020202020202020202020202020202020202\",\r\n            \"trade_id\": null,\r\n            \"type\": 0,\r\n            \"wallet_id\": 0\r\n        },\r\n        {\r\n            \"additions\": [\r\n                {\r\n                    \"amount\": 1,\r\n                    \"parent_coin_info\": \"0xe9158d9c2f0769c00cb0cbccfa90536b99253aebf4a0dfecd5d8298ff4ec55fb\",\r\n                    \"puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\"\r\n                },\r\n                {\r\n                    \"amount\": 99990,\r\n                    \"parent_coin_info\": \"0xe9158d9c2f0769c00cb0cbccfa90536b99253aebf4a0dfecd5d8298ff4ec55fb\",\r\n                    \"puzzle_hash\": \"0x7be3f330dd5cbacdee14f124b51ad744d7504cf4426d92b67953a96c9760d869\"\r\n                }\r\n            ],\r\n            \"amount\": 1,\r\n            \"confirmed\": false,\r\n            \"confirmed_at_height\": 0,\r\n            \"created_at_time\": 1669340844,\r\n            \"fee_amount\": 1,\r\n            \"memos\": {},\r\n            \"name\": \"0xf6eb22529bad0f8788dc71cc1e45b81a36893d3106b834daece64a86ac039f45\",\r\n            \"removals\": [\r\n                {\r\n                    \"amount\": 99992,\r\n                    \"parent_coin_info\": \"0x3089e0080a5b752a0db6fb21dd5fa351743e0266d40b2285c3711ef673b3fb3e\",\r\n                    \"puzzle_hash\": \"0xf9ff3866516f3c2c9861170472bca93763ddfa397796a102e5b2556365941228\"\r\n                }\r\n            ],\r\n            \"sent\": 0,\r\n            \"sent_to\": [],\r\n            \"spend_bundle\": null,\r\n            \"to_address\": \"xch1alc82gjf2psvqehkdue2es480caruum6e296afx35e82fnwp8k5s6vrrej\",\r\n            \"to_puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\",\r\n            \"trade_id\": null,\r\n            \"type\": 1,\r\n            \"wallet_id\": 1\r\n        }\r\n    ]\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<CreateNewDL_RPC> helper = new Test_RPCClasses<CreateNewDL_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<CreateNewDL_RPC> helper = new Test_RPCClasses<CreateNewDL_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<CreateNewDL_Response> helper = new Test_ResponseClasses<CreateNewDL_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<CreateNewDL_Response> helper = new Test_ResponseClasses<CreateNewDL_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
