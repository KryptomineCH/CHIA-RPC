﻿using CHIA_RPC.FullNode_NS;
using CHIA_RPC_Tests.Testhelpers;
using System.Xml.Schema;

namespace CHIA_RPC_Tests.FullNode_NS
{
    public class Test_GetUnfinishedBlockHeaders
    {
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"headers\": [\r\n    {\r\n      \"challenge_chain_sp_proof\": {\r\n        \"normalized_to_identity\": false,\r\n        \"witness\": \"0x0100a2d202a8582166f41a5478a2bebadaaa623224419820f88901c1f3df56ac7371a8b662fe4c8a9dba45c2de82f7bc4d2348dfc55b0ef08f5531e3d0607be127197f3e550e7bf044850f2711486cc775c9d3ae3e254f737a286de4c9ac54019e420100000000000000f230942683fcf5cd4aea65c1e1f3b34fdd0966ef2a52b80c912adae7820e5306cb24e10300ffe0d2a2cf9b93db55b719542b883f835c1398363d37c287241398e6fc7292265557e095b809f9aaab154e74355f3d2f8460438586a7c5fbf340a62cbecd4f0e9b1f775d923f609c603d8ed807b2af50c19e5ca4ed1f60f8ffac3cde4117e7120100000000000002d758b6f095a90eb49eadeb1f3ea24df7270e06e7d627735aacb3306d3a8f120f4b4afd0200cdcbe3ab1cbb123c85c58a7916954e1f0c8148da72d1d3f72f1a6d4c423039e9f0320d7a93da8c2f737a3aeba0c38e938f05addc5d16ffd74ffca3d812dfe8522a307efdcb6392ede54afec7dc5176ef439d5288717eca375f64818e543ff24d0100\",\r\n        \"witness_type\": 2\r\n      },\r\n      \"finished_sub_slots\": [],\r\n      \"foliage\": {\r\n        \"foliage_block_data\": {\r\n          \"extension_data\": \"0x0000000000000000000000000000000000000000000000000000000003a2c7c9\",\r\n          \"farmer_reward_puzzle_hash\": \"0x77c08f1ae7c6ae4808c8c07f7d99363b0c00f0ad416c4a292b5341282e38dc35\",\r\n          \"pool_signature\": \"0xb39237cb5db187f1a3f210f5fff1bee0f7b66e466eb1bd393204768d982335f3ee5c7faec138e334110d80ce47e46704067db26f8a2c5267bbaefb74ea9ef144bd51a8fe388ba68727f3e246b8aefef427b2e2e299ed976d27ba2789bcf7cb7c\",\r\n          \"pool_target\": {\r\n            \"max_height\": 0,\r\n            \"puzzle_hash\": \"0x77c08f1ae7c6ae4808c8c07f7d99363b0c00f0ad416c4a292b5341282e38dc35\"\r\n          },\r\n          \"unfinished_reward_block_hash\": \"0xcc705bd601b6c9e3081bde85db2a917d312716136e077c37e7f5090c2685733f\"\r\n        },\r\n        \"foliage_block_data_signature\": \"0x838f98f281429094df95adbd023f7ac285ffe08d7e584e0e1c9d6def26b215f86753f52d781116eab02ac949beea9b9c009b6242ba97568f226aeafc2bf4fc83b791fffb2d636a8b0473727b5bee6a560b09df3dabf9d2b4ca707a35f22e5f38\",\r\n        \"foliage_transaction_block_hash\": \"0x813540921a72fdfcbe47858e087b9e848df5fe2d8213288a6df71acf22214cf2\",\r\n        \"foliage_transaction_block_signature\": \"0xb0db31ae6d773b3b27009cfdd9a232b54f840e00caf24a5a87e8c27e96933acd03d8e553ea62e9179ed4078ed86b9e471987e8803ff4311c9d0727d876490012af403094e3baa4f627785d846c60f770494c253ea7a09e7bc24a53ad683e4704\",\r\n        \"prev_block_hash\": \"0x0b08b0ceca65b371729ad3731ba5982c0c63d487cd526874fb907c3e683eb185\",\r\n        \"reward_block_hash\": \"0xcc705bd601b6c9e3081bde85db2a917d312716136e077c37e7f5090c2685733f\"\r\n      },\r\n      \"foliage_transaction_block\": {\r\n        \"additions_root\": \"0x2c04ae163cf5916b774e2591b075560b6dface2b242d10cbb9f40b134cdf2080\",\r\n        \"filter_hash\": \"0xea0d50f296d1bdaccc00be16e48a310dd4fa1fcf575065761add6366498b3fbf\",\r\n        \"prev_transaction_block_hash\": \"0xf88a87d79c8e65ca559b7e74a9aca3a6f9fc90e6bb9dc6cb4602ed599610876e\",\r\n        \"removals_root\": \"0x409433654e3b7a530da6cf55c93abde2c7a71a2ea9814883ceef956f8fed61ea\",\r\n        \"timestamp\": 1636577488,\r\n        \"transactions_info_hash\": \"0x9f3d9cb990c560fb66d4e09a9da79844ce933a809bc754eb151775f3600b73ed\"\r\n      },\r\n      \"reward_chain_block\": {\r\n        \"challenge_chain_ip_vdf\": null,\r\n        \"challenge_chain_sp_signature\": \"0xa6058eaa6e9cf8469e152e80b4ac4c3cfdca8660cbe44ca50d3771ab1bbf1d040cba842d1b9bf633756159859ecb2ebc05b5f994cef91d5915d4763284e340095a59fb87f2e50fc3f0b6658d1663aeb9d6732373203d7e45df56eb19baeff64c\",\r\n        \"challenge_chain_sp_vdf\": {\r\n          \"challenge\": \"0x04b130f89a8fc37519eab0d835a43ef5547552b2b67c5129fa00f79a57ba8d7f\",\r\n          \"number_of_iterations\": 78200832,\r\n          \"output\": {\r\n            \"data\": \"0x0200dd868820cb2fd82a8a234872a133e5660d55d43c79d10e1cf2258890820acce29d16831fd75f8c70e47bcdb67a264cceef982b151139741812a7aa477a647b1f0c5dd60eebfae9bd41a51911a54324c84c705d8169c7058d27d987fd8c22c0430100\"\r\n          }\r\n        },\r\n        \"height\": null,\r\n        \"infused_challenge_chain_ip_vdf\": null,\r\n        \"is_transaction_block\": null,\r\n        \"pos_ss_cc_challenge_hash\": \"0x04b130f89a8fc37519eab0d835a43ef5547552b2b67c5129fa00f79a57ba8d7f\",\r\n        \"proof_of_space\": {\r\n          \"challenge\": \"0xbe68fc3a34f3d2a6bfe329a3c27f390f5ef63ed9fd3373c3fe12e2c6729a98b4\",\r\n          \"plot_public_key\": \"0x90ca70c963f984d138fe4b97b3bade582513b8ddc115c8fd92033c7f3407df91e5d22313e83e80ea6f02c094636197be\",\r\n          \"pool_contract_puzzle_hash\": null,\r\n          \"pool_public_key\": \"0x8ab8f0eb56216b3f7376fb0462b5000b26f38461dc48f455a98581cec09f889b7c0b38eb42b9e2e2d7edd47d61da13d6\",\r\n          \"proof\": \"0xd1d823b917e7d493ae7bf14ad5fd045ca836bd2b3e97a34efcdc87c2aa4d335b9693c635997f559a2b17ddb7fd87cf352cc8a4a000ecfaaec516a52d7af17a775fff055b7f0f9018f2f6a27d36844f5381197fca792c668207bf7e3927c3f7a8d5854173e134dae95f51ab65f052fbf05b7f6fb046f3309589d6213c713a46a263dc3c2fdda2c7fc7236621e2a6b1164e4b6440aaa6ed403645753e1fb96629d0b7fd80236caad7be571aa1a6fbbfbee9380535e44bc8fac3ef5717e4ad93e3db5e60c617950d966b045ac20401f563a00069ec0052d9145f2f7d16311899d43abbb8b1eb60bcbb33fe82f7ec3c881afd47b16b1a3a34ac23e6a26c013c4e858\",\r\n          \"size\": 32\r\n        },\r\n        \"reward_chain_ip_vdf\": null,\r\n        \"reward_chain_sp_signature\": \"0xa4fb8eb7afc74b945efe1f6b28453a708df7de1f0b56239c5fed50974b896b9bb1f559b49b5a6cf7f4351f1545918b5017e28e81f974bc7bdba88b61f2f9ca8492ab9b7d23371e579b30da9a1a5c7dc0a8fe5605a86165d34c3c552f509fdd7b\",\r\n        \"reward_chain_sp_vdf\": {\r\n          \"challenge\": \"0x05a4bb9d88aa10cf90d6d1b20f85bb2a8ddb9ae7aa0ff5d071d9d9730f6466fc\",\r\n          \"number_of_iterations\": 279309,\r\n          \"output\": {\r\n            \"data\": \"0x020045ba80630612d81da719618b13dbbafc23f569d290b691a64cb2ae9ceb8533fd91f4b4be709dae0c2ac5bf980536afdf6c7bc9d94340bd211221fc863874c00968fc7c0030982ff329a887e498c907b6e002427d30c6f79dad947013dd5681240100\"\r\n          }\r\n        },\r\n        \"signage_point_index\": 37,\r\n        \"total_iters\": 4212156346430,\r\n        \"weight\": null\r\n      },\r\n      \"reward_chain_sp_proof\": {\r\n        \"normalized_to_identity\": false,\r\n        \"witness\": \"0x0100fd954fa240aa1684b66b89b9758a65f15ad90974315d730d26936f2a85266cfbc62f9a19fdf51dd8478063cc446adb4b1f54d52361a332825bf9abba1836470c0cf1894e901f541d025e26b986f6c49cb831af15c5bc96c79491da7f44a53a100201000000000000f23084d7fd81dc24c094a18d117901f47b0488fb3e5b807e1e48d0fd63c58cfffc710b0300698065626064242f57e8bc0d281b52387e1c851659c84c61b5ab8994d63798558863582f58d39abb15aa1742f4cd2715b88b7ec18f2709c7e1606360ef90803b0f2e41fa35879a24a02d9ca6812d72f0fc3a1cf62491e88cfdc2fc371a1d22420201000000000002d758c780237a30a9542ffe2f11c935fae0efe53180a9477a9e37466f9563a60250f5a7020065a8d6450b4c4b3fe3fd7eb047eea915d0addf140615a746616515ad73673b583c74dcfa3cd03f62e99c984fd5c6e1aaf254199a0c7464b18d40dc42c6928d351d7daa81209d5e10501f475b8a3bb5952a2754d8e728c3445ff58b66f590ca020200\",\r\n        \"witness_type\": 2\r\n      },\r\n      \"transactions_filter\": \"0x\"\r\n    }\r\n  ],\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
            ,"{\r\n    \"headers\": [\r\n        {\r\n            \"challenge_chain_sp_proof\": {\r\n                \"normalized_to_identity\": false,\r\n                \"witness\": \"0x0300ca3027dc768d1894470dbecde30493ab040b86d51cfd2d969be08af17030f222087aae7b32809afa1aa956f57ae932905c2ae91dc20eaa2eb8ecb59b65966a191b46dc28d10b06968bb0354f0070f9ab95f630131bdf7eafcc2c038ddb9790190401000000000001be7c88dfe3104cb9ff068568d46b4b3edbfe1b4effb2e3cb9d5bf42e57808a59b3f231020098ceddbffa9f0b27b2879228bfcbbdaab4f50608673886d36e81c9b3af1683e509ff92adcc79c4313898e654a6ab0ea27c3725d8b96e29a151c6e414afb51f5c7178c34f482d367ca4b1f7ec7459464171aeabe59cb8dd74fee98f24702c9d2c01000000000000053c3ceeb304ad81ae251a2fc3d8988da7c084c39dfac2fec36ec3e9412f49240a46a709030096053c4468ca4622bb9dfce38ee52f7c2791857d6486b2bf4f7f753c0b880b4870a0618ed071d472971936558406638d68fbb226284e26c26640077347fe963af79be18d9afdc60a50fdfd9a834103ac558b745a953951d98a49f6801cced1450100\",\r\n                \"witness_type\": 2\r\n            },\r\n            \"finished_sub_slots\": [],\r\n            \"foliage\": {\r\n                \"foliage_block_data\": {\r\n                    \"extension_data\": \"0x0000000000000000000000000000000000000000000000000000000003a2c7c9\",\r\n                    \"farmer_reward_puzzle_hash\": \"0x907491ca39c35bc1f9a6eda33f7c0f97a9f583975088dad7216f1edd79f522ae\",\r\n                    \"pool_signature\": \"0xa286f7bcbce546f4ec55f9a37a67adf504d92e1afa711d488568c09914ad227e1fb4b1315c24150a2b9f8af8c437ec12068b5a6bc3eedb25827061971e99b305024d6fe7fa7c61d8180cd92f267f8fcc2bc5c40cded03d194b6d3ff8cb9966b9\",\r\n                    \"pool_target\": {\r\n                        \"max_height\": 0,\r\n                        \"puzzle_hash\": \"0x907491ca39c35bc1f9a6eda33f7c0f97a9f583975088dad7216f1edd79f522ae\"\r\n                    },\r\n                    \"unfinished_reward_block_hash\": \"0x84eeb3aad2cb25d554da983bbd58cfdec83f082da6d06a3eb9943cfb89578989\"\r\n                },\r\n                \"foliage_block_data_signature\": \"0xaab8ff2a66014493d01021bfffc99d772140f5b891548165c8cccef9164be7a37aa1dba638e3983e11546921bc1c8ebb16e150c379c7fca3591f22dbc21e8925ca57e239f3210ac0b8f8da37a3622969db2082f3ffba5781d8b12a08d55a6e33\",\r\n                \"foliage_transaction_block_hash\": \"0x43e5fc07f3351fa4e5eba530ef6c9e784c9bf37d3bfd61a11714beef4a4ec91a\",\r\n                \"foliage_transaction_block_signature\": \"0x8a04372cef9f2f2fc7dee74f6739fb8d45fcb70d7831378fb64080b9f83f24b3385cc5d8d284595c03033837b722a6bd0d1db4df76f589f399e4e12c565bf85d85a44a6965c22cf84bf715f25861c22bd6c99b6f6c6a120efd9609d67ceb255e\",\r\n                \"prev_block_hash\": \"0x13e5ef5813e2ad994184c953d7e7dff766428ea5ed0580c2149dabc66747b57a\",\r\n                \"reward_block_hash\": \"0x84eeb3aad2cb25d554da983bbd58cfdec83f082da6d06a3eb9943cfb89578989\"\r\n            },\r\n            \"foliage_transaction_block\": {\r\n                \"additions_root\": \"0x62b9bf13134a0e3bab44dc4550d75686f3f24c3fbb9a20b3eb58022ed0a99a74\",\r\n                \"filter_hash\": \"0xe43808ab7534cd3ed1645e476e00ca2ac4926b1dc09ab96d0cf744507fd41b02\",\r\n                \"prev_transaction_block_hash\": \"0x2c534d6a32e7a53a3fc33baa8ab05504d7721d3395911e36144bd9b0589d4f25\",\r\n                \"removals_root\": \"0x0000000000000000000000000000000000000000000000000000000000000000\",\r\n                \"timestamp\": 1678076245,\r\n                \"transactions_info_hash\": \"0x22d97282cf7d02d4fbbba37bf58fd1fdcd4fe24f5be95a30f0dc92828c1ba1c0\"\r\n            },\r\n            \"reward_chain_block\": {\r\n                \"challenge_chain_sp_signature\": \"0x8cc561c0cc79e73b44506954c4ebd85e7667bdbe13f253e96fdd1cb895b612f266510429f6b82858a60c36e59e333a770456e8c096d8de5372d51884edf11803b6e426d04db5b8b6ba5743ed8033b7b11dc57d9a8fee211c4389771d61fdcc90\",\r\n                \"challenge_chain_sp_vdf\": {\r\n                    \"challenge\": \"0x7e7fc1d74f8d710b7a17017504bfd7e9863973cb60bbfefe1b6ce5588a1d4735\",\r\n                    \"number_of_iterations\": 36700160,\r\n                    \"output\": {\r\n                        \"data\": \"0x0100290f45aa544d64443cd183b5b0bb0eddc112fb4fcbba73159b1b04b6476203f8417d10f36868adb6cda400b0b9b625d57b07ba6bb258d9f0b825601b414a6942c3b69e32858409996ec8619160623d56db115aaa5661816f4453dfc6e434082a0100\"\r\n                    }\r\n                },\r\n                \"pos_ss_cc_challenge_hash\": \"0x7e7fc1d74f8d710b7a17017504bfd7e9863973cb60bbfefe1b6ce5588a1d4735\",\r\n                \"proof_of_space\": {\r\n                    \"challenge\": \"0x685cda6bb6c77da65df3f93da220ff55581985b3472a6d06fe146c833fee4626\",\r\n                    \"plot_public_key\": \"0x86cc6327dbe8d0c8646689f789ab4560e2b10bd5892131eed2b020ce409fb8fb76b873a439f7040dc9609179bde5d152\",\r\n                    \"pool_contract_puzzle_hash\": null,\r\n                    \"pool_public_key\": \"0xb87e833fd714490b72eb7a390cfc1605f79b60d3f18d909e094f25001535842bc48be9db46fa465fbf9db26a3d7f4b6d\",\r\n                    \"proof\": \"0xa223d3fda3c718d0b1be65f33a901f7b8c5434ef7e46fd7321ad66572b1d87d52853ed6fb3137453536e85b09ad02bf52f7278780d349993e1081c1c2437c1a249ea5f30dbf13a6204ba0655634f9428312a0402df2ecf16de6f4187fc556e74040d8b0729cc7fc135133f6cc75b402353e412e9a13a906816c73dfea94c82fdf659bfe856bca057693210d1ac950a384038dd4c69186444509491a4efaea6c998e87990e75ec77b6575df62d1819558203886f769de990b674fbf770fd6437a59804a889e49a1c8cdd9e8085e515e7dbbe436ae077e6238df26e5565c8e6645e1cc3b560e1c7d87411a58f0ac1562db3ee19b79c14df0403a7aad9b8609a7cf\",\r\n                    \"size\": 32\r\n                },\r\n                \"reward_chain_sp_signature\": \"0xb75969dd2cd7d701aba2719b512c0675b598d632e0175473d2644a48eb9e385a113f205653e2d5a133a831067e3026dc036c37974efbda351e1a6eac95d4b81fe4fdde71ea68d44454208bc72f1428cbb56ccfcd64b5a1120d34c125cfd83e46\",\r\n                \"reward_chain_sp_vdf\": {\r\n                    \"challenge\": \"0x772c50de1700f58b608ff8fc77a4310aa475c9c9c98a932a446845370a52b500\",\r\n                    \"number_of_iterations\": 514688,\r\n                    \"output\": {\r\n                        \"data\": \"0x03007ca6f95897feb5e6a9fb9f6538437f089eee4de540bfde9a2b0ba831fbd21aef9ab4b46c172224e39f420aac719a2cc6a36cd5ae78f79b1057523e3167ecb512350f2e6348175eefac8709a68463ca7ae4067bae81e9814fc57f9b348d935c2b0100\"\r\n                    }\r\n                },\r\n                \"signage_point_index\": 16,\r\n                \"total_iters\": 13800993484113\r\n            },\r\n            \"reward_chain_sp_proof\": {\r\n                \"normalized_to_identity\": false,\r\n                \"witness\": \"0x0300fa111380d3200d60319b5942b6d64db9b4566687af69151ff753883d16cb1b6114950a2f8866196befd3a29b86122f9f4bcc1edccdf24e832f633589ac3bed4d09627f07b52fa80f6a58208a9315c2084cca9806b056bdf0a06b860a48633c5c0100000000000001be7ce234ebd932c7440269ce060daae5d28653d4752bd9116daefb35dac0e3ec8d668700001f471a60c7d939dabee596ab5deed888a602acdeec14a0979bf9c0ae63cb9408cb73e0655641daa87faa7ef2b5947d3500222dd072fe92fde5e122f7d2975d0c49edb3821a550e481e744e0590b0962e12de68aeed4d1f1b690ef32cc75b6b1501000000000000053c3c897461dbcbafa7d3867fab45ec4dce8278fe6cf0973970cda2e947e0d0da99f7410000d40006147d7e566ec7bbe4b7d413fcc8b763507c2b26f6155cb30cbd51737c495affc981e4c22710fd3316e76ca46b2a41bde411d17c0cd76dbe53a15823953a3daa4ef3652133cf11718f8453ea12f846251d249b61cee3787b48885594d23b0100\",\r\n                \"witness_type\": 2\r\n            },\r\n            \"transactions_filter\": \"0x\"\r\n        },\r\n        {\r\n            \"challenge_chain_sp_proof\": {\r\n                \"normalized_to_identity\": false,\r\n                \"witness\": \"0x0300ca3027dc768d1894470dbecde30493ab040b86d51cfd2d969be08af17030f222087aae7b32809afa1aa956f57ae932905c2ae91dc20eaa2eb8ecb59b65966a191b46dc28d10b06968bb0354f0070f9ab95f630131bdf7eafcc2c038ddb9790190401000000000001be7c88dfe3104cb9ff068568d46b4b3edbfe1b4effb2e3cb9d5bf42e57808a59b3f231020098ceddbffa9f0b27b2879228bfcbbdaab4f50608673886d36e81c9b3af1683e509ff92adcc79c4313898e654a6ab0ea27c3725d8b96e29a151c6e414afb51f5c7178c34f482d367ca4b1f7ec7459464171aeabe59cb8dd74fee98f24702c9d2c01000000000000053c3ceeb304ad81ae251a2fc3d8988da7c084c39dfac2fec36ec3e9412f49240a46a709030096053c4468ca4622bb9dfce38ee52f7c2791857d6486b2bf4f7f753c0b880b4870a0618ed071d472971936558406638d68fbb226284e26c26640077347fe963af79be18d9afdc60a50fdfd9a834103ac558b745a953951d98a49f6801cced1450100\",\r\n                \"witness_type\": 2\r\n            },\r\n            \"finished_sub_slots\": [],\r\n            \"foliage\": {\r\n                \"foliage_block_data\": {\r\n                    \"extension_data\": \"0x0000000000000000000000000000000000000000000000000000000003a2c7c9\",\r\n                    \"farmer_reward_puzzle_hash\": \"0xecbbcb78f5e7ab31e90c4c8252122da7ca7c74bfb75fdf1be96a3c9686adfa88\",\r\n                    \"pool_signature\": null,\r\n                    \"pool_target\": {\r\n                        \"max_height\": 0,\r\n                        \"puzzle_hash\": \"0xbb88a2972f7eca1429bfaab93a4b40489eca9ce93dd9f457fb73d6977b52a54f\"\r\n                    },\r\n                    \"unfinished_reward_block_hash\": \"0x7470e73998d09e5013ee4716755bb1c9c2149c4a20bbc08ab018162db84309c9\"\r\n                },\r\n                \"foliage_block_data_signature\": \"0x84c681c118c30d61fdb0138e4b8733934c6449eae06fcb138046ecfb7e00a7fa7b8a91e5a616a6ac6e2790bc607fad600ad7e02f20fc71258fec7febc413057fe5e000d7015680a11045ad663d39e966eab0d2dcc779a7b65cb02e4940f342f7\",\r\n                \"foliage_transaction_block_hash\": \"0x6207a41a0a8d8b7424e19b6c86986923cde7141111ffd7649bef80a1008cc1d2\",\r\n                \"foliage_transaction_block_signature\": \"0x99efa3bc08e637a1bb9cf76fd65f34b4605a604ef5bfb35730e9c4fc6823b98db84d811e4e4be98a2ea0e389619fe915167127552a18f755200a8eeac7013cbde11b3b627965d716807a5cfad6a72d8003cacc061ea887f3116b24271458d5d5\",\r\n                \"prev_block_hash\": \"0x13e5ef5813e2ad994184c953d7e7dff766428ea5ed0580c2149dabc66747b57a\",\r\n                \"reward_block_hash\": \"0x7470e73998d09e5013ee4716755bb1c9c2149c4a20bbc08ab018162db84309c9\"\r\n            },\r\n            \"foliage_transaction_block\": {\r\n                \"additions_root\": \"0x5f5ef826f1463990296e049903b1f93f67dec29dcf9f4bdf0eea05aa16b21ad3\",\r\n                \"filter_hash\": \"0x8e4730e59db228c6528bd2134b70cbe9610d4593b9c02edb97819661ed9f7d20\",\r\n                \"prev_transaction_block_hash\": \"0x2c534d6a32e7a53a3fc33baa8ab05504d7721d3395911e36144bd9b0589d4f25\",\r\n                \"removals_root\": \"0x1e5bfb0949fe7b292fd4cf54dd9f6ed48ff57187e765259b3ce3f324d27c5ecc\",\r\n                \"timestamp\": 1678076244,\r\n                \"transactions_info_hash\": \"0x92c0158e5c018e05435623b250df4e35351fe3da1a2dd053eae3c42251749086\"\r\n            },\r\n            \"reward_chain_block\": {\r\n                \"challenge_chain_sp_signature\": \"0x8013eb086cec8e807b1234f1db5f8e1c1f2dacc69ffb1ca895339855d9b3bf1ea2226eeb04a784846c31941fba74269907b5b72ad639b2f159d2fa6dafc4e92566cea6d25e812417d784780096b7e4e3a934388cf689d28f3b1a4f159ace7ba5\",\r\n                \"challenge_chain_sp_vdf\": {\r\n                    \"challenge\": \"0x7e7fc1d74f8d710b7a17017504bfd7e9863973cb60bbfefe1b6ce5588a1d4735\",\r\n                    \"number_of_iterations\": 36700160,\r\n                    \"output\": {\r\n                        \"data\": \"0x0100290f45aa544d64443cd183b5b0bb0eddc112fb4fcbba73159b1b04b6476203f8417d10f36868adb6cda400b0b9b625d57b07ba6bb258d9f0b825601b414a6942c3b69e32858409996ec8619160623d56db115aaa5661816f4453dfc6e434082a0100\"\r\n                    }\r\n                },\r\n                \"pos_ss_cc_challenge_hash\": \"0x7e7fc1d74f8d710b7a17017504bfd7e9863973cb60bbfefe1b6ce5588a1d4735\",\r\n                \"proof_of_space\": {\r\n                    \"challenge\": \"0x81838f2a5f615d3db9e2359d18c7c508cfcf5e4f5c7c17f3414ecd2dacb0380d\",\r\n                    \"plot_public_key\": \"0x8cb625dca79cc77cff1f56ba63e94e51a706246dc8f48602161f0d804a2d1a68eb47e69272df5bd35a9bc1f68f12c241\",\r\n                    \"pool_contract_puzzle_hash\": \"0xbb88a2972f7eca1429bfaab93a4b40489eca9ce93dd9f457fb73d6977b52a54f\",\r\n                    \"pool_public_key\": null,\r\n                    \"proof\": \"0x4ba33da1552300576e90838cb582e9c0265b863a12bbc3cc5a5d14dcd945fe56df49a76f3fcf19ebd06d7720c11a65c110a5ae785f269b7420360aa2cb16178c72b0121126322a12808632a91b90619589d15eb29057cda878b4c7a5a89c6871099a74788f21cbcf219ffa8b5b046d8d93c653bf11f86c71baf421e401867c37ec4ae1c0fb746bc9145102fda711793e05ed7f5cddccc2a7047195f16467a8214295d8ae0ecf76d5467e5149a3e9319cebee07f1c0fb4be6096032ca1c08bf60ee9b8ad87fdafb707e24809dab3c505566ce22cdab252c6bae5872673a6f7963a2edfdc2c7e8f05e4847580e3b4fdc72321bedcf778edbd85ed0884b2dff67d0\",\r\n                    \"size\": 32\r\n                },\r\n                \"reward_chain_sp_signature\": \"0x94f11bca7b3d0f3bc4a3a1edd8a051567cc8698796c03c20491b969771ad159e600e06a3b51260113d5f6effd61aeb7e0a5980efe24e943caa73342f3b9475f66f0e6a742f355cd0d1486785d6db401e29ac3c068fffb1d7134690d13f417e84\",\r\n                \"reward_chain_sp_vdf\": {\r\n                    \"challenge\": \"0x772c50de1700f58b608ff8fc77a4310aa475c9c9c98a932a446845370a52b500\",\r\n                    \"number_of_iterations\": 514688,\r\n                    \"output\": {\r\n                        \"data\": \"0x03007ca6f95897feb5e6a9fb9f6538437f089eee4de540bfde9a2b0ba831fbd21aef9ab4b46c172224e39f420aac719a2cc6a36cd5ae78f79b1057523e3167ecb512350f2e6348175eefac8709a68463ca7ae4067bae81e9814fc57f9b348d935c2b0100\"\r\n                    }\r\n                },\r\n                \"signage_point_index\": 16,\r\n                \"total_iters\": 13800993149685\r\n            },\r\n            \"reward_chain_sp_proof\": {\r\n                \"normalized_to_identity\": false,\r\n                \"witness\": \"0x0300fa111380d3200d60319b5942b6d64db9b4566687af69151ff753883d16cb1b6114950a2f8866196befd3a29b86122f9f4bcc1edccdf24e832f633589ac3bed4d09627f07b52fa80f6a58208a9315c2084cca9806b056bdf0a06b860a48633c5c0100000000000001be7ce234ebd932c7440269ce060daae5d28653d4752bd9116daefb35dac0e3ec8d668700001f471a60c7d939dabee596ab5deed888a602acdeec14a0979bf9c0ae63cb9408cb73e0655641daa87faa7ef2b5947d3500222dd072fe92fde5e122f7d2975d0c49edb3821a550e481e744e0590b0962e12de68aeed4d1f1b690ef32cc75b6b1501000000000000053c3c897461dbcbafa7d3867fab45ec4dce8278fe6cf0973970cda2e947e0d0da99f7410000d40006147d7e566ec7bbe4b7d413fcc8b763507c2b26f6155cb30cbd51737c495affc981e4c22710fd3316e76ca46b2a41bde411d17c0cd76dbe53a15823953a3daa4ef3652133cf11718f8453ea12f846251d249b61cee3787b48885594d23b0100\",\r\n                \"witness_type\": 2\r\n            },\r\n            \"transactions_filter\": \"0x\"\r\n        },\r\n        {\r\n            \"challenge_chain_sp_proof\": {\r\n                \"normalized_to_identity\": false,\r\n                \"witness\": \"0x0100a7812fd45b95894c5725ed3ed14a1be3247e76ea02365b36d0366cfab82ab98a0169da19a1ae4d425d5819b94798e02af9bcfde5098ef55d208e535b11906940f14f6ac42055c0247f3081e1d340408e81860d46b4dd06aec426a13b5a60a449010000000000000985e4d5e0fb85326a31a4897e8845538bd20e9bedaf8c46c9f8e1833d1e86f295f90857030023af6b075910a3e486b3687930244425f2826dc7550909aeeca846c202452816745413bc9ab8ca2fda478fe269b5726a8b39a1b2f002045f4faee6edf10bcd1eb15e4800b4ba94bfa894bdc9c1f5d3ef5bdccc74aca46d9020e6730c8a77ed01010000000000001c9148c8bc9b8bf67dc6c09185e9bb17fcda7c2ddf2983d1d72e4898bc50553964297f1b010024cf9f31b4532269cd6a452c14fa0e1e991b2980e833e28d59c78d2a756c0a5678dce61b8b71cf3f3f8cd37611f37960163e99b9e95312419936600de4a22301e172887cb1c82bea369eb423bcf05577a4ab140332f82a3e21d5712c1fa0d2013725\",\r\n                \"witness_type\": 2\r\n            },\r\n            \"finished_sub_slots\": [],\r\n            \"foliage\": {\r\n                \"foliage_block_data\": {\r\n                    \"extension_data\": \"0x0000000000000000000000000000000000000000000000000000000003a2c7c9\",\r\n                    \"farmer_reward_puzzle_hash\": \"0x4bc6435b409bcbabe53870dae0f03755f6aabb4594c5915ec983acf12a5d1fba\",\r\n                    \"pool_signature\": \"0xa7f170e0c32587d1db9f6f68f28e3c5793b4a86c6affae174cbd4bda9ec096a796d244ccf95e62171d7839d30bfeac09003ccad7f90283b4b653b68cb1a347c70a678d42162c49ffb188ef2d45d21fbffb3c8853b0ce2ee6f67f7e14d9486936\",\r\n                    \"pool_target\": {\r\n                        \"max_height\": 0,\r\n                        \"puzzle_hash\": \"0x4bc6435b409bcbabe53870dae0f03755f6aabb4594c5915ec983acf12a5d1fba\"\r\n                    },\r\n                    \"unfinished_reward_block_hash\": \"0xab6691f6f5c13ff0a4680f3e902efcc82641df64523657d4f132c4a70db21b99\"\r\n                },\r\n                \"foliage_block_data_signature\": \"0x90cd090312b65b26e794413d15edab3616f01e48110f72fc875e2493b0aad86f99216562237d1cf62ea84861ec14f7860a7a968260f6946c041cc628728542c8a3ef627823e2c176cacc47e84119fcb50ed6f2356908d23cf5f308dc9a9a17ab\",\r\n                \"foliage_transaction_block_hash\": \"0x2ca39854f6a32a9c50896b8b165927705adf212f848ca16a28f6d283d55f7954\",\r\n                \"foliage_transaction_block_signature\": \"0xa66e5916a26cd78bb084e7cd7d59c36ebd39a01fa8aeb790d09cacaeb1c22d8daba4f5c6a9877ac275aa2794482c194c0b5b23128fb65e834da8c61d4b808963913d239d791cb04f67c4a0cdb9003a8d7571dc2ff143ec3a954e73fa69d939ba\",\r\n                \"prev_block_hash\": \"0x13e5ef5813e2ad994184c953d7e7dff766428ea5ed0580c2149dabc66747b57a\",\r\n                \"reward_block_hash\": \"0xab6691f6f5c13ff0a4680f3e902efcc82641df64523657d4f132c4a70db21b99\"\r\n            },\r\n            \"foliage_transaction_block\": {\r\n                \"additions_root\": \"0x1611eb80ea5476b4283e41fe8b33c88a2d85b26145dac97c30885a381801b971\",\r\n                \"filter_hash\": \"0xd8445e477a9814015dc994eabf973350ddeb67c37ecfae98163bbc301f69149d\",\r\n                \"prev_transaction_block_hash\": \"0x2c534d6a32e7a53a3fc33baa8ab05504d7721d3395911e36144bd9b0589d4f25\",\r\n                \"removals_root\": \"0x5b47cf171919444e1aaa2497b97908be5a4bec1084f193f14a634c93c4cfbe63\",\r\n                \"timestamp\": 1678076253,\r\n                \"transactions_info_hash\": \"0x71bd40a43bb9a1e867e7825ef90cd9c1105d808cc5a7083758003b8c1142bf92\"\r\n            },\r\n            \"reward_chain_block\": {\r\n                \"challenge_chain_sp_signature\": \"0xb2c9730cee6362f1c400ed898d6bc5a2cf0018da986ab20cc87cb2393cd04e5bd1dbf5d3052a9f5e093c35806accc876027c7e6bd498eeced2710f000a7865e74f960811688658df0eccd63243b2a83fa63859dc2168bda7be629507ec5c764f\",\r\n                \"challenge_chain_sp_vdf\": {\r\n                    \"challenge\": \"0x7e7fc1d74f8d710b7a17017504bfd7e9863973cb60bbfefe1b6ce5588a1d4735\",\r\n                    \"number_of_iterations\": 38993920,\r\n                    \"output\": {\r\n                        \"data\": \"0x01002e9a936483f31a9fe6ee941e90bb9a44ba75c8ed1d77d82b6767a7eeef696ae8f0a2b03b550faf941162df0b79b6bc48119967fa4d469944ca077cf88faca13e97999bc713a26d98929d63637b2be38f0be774640db4c17ed98757045880312a0100\"\r\n                    }\r\n                },\r\n                \"pos_ss_cc_challenge_hash\": \"0x7e7fc1d74f8d710b7a17017504bfd7e9863973cb60bbfefe1b6ce5588a1d4735\",\r\n                \"proof_of_space\": {\r\n                    \"challenge\": \"0x18a067db011ecb6ae11daa0d9f1a5a74a2cdf45eaa1af837f92ee2bc6caaa579\",\r\n                    \"plot_public_key\": \"0x87d8b49520dd5262720596bf47b51bb1161eeeeefd7c5d6c8023eec52470450093c0bfe8fc7c5152f5d8f6674c61f220\",\r\n                    \"pool_contract_puzzle_hash\": null,\r\n                    \"pool_public_key\": \"0x9479b5cc0b3116a3154c6cb8da72c3cb3a28b08b6fad1f5ed42bbd72c9592053a94f2f96f2355e68649be57a0ee7301b\",\r\n                    \"proof\": \"0x0e43984d2720911a5c0846ce6b2483e9d6e1c196244d0c765aa4091c6786e95d4821df1ccaf6a804c0d2c3c4e573f15e13350ef5ad978957ce2fa3e3030cc1a31b3eee5131754f7e09e75882b0d1c62e5e2c1e46b02d210d6a3fbd6a4088bb6bd00e51bbd6c7f74a54e28ebcadd8b974658f5e3eead70238eae296cc6230404990a935135c4f4db77bcc2466b80205bad92c833e3726b216557d8a8996524f8e5b119945662021ddc370a63c0b31ec01e1a32fce138a9546fc7106dad08bfdf6f82bc4007950ef6f760e98356735dbd0f4404b82e889ded8accee174811b7c6d1410131b674fb336fc5efc6bc7a78f57e081c205793367ca7eb9540c374d6287\",\r\n                    \"size\": 32\r\n                },\r\n                \"reward_chain_sp_signature\": \"0x811c7ff4a490e56b0446efaaf6615331332e5336a4236c7f60b47b9f7a4fba451f91e66fff82ad2410e69ae58cd7e64b02fa034c80f7eafbad465bea970c5c0c12b33e93122c60ee9f1c89b2142d83c5379f1194c8101bce8c974b96e4a3f78f\",\r\n                \"reward_chain_sp_vdf\": {\r\n                    \"challenge\": \"0x772c50de1700f58b608ff8fc77a4310aa475c9c9c98a932a446845370a52b500\",\r\n                    \"number_of_iterations\": 2808448,\r\n                    \"output\": {\r\n                        \"data\": \"0x01000d28a0e12edad31164692421c351320086e66088909ba45f183fa16644a9abd28bb9c68efd6841cfc8f4d74b5f6eeae71ff99c9cbba60da8b5ee5533a5038b519c41f66d0d9854020f66c62790faf884d657052e7ec5b1f92da182ec0b8e53380100\"\r\n                    }\r\n                },\r\n                \"signage_point_index\": 17,\r\n                \"total_iters\": 13800994274820\r\n            },\r\n            \"reward_chain_sp_proof\": {\r\n                \"normalized_to_identity\": false,\r\n                \"witness\": \"0x0300028e7d5ecd547ec041a458448e56a40d8bd7ebe773ada675602a31524acb33b9c74bc52bb94bf3eb6247201fa773ac63f9a95ea873e85e3239667a4baaf003092301b6cbf2205735bd3aeabc7693adee8daad44d608f43cbfc7f1a34bc604b00090400000000000985e49d20d91582f149c4fe527889310c42992553050b41aa193636cec7b9ca21f9d9e301002cee3b9ef8cba41005299d061e858d94bad90655db31d77298e70357d69bd6183f722c1b851d9c2436d0633014bb6bc4b6e30ddf07849177c2d85da33e95a90f473a481bf7d6c59ffd913ef1d815b13df00c9e59d6caf42e859188b5feb8df11040100000000001c9148b58c79b63cd8a492328bf845b0708a6f531bdc7e626b8081bace46de851c2369070200985c4704482f4e56a260196b875a160d56fc2767f61dca677c3f256e15945c8cfbe9422d4dcaae3bddeadcaea585b85433537291f732e138db4bb07cd94f8918e3b6725f891e08eded7c3a93fe0b6a46993e626cc2514ab06b85182dab6bfa340100\",\r\n                \"witness_type\": 2\r\n            },\r\n            \"transactions_filter\": \"0x\"\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_ResponseSerialisation()
        {
            Test_ResponseClasses<GetUnfinishedBlockHeaders_Response> helper = new Test_ResponseClasses<GetUnfinishedBlockHeaders_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetUnfinishedBlockHeaders_Response> helper = new Test_ResponseClasses<GetUnfinishedBlockHeaders_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}