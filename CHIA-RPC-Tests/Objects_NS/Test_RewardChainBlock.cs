using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC.Objects_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Objects_NS
{
    public class Test_RewardChainBlock
    {
        private string[] ExpectedResults = new string[]
        {
            "{\r\n  \"challenge_chain_ip_vdf\": null,\r\n  \"challenge_chain_sp_signature\": \"0xa6058eaa6e9cf8469e152e80b4ac4c3cfdca8660cbe44ca50d3771ab1bbf1d040cba842d1b9bf633756159859ecb2ebc05b5f994cef91d5915d4763284e340095a59fb87f2e50fc3f0b6658d1663aeb9d6732373203d7e45df56eb19baeff64c\",\r\n  \"challenge_chain_sp_vdf\": {\r\n    \"challenge\": \"0x04b130f89a8fc37519eab0d835a43ef5547552b2b67c5129fa00f79a57ba8d7f\",\r\n    \"number_of_iterations\": 78200832,\r\n    \"output\": {\r\n      \"data\": \"0x0200dd868820cb2fd82a8a234872a133e5660d55d43c79d10e1cf2258890820acce29d16831fd75f8c70e47bcdb67a264cceef982b151139741812a7aa477a647b1f0c5dd60eebfae9bd41a51911a54324c84c705d8169c7058d27d987fd8c22c0430100\"\r\n    }\r\n  },\r\n  \"height\": null,\r\n  \"infused_challenge_chain_ip_vdf\": null,\r\n  \"is_transaction_block\": null,\r\n  \"pos_ss_cc_challenge_hash\": \"0x04b130f89a8fc37519eab0d835a43ef5547552b2b67c5129fa00f79a57ba8d7f\",\r\n  \"proof_of_space\": {\r\n    \"challenge\": \"0xbe68fc3a34f3d2a6bfe329a3c27f390f5ef63ed9fd3373c3fe12e2c6729a98b4\",\r\n    \"plot_public_key\": \"0x90ca70c963f984d138fe4b97b3bade582513b8ddc115c8fd92033c7f3407df91e5d22313e83e80ea6f02c094636197be\",\r\n    \"pool_contract_puzzle_hash\": null,\r\n    \"pool_public_key\": \"0x8ab8f0eb56216b3f7376fb0462b5000b26f38461dc48f455a98581cec09f889b7c0b38eb42b9e2e2d7edd47d61da13d6\",\r\n    \"proof\": \"0xd1d823b917e7d493ae7bf14ad5fd045ca836bd2b3e97a34efcdc87c2aa4d335b9693c635997f559a2b17ddb7fd87cf352cc8a4a000ecfaaec516a52d7af17a775fff055b7f0f9018f2f6a27d36844f5381197fca792c668207bf7e3927c3f7a8d5854173e134dae95f51ab65f052fbf05b7f6fb046f3309589d6213c713a46a263dc3c2fdda2c7fc7236621e2a6b1164e4b6440aaa6ed403645753e1fb96629d0b7fd80236caad7be571aa1a6fbbfbee9380535e44bc8fac3ef5717e4ad93e3db5e60c617950d966b045ac20401f563a00069ec0052d9145f2f7d16311899d43abbb8b1eb60bcbb33fe82f7ec3c881afd47b16b1a3a34ac23e6a26c013c4e858\",\r\n    \"size\": 32\r\n  },\r\n  \"reward_chain_ip_vdf\": null,\r\n  \"reward_chain_sp_signature\": \"0xa4fb8eb7afc74b945efe1f6b28453a708df7de1f0b56239c5fed50974b896b9bb1f559b49b5a6cf7f4351f1545918b5017e28e81f974bc7bdba88b61f2f9ca8492ab9b7d23371e579b30da9a1a5c7dc0a8fe5605a86165d34c3c552f509fdd7b\",\r\n  \"reward_chain_sp_vdf\": {\r\n    \"challenge\": \"0x05a4bb9d88aa10cf90d6d1b20f85bb2a8ddb9ae7aa0ff5d071d9d9730f6466fc\",\r\n    \"number_of_iterations\": 279309,\r\n    \"output\": {\r\n      \"data\": \"0x020045ba80630612d81da719618b13dbbafc23f569d290b691a64cb2ae9ceb8533fd91f4b4be709dae0c2ac5bf980536afdf6c7bc9d94340bd211221fc863874c00968fc7c0030982ff329a887e498c907b6e002427d30c6f79dad947013dd5681240100\"\r\n    }\r\n  },\r\n  \"signage_point_index\": 37,\r\n  \"total_iters\": 4212156346430,\r\n  \"weight\": null\r\n}"
        };

        [Fact]
        public void Test_ObjectSerialisation()
        {
            Test_ObjectClasses<RewardChainBlock> helper = new Test_ObjectClasses<RewardChainBlock>();
            helper.Test_ObjectSerialisation(ExpectedResults);
        }
        [Fact]
        public void Test_ObjectDiskIO()
        {
            Test_ObjectClasses<RewardChainBlock> helper = new Test_ObjectClasses<RewardChainBlock>();
            helper.Test_ObjectDiskIO(ExpectedResults);
        }
    }
}
