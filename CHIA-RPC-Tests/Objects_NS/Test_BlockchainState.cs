using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_BlockchainState
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"difficulty\": 3008,\r\n  \"genesis_challenge_initialized\": true,\r\n  \"mempool_size\": 0,\r\n  \"peak\": {\r\n    \"challenge_block_info_hash\": \"0x436bd6f7db0de90db868594b862d9388a231402f3c601282773ccab8e54914f3\",\r\n    \"challenge_vdf_output\": {\r\n      \"data\": \"0x01001ea29503859966e59024fb3a903e424a1652e724483b86928febca5e308d7039b7138847e436e5f1ba5f6c025f6c6ff275c070149079877463aa077f571d0706516723eaa51113c8ec624a005dc73704fcccefa26bb0eefbb9af15eb5c61b6090201\"\r\n    },\r\n    \"deficit\": 15,\r\n    \"farmer_puzzle_hash\": \"0xe2f70baf739bdaf59e360d3a3e2d4ff8cb89f150d9b60b8e91b870e41b58f2fa\",\r\n    \"fees\": null,\r\n    \"finished_challenge_slot_hashes\": null,\r\n    \"finished_infused_challenge_slot_hashes\": null,\r\n    \"finished_reward_slot_hashes\": null,\r\n    \"header_hash\": \"0xf42b4e77315d79ddfb3d64becb21e26ebff5408bda4d1b7c3782fd04f49ec0bb\",\r\n    \"height\": 914661,\r\n    \"infused_challenge_vdf_output\": null,\r\n    \"overflow\": false,\r\n    \"pool_puzzle_hash\": \"0x71afdce401a0f2a6f03de6287902eacfa38502d6667b04da36e32c3930171ce4\",\r\n    \"prev_hash\": \"0x902ca8dfdd08e79dec3c96837f4e99162508ffaeff730c68af1fde9b86cbf61b\",\r\n    \"prev_transaction_block_hash\": null,\r\n    \"prev_transaction_block_height\": 914660,\r\n    \"required_iters\": 852774,\r\n    \"reward_claims_incorporated\": null,\r\n    \"reward_infusion_new_challenge\": \"0x5566434842f375434f9a558a3de5907db44903036c3de1573852afffbd1991bd\",\r\n    \"signage_point_index\": 0,\r\n    \"sub_epoch_summary_included\": null,\r\n    \"sub_slot_iters\": 136314880,\r\n    \"timestamp\": null,\r\n    \"total_iters\": 3330271511334,\r\n    \"weight\": 1393823840\r\n  },\r\n  \"space\": 40110198681182961664,\r\n  \"sub_slot_iters\": 136314880,\r\n  \"sync\": {\r\n    \"sync_mode\": false,\r\n    \"sync_progress_height\": 0,\r\n    \"sync_tip_height\": 0,\r\n    \"synced\": false\r\n  }\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<BlockchainState> helper = new Test_ObjectClasses<BlockchainState>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<BlockchainState> helper = new Test_ObjectClasses<BlockchainState>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
