using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetBlockRecord
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"block_record\": {\r\n    \"challenge_block_info_hash\": \"0x08dbc5c9f4676bad4cd2fad9b120afefdc107ffdd4066f73f14baf2a204f13df\",\r\n    \"challenge_vdf_output\": {\r\n      \"data\": \"0x0000af33fa9862d4e257498e9ba0c3cda09c1389d1fde0facd72ea26f5371ba94deb18137d95bd83b1c7afefba6293feda91d744d014c747e132db0247839e9bd00d790c06f753a9d344c80c455a86ecd979c31687ece60748a5d62dca4723c3780d0906\"\r\n    },\r\n    \"deficit\": 9,\r\n    \"farmer_puzzle_hash\": \"0x8f5474dc460673a39c96bb0fdfea933f5d1269c138e47a67f07872c04803a4e7\",\r\n    \"fees\": 0,\r\n    \"finished_challenge_slot_hashes\": null,\r\n    \"finished_infused_challenge_slot_hashes\": null,\r\n    \"finished_reward_slot_hashes\": null,\r\n    \"header_hash\": \"0x3723909a7374c4c88cf00ab9b15365f4988f5bdb2d51bac23f6af939fe40f56c\",\r\n    \"height\": 101,\r\n    \"infused_challenge_vdf_output\": {\r\n      \"data\": \"0x0300a4bc6790208e73245df6a85b3f7beac0d17e73972b414a7f94cf1e3c3e9bb4a400516d368cfa8b1814f3b5163fe5a54a1fe35781f58290673c8d9f56cd23b94c138b21207d6aa6f3049f8ad805eb99b28292e06e748117e78e13598cee9945670100\"\r\n    },\r\n    \"overflow\": false,\r\n    \"pool_puzzle_hash\": \"0x8f5474dc460673a39c96bb0fdfea933f5d1269c138e47a67f07872c04803a4e7\",\r\n    \"prev_hash\": \"0x9a6c8728021574c5f3242370831b9fde7a0421f4448b4848276fe1652580c6a7\",\r\n    \"prev_transaction_block_hash\": \"0x6c94307cb88f37ca002936769246579824ecadc77fe1e445d31165e6958288e8\",\r\n    \"prev_transaction_block_height\": 97,\r\n    \"required_iters\": 1045145,\r\n    \"reward_claims_incorporated\": [\r\n      {\r\n        \"amount\": 1750000000000,\r\n        \"parent_coin_info\": \"0xccd5bb71183532bff220ba46c268991a00000000000000000000000000000061\",\r\n        \"puzzle_hash\": \"0x8f3dff600992a0b77aefbe8eb81dd4f233b9126f3b67557594b5a927d6e6d588\"\r\n      },\r\n      {\r\n        \"amount\": 250000000000,\r\n        \"parent_coin_info\": \"0x3ff07eb358e8255a65c30a2dce0e5fbb00000000000000000000000000000061\",\r\n        \"puzzle_hash\": \"0x8f3dff600992a0b77aefbe8eb81dd4f233b9126f3b67557594b5a927d6e6d588\"\r\n      }\r\n    ],\r\n    \"reward_infusion_new_challenge\": \"0x100b6fbe0778ae13e48e9bf71b7de4e31e5c1d73a0b041e0277f4a76b5338604\",\r\n    \"signage_point_index\": 19,\r\n    \"sub_epoch_summary_included\": null,\r\n    \"sub_slot_iters\": 134217728,\r\n    \"timestamp\": 1616164827,\r\n    \"total_iters\": 449835673,\r\n    \"weight\": 714\r\n  },\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetBlockRecord_Response> helper = new Test_ResponseClasses<GetBlockRecord_Response>();
            helper.Test_ResponseSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetBlockRecord_Response> helper = new Test_ResponseClasses<GetBlockRecord_Response>();
            helper.Test_ResponseDiskIO(ExpectedResults);
        }
    }
}
