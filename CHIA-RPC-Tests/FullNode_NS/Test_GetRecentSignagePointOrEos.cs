using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetRecentSignagePointOrEos
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"challenge_hash\": \"0xc97facdb04807e595f46f76961febeea245c044d35152e4397e5c4878d5bce37\"}"
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"eos\": {\r\n        \"challenge_chain\": {\r\n            \"challenge_chain_end_of_slot_vdf\": {\r\n                \"challenge\": \"0xc948e91995a270a48e8b6cc8db3a944ed74aef4d03be0f325205fba903445c70\",\r\n                \"number_of_iterations\": 146800640,\r\n                \"output\": {\r\n                    \"data\": \"0x020027a053f82874cfe8dc53c08d2ce5e791cab0391279898099ad8abfe21412725b45eb35dc60eb98592c14c7b5d8a305e2c3f77b3f63ee0fe7d04a9708d4e361283bf7d747a58edb778b5cb52608ed4fa42e8def51a0a6aba9d985aecd05710b410100\"\r\n                }\r\n            },\r\n            \"infused_challenge_chain_sub_slot_hash\": \"0x7a26f76f0f6eda6d8033fd93306d10c01eb71a69fc0471a322feb855e8c67257\",\r\n            \"new_difficulty\": null,\r\n            \"new_sub_slot_iters\": null,\r\n            \"subepoch_summary_hash\": null\r\n        },\r\n        \"infused_challenge_chain\": {\r\n            \"infused_challenge_chain_end_of_slot_vdf\": {\r\n                \"challenge\": \"0xac729280140c4d5bc4793c485042397e09c86683559142d0156a1d89cd5c691e\",\r\n                \"number_of_iterations\": 131095906,\r\n                \"output\": {\r\n                    \"data\": \"0x0200dc26e19b58d71a48623ea87b174cff7ead8b9d6e7bfff842f3bc0fd7694627943e82fb8c7df88676f9b780083bf9430efb95f261fd6ec48ae133141888801a071f0302dea9f1d021609c6864f3323c8d264fd99131f56a4f43e0fda35a16ba060706\"\r\n                }\r\n            }\r\n        },\r\n        \"proofs\": {\r\n            \"challenge_chain_slot_proof\": {\r\n                \"normalized_to_identity\": false,\r\n                \"witness\": \"0x0300385a0b580b0ba47b04264b29a21543a4797f2a40d7a631c2b7ed2029906d0df45c66f115fa8ee8ea8a08d59a2f590c82ca37ce73a9b5e90400878dc7aa253c2fc776b7494ddc41d3d4eee78323ed8d5cc5b6d63752bf562b464254952ab019480100000000000004dee098971949dde52ecba255fe335978a979f17d20431981ce52b7ab1bc2fbeed0c8650100e02163d8a06f70d49002a9941b629b9e1fcb5e442961e0cdb934a85105fa34c5f4426de2658ce1dc6d7aed7019607cac7e57fde35b7201ec0b4184b9f024d91a7fc011a6a415b1cc679f7f6a00a95575c5f4f29b891b0d7c3d4fc9e9d066f126030100000000000e9d04a47b9e85b9450b1c526b4b017d9526ba5275115f27688f9777bd9bfa386f2f1a3902003c4ac70e6197f97b61cc8a010e7e0f8761c861ef92e06e699d36557735836f36f1c996e453339be55b942fee499787d180f1aa255ed53e353ca0c981ba2b596095172319067aeeff0f7c63557c2bfb63a3b5c38c1423ad46dcbdf3a9e68fff3e0100\",\r\n                \"witness_type\": 2\r\n            },\r\n            \"infused_challenge_chain_slot_proof\": {\r\n                \"normalized_to_identity\": false,\r\n                \"witness\": \"0x0100de23f1da9d925937af12f7d0ab6ca0d9e6d61db06a3e160c776bae38f84903543745ef0c56200af5fde336cee3773fe4a48570c333edf8e2245a02c476cf7f3d5317d04993f41baa68d493f0014f6b6c98d8faba91943f11fd1dcdf253b57a030100000000000004dee0c98772ed5956507ae19690fb7ca410582c58c370995e3b8509cdac90eefe628a83000016233c3f1075c33ad60b06a0d6bb9c2003b5c2f9ec97c1e0f79f32689a9245831b23b647e57c08c5b9a5bc14fa2206f605fbb0cc5fbd26465eb48c8dba2aaf10676c18b87b197fb4567640357dbdda113ab6441f06b78bde8ccd98a41d4d7b1d010000000000000e9d04ca9d9e8e96a9770a769bf4403da504df78dd33c5ff9ed1990525f9f5e4e0f9445b0000fd514bf86e5d96e3be474abb40daf8b5efa76cde333bb840bd69caf751e0863497f94267addae1e39346e21f43534d1e6052f3d9b278ba931bdbb047ba7efb5a51fcaa91ad1f79f7dbec6805da9a32375492c91bd22615e086516131f134643f0100\",\r\n                \"witness_type\": 2\r\n            },\r\n            \"reward_chain_slot_proof\": {\r\n                \"normalized_to_identity\": false,\r\n                \"witness\": \"0x0200e631425613dd99e65b0aa7f2d98c6033b69c597796e1b86f9ec380e609c47492d5bdafd50c5101a49946a888f1633dcf412c1dc3276cc14c7764007282e14f4ccb0fd0eabc80e45c5dad7e559bd64149714a49b9363b132b7116fdb66b669a250100000000000004dee0f3272ed4d79f6ba93c75bc953deb52b53955842faecb96a1dec32686c4bf14017103008ba373b8593f8e964b6f5582b46e4de4b7dae5db66c49e92b50288533a3c5909f341ea917ad3a4a832e71b28af685876e6bbb2176f737a8c1c33066e00078f4350f4ed25d638a9c0b7962388207cf43a64f1bf08174e0458be1bf8e28b201222010000000000000e9d049285451259f6f4ef346a92daf3b1f1979215e5a7f85393c8197a44d5038929f3c1000034cf575bc6ebaa5ff8ed3d318820e44ce070eea4f617dafca320d43044f9b1ec3a2a9c531662a9a2abaf37b15db2ea7283f0fee1772bd40a2fbcc03114fdca5fbb77b5c7668bd1eef4e52f4daf56422a68986d0a9a38453fa6a4b33b8333d9390100\",\r\n                \"witness_type\": 2\r\n            }\r\n        },\r\n        \"reward_chain\": {\r\n            \"challenge_chain_sub_slot_hash\": \"0xc97facdb04807e595f46f76961febeea245c044d35152e4397e5c4878d5bce37\",\r\n            \"deficit\": 16,\r\n            \"end_of_slot_vdf\": {\r\n                \"challenge\": \"0x9775fc146e7df73e6052cd132707d17f0f9691024b33be59fac47681b5483a4a\",\r\n                \"number_of_iterations\": 1436581,\r\n                \"output\": {\r\n                    \"data\": \"0x01004837f41f0f4bbddae80e964719de25c68429324a057c37cd49baea6934d82d7f6b83fbe4610ef018301302c5d39315c597234f55b12bdf627024bbe0761d070e81e5d45f40b974f9c3c883ae074d648449fdb501aeb3e8e478dabfe927ce2f0c0603\"\r\n                }\r\n            },\r\n            \"infused_challenge_chain_sub_slot_hash\": \"0x7a26f76f0f6eda6d8033fd93306d10c01eb71a69fc0471a322feb855e8c67257\"\r\n        }\r\n    },\r\n    \"reverted\": false,\r\n    \"success\": true,\r\n    \"time_received\": 1678155344.7621934\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
            Test_RPCClasses<GetRecentSignagePointOrEos_RPC> helper = new Test_RPCClasses<GetRecentSignagePointOrEos_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetRecentSignagePointOrEos_RPC> helper = new Test_RPCClasses<GetRecentSignagePointOrEos_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetRecentSignagePointOrEos_Response> helper = new Test_ResponseClasses<GetRecentSignagePointOrEos_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetRecentSignagePointOrEos_Response> helper = new Test_ResponseClasses<GetRecentSignagePointOrEos_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
