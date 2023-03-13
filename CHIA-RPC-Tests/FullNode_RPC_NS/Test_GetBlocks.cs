﻿using CHIA_RPC.FullNode_RPC_NS;
using CHIA_RPC.General;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.FullNode_RPC_NS
{
    public class Test_GetBlocks
    {
        private string[] ExpectedRPCResults = new string[]
        {
             "{\"start\":100,\"end\":200,\"exclude_header_hash\":true}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"blocks\": [\r\n    {\r\n      \"challenge_chain_ip_proof\": {\r\n        \"normalized_to_identity\": false,\r\n        \"witness\": \"0x0100b2958c29235fdf94a0b7476e039267d5d5d833f21b7af28c4e0aefde3767a9036523c67fc58706a1d1e91fd52e8f70db9a3401ff2e204c3ada572639d8fc966c990ccd7d8173ae4960e6ca05634c2ded08494e2c7a62d31684285db44ad0783f01000000000000170750a098e503259a8c08ec6a4192f1c9a950d09bb9ce43c4b9b3409420a519eca6c2650200549e022e2ce20e815b4a7a3ad376d173a78a8f0dc55022ce2a9d823495e9e719cd872a3c3e76a8b262e7c2650e6009a6f9b93434b228dbeb667a1d33b6a6b30051c7a00637cfcc6907269f0db89695a9a26bf1a63a13f01b23168795a5593e012b1d00000000004515f0a167be06b340921afd1dc019299dcebc42eeb906f3bffb86e740d190c09185b1c102000e7762337db196427682b5927617a0cfd7378f4d4bd434a62e19bd2e60f8bde267a5742a837351d5bac3ecc5ed2fd915a2caf1ac06061e90ed61f22b26a37034a5e7a631342184de9e218e1d7ff07640bc07ce2889efd082bd3ca11c8e80a74f0100\",\r\n        \"witness_type\": 2\r\n      },\r\n      \"challenge_chain_sp_proof\": null,\r\n      \"finished_sub_slots\": [],\r\n      \"foliage\": {\r\n        \"foliage_block_data\": {\r\n          \"extension_data\": \"0x0000000000000000000000000000000000000000000000000000000003a2c7c9\",\r\n          \"farmer_reward_puzzle_hash\": \"0xe2f70baf739bdaf59e360d3a3e2d4ff8cb89f150d9b60b8e91b870e41b58f2fa\",\r\n          \"pool_signature\": null,\r\n          \"pool_target\": {\r\n            \"max_height\": 0,\r\n            \"puzzle_hash\": \"0x71afdce401a0f2a6f03de6287902eacfa38502d6667b04da36e32c3930171ce4\"\r\n          },\r\n          \"unfinished_reward_block_hash\": \"0x293f38e7932dce9e8216820baf873c76836c8ffeb9ef24549a653f2c77a948d0\"\r\n        },\r\n        \"foliage_block_data_signature\": \"0x81fbc2b4d7d18e85db97e83f254ba6546cb08c80f50de1c7353d20a07d574d0d1c084273a1ef4822e164be450abb2dfe133e7d2d90727a43baae9ad858765b30eea9afaf809563760a07dc3fce343222af857b9af5f4d37f79a832e32f335335\",\r\n        \"foliage_transaction_block_hash\": null,\r\n        \"foliage_transaction_block_signature\": null,\r\n        \"prev_block_hash\": \"0x902ca8dfdd08e79dec3c96837f4e99162508ffaeff730c68af1fde9b86cbf61b\",\r\n        \"reward_block_hash\": \"0x5566434842f375434f9a558a3de5907db44903036c3de1573852afffbd1991bd\"\r\n      },\r\n      \"foliage_transaction_block\": null,\r\n      \"infused_challenge_chain_ip_proof\": null,\r\n      \"reward_chain_block\": {\r\n        \"challenge_chain_ip_vdf\": {\r\n          \"challenge\": \"0xed35c7dd67371857123344c847339e4d23dfa815ba8859d160813a228fc6fc22\",\r\n          \"number_of_iterations\": 7242534,\r\n          \"output\": {\r\n            \"data\": \"0x01001ea29503859966e59024fb3a903e424a1652e724483b86928febca5e308d7039b7138847e436e5f1ba5f6c025f6c6ff275c070149079877463aa077f571d0706516723eaa51113c8ec624a005dc73704fcccefa26bb0eefbb9af15eb5c61b6090201\"\r\n          }\r\n        },\r\n        \"challenge_chain_sp_signature\": \"0xa8aeaba8b70ad7515055ab8c19d611226718f3bcd3311743a8e247fed59e069095514c68ba5862b186f9854089c27a3a19c45b91d2aebb21267b27268850cc220e1d33fc0e4c582e1602c968c2d58c5c629032ce7da2683a9ed651df729c07d0\",\r\n        \"challenge_chain_sp_vdf\": null,\r\n        \"height\": 914661,\r\n        \"infused_challenge_chain_ip_vdf\": null,\r\n        \"is_transaction_block\": false,\r\n        \"pos_ss_cc_challenge_hash\": \"0xed35c7dd67371857123344c847339e4d23dfa815ba8859d160813a228fc6fc22\",\r\n        \"proof_of_space\": {\r\n          \"challenge\": \"0xad43c12b5c5a480ee93992697bd8c9153d536007b0ffac024341cd8ca853a9e3\",\r\n          \"plot_public_key\": \"0x8b5f3cd22bf5073e12f285d2a0e9bbfb485fea8f3ede2f5573e44168fadbb91b71cef1dffc03758a5241c47b105df81a\",\r\n          \"pool_contract_puzzle_hash\": \"0x71afdce401a0f2a6f03de6287902eacfa38502d6667b04da36e32c3930171ce4\",\r\n          \"pool_public_key\": null,\r\n          \"proof\": \"0xa84606d3dba86cbc1c2f56d05175bbbcb970629380bec5c49ad46f0c5f067e4ba74101ac24f0e09fb73ce0ebc9249436c528b5fab689d94c4213072e2acfc1c3a6f17763b16304234002ce471da4ce7e888e2f5abadf4d7f48cd157294ce03cb28df0f45597ca5460cd66c772c7650f2d170d08a5898fe65623b33aac864f44d2a39bcf074e62866edccf9b424f9a8ca56c9a98e87d48fb02b933af951284d610ff1eb71e730a05c2f6c7be86fd4df7efb26e8fb2e573981d8ad866adc02a82ffb0d7ff106c9c78f9cea08f4a2de9db2607266edf6e807924edf9af0f36b8938d97865072126011b67646b4d0e206b706d3a3e67e8862cb0502520f1ad1b4341\",\r\n          \"size\": 32\r\n        },\r\n        \"reward_chain_ip_vdf\": {\r\n          \"challenge\": \"0x316979467849d4f8ed3a962e773b0849bdfb4e02861191b5af36f270008b66f9\",\r\n          \"number_of_iterations\": 6791425,\r\n          \"output\": {\r\n            \"data\": \"0x0300854ebbccc4b4b5c0e0244dab12ada16568da6173b1dee587e0e8a212dacc66e562289358af482e1684f4bbe8b51fe96159ec2ad40a0758ff34e8be54bb63ba16399eb171ffce04ed6ffa5f532dfa0c9c779580f5daafff0d97e0c30ae22077060100\"\r\n          }\r\n        },\r\n        \"reward_chain_sp_signature\": \"0xa81d4d596f4f657e7405eccbe99652eec386f624855b1e0dbd2bdccbc5c909572570daf173da11e26370cb00731ddda611a931eb67d03a3d9f286c704742fc5a4d3fdfb8f6b04ba960debf118e07effa5f030c688dbccb820718661ff8fe7e8a\",\r\n        \"reward_chain_sp_vdf\": null,\r\n        \"signage_point_index\": 0,\r\n        \"total_iters\": 3330271511334,\r\n        \"weight\": 1393823840\r\n      },\r\n      \"reward_chain_ip_proof\": {\r\n        \"normalized_to_identity\": false,\r\n        \"witness\": \"0x000005d3ec00e8927763e6782b80784547a215431ab10a0a0c9d3391a6e4583baf546c6b921bd3396d21a949dc187c1a1d0496f81a91b8716688f775cd425d3adc0717232b677b10807f112b7903ffe7dd8f730af4f4e942a2713322b3c2dda0b42b0100000000000017075086c91d61dc6e7eff70a214b1e3cdf067bcaeda45ef5d00e557984a2a7819f9ff19020077362394b1fe374632274ce77174cdbdebc9da0fc54df284dcb42b3a8cb2aab227da413dcd46927c272dd323b669cea7a001ac6247a423378eb94dea3154532dbcab891ef0fcf4f48dee4a689366f3622fa6e60a960c71b074f9520dad549224020100000000004515f0f10ac62807e87230aeb8bc486caac213a6418042c1ed9c1b5a1814c7e190f6e88902002364e9fb81c7b967e39eeb2e4ae6b4391fa262a5603c185cbc906acaf50e5ff7a7df7f3f3dede3b09c2a8b1a7dfd012a3d0c08ab21b5cf15fb4d1f1df9d4ff040b39eaa9ffccfa9ab3b03d5b33f312c13ff8908ddd9c640ede1e4d270aaab51b0100\",\r\n        \"witness_type\": 2\r\n      },\r\n      \"reward_chain_sp_proof\": null,\r\n      \"transactions_generator\": null,\r\n      \"transactions_generator_ref_list\": [],\r\n      \"transactions_info\": null\r\n    }\r\n  ],\r\n  \"success\": true,\r\n  \"error\": null\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetBlocks_RPC> helper = new Test_RPCClasses<GetBlocks_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RpcDiskIO()
        {
            Test_RPCClasses<GetBlocks_RPC> helper = new Test_RPCClasses<GetBlocks_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetBlocks_Response> helper = new Test_ResponseClasses<GetBlocks_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetBlocks_Response> helper = new Test_ResponseClasses<GetBlocks_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}