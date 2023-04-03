﻿using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.CATsAndTrading_NS
{
    public class Test_CatSpend
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 7, \"amount\": 1, \"inner_address\": \"xch19mpn09rnn62nlur7h05naeeq2m6lprdr48f3cgt9j6s8a2h3kk6qdydujd\", \"fee\": 1}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"transaction\": {\r\n        \"additions\": [\r\n            {\r\n                \"amount\": 1,\r\n                \"parent_coin_info\": \"0x60a8b06515aaefe74236eb234130d769a1b65c99706414901277926fe29c3360\",\r\n                \"puzzle_hash\": \"0xfe6329b1d5aa73c22d6f9f3c76e97c9c0b07af5799ff70b023b77ccf87cd0e2c\"\r\n            },\r\n            {\r\n                \"amount\": 999999,\r\n                \"parent_coin_info\": \"0x60a8b06515aaefe74236eb234130d769a1b65c99706414901277926fe29c3360\",\r\n                \"puzzle_hash\": \"0xad5de77c7da1316b9b72708d17dbb8937855d740ebaf85669b8bd925275e8d49\"\r\n            },\r\n            {\r\n                \"amount\": 39261664,\r\n                \"parent_coin_info\": \"0x12c33763d41055dd71a7a5676ced26bef08e059255c16e59f76033f98dcfedd4\",\r\n                \"puzzle_hash\": \"0x43a21683130c97ed272becd70e02d60f1b86a180fd759e28bf0d94f7eedd0fa5\"\r\n            }\r\n        ],\r\n        \"amount\": 1,\r\n        \"confirmed\": false,\r\n        \"confirmed_at_height\": 0,\r\n        \"created_at_time\": 1669274635,\r\n        \"fee_amount\": 1,\r\n        \"memos\": {\r\n            \"18ffd7f3bbadda1017218bb535caf7393190222ecf5fbdf04ed5f6855926d6dd\": \"2ec33794739e953ff07ebbe93ee72056f5f08da3a9d31c216596a07eaaf1b5b4\"\r\n        },\r\n        \"name\": \"0xb9df7b15f7a6b8e7b3903ae3834308a8a3d04943da96bff58b39c112e42b73ab\",\r\n        \"removals\": [\r\n            {\r\n                \"amount\": 1000000,\r\n                \"parent_coin_info\": \"0xe752c4dadffe6edcb14e83646e6d4d53f7b3d8d74d2c20ed138aa35f8230ceb1\",\r\n                \"puzzle_hash\": \"0x2a161b188eb77baa486653398d8bdc2194ff946f9a9b1d6f55f1ab0017623aa9\"\r\n            },\r\n            {\r\n                \"amount\": 39261665,\r\n                \"parent_coin_info\": \"0xeb17e80fcb72f15bfb28924f0bcd684df626646dca282bc88098cb0d59ffe1bb\",\r\n                \"puzzle_hash\": \"0x057539dee39ab1deddb31f72602e4a280c27e84c53ab92122735a044916619bb\"\r\n            }\r\n        ],\r\n        \"sent\": 0,\r\n        \"sent_to\": [],\r\n        \"spend_bundle\": {\r\n            \"aggregated_signature\": \"0x961224367d0bb9f61c3cdc306266a00141dc10c895a0702a73a690799870657e365f05c629f99acf6ef5081c03e352af0b3d8701e208cbf4603d59b5cb8460f0036729d5c6938898a8f44114f62b75c6db371c8fc857fa8188502ecc4cdd81f2\",\r\n            \"coin_spends\": [\r\n                {\r\n                    \"coin\": {\r\n                        \"amount\": 1000000,\r\n                        \"parent_coin_info\": \"0xe752c4dadffe6edcb14e83646e6d4d53f7b3d8d74d2c20ed138aa35f8230ceb1\",\r\n                        \"puzzle_hash\": \"0x2a161b188eb77baa486653398d8bdc2194ff946f9a9b1d6f55f1ab0017623aa9\"\r\n                    },\r\n                    \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ff5effff04ff02ffff04ffff04ff05ffff04ffff0bff34ff0580ffff04ff0bff80808080ffff04ffff02ff17ff2f80ffff04ff5fffff04ffff02ff2effff04ff02ffff04ff17ff80808080ffff04ffff02ff2affff04ff02ffff04ff82027fffff04ff82057fffff04ff820b7fff808080808080ffff04ff81bfffff04ff82017fffff04ff8202ffffff04ff8205ffffff04ff820bffff80808080808080808080808080ffff04ffff01ffffffff3d46ff02ff333cffff0401ff01ff81cb02ffffff20ff02ffff03ff05ffff01ff02ff32ffff04ff02ffff04ff0dffff04ffff0bff7cffff0bff34ff2480ffff0bff7cffff0bff7cffff0bff34ff2c80ff0980ffff0bff7cff0bffff0bff34ff8080808080ff8080808080ffff010b80ff0180ffff02ffff03ffff22ffff09ffff0dff0580ff2280ffff09ffff0dff0b80ff2280ffff15ff17ffff0181ff8080ffff01ff0bff05ff0bff1780ffff01ff088080ff0180ffff02ffff03ff0bffff01ff02ffff03ffff09ffff02ff2effff04ff02ffff04ff13ff80808080ff820b9f80ffff01ff02ff56ffff04ff02ffff04ffff02ff13ffff04ff5fffff04ff17ffff04ff2fffff04ff81bfffff04ff82017fffff04ff1bff8080808080808080ffff04ff82017fff8080808080ffff01ff088080ff0180ffff01ff02ffff03ff17ffff01ff02ffff03ffff20ff81bf80ffff0182017fffff01ff088080ff0180ffff01ff088080ff018080ff0180ff04ffff04ff05ff2780ffff04ffff10ff0bff5780ff778080ffffff02ffff03ff05ffff01ff02ffff03ffff09ffff02ffff03ffff09ff11ff5880ffff0159ff8080ff0180ffff01818f80ffff01ff02ff26ffff04ff02ffff04ff0dffff04ff0bffff04ffff04ff81b9ff82017980ff808080808080ffff01ff02ff7affff04ff02ffff04ffff02ffff03ffff09ff11ff5880ffff01ff04ff58ffff04ffff02ff76ffff04ff02ffff04ff13ffff04ff29ffff04ffff0bff34ff5b80ffff04ff2bff80808080808080ff398080ffff01ff02ffff03ffff09ff11ff7880ffff01ff02ffff03ffff20ffff02ffff03ffff09ffff0121ffff0dff298080ffff01ff02ffff03ffff09ffff0cff29ff80ff3480ff5c80ffff01ff0101ff8080ff0180ff8080ff018080ffff0109ffff01ff088080ff0180ffff010980ff018080ff0180ffff04ffff02ffff03ffff09ff11ff5880ffff0159ff8080ff0180ffff04ffff02ff26ffff04ff02ffff04ff0dffff04ff0bffff04ff17ff808080808080ff80808080808080ff0180ffff01ff04ff80ffff04ff80ff17808080ff0180ffff02ffff03ff05ffff01ff04ff09ffff02ff56ffff04ff02ffff04ff0dffff04ff0bff808080808080ffff010b80ff0180ff0bff7cffff0bff34ff2880ffff0bff7cffff0bff7cffff0bff34ff2c80ff0580ffff0bff7cffff02ff32ffff04ff02ffff04ff07ffff04ffff0bff34ff3480ff8080808080ffff0bff34ff8080808080ffff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff2effff04ff02ffff04ff09ff80808080ffff02ff2effff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ffff04ffff04ff30ffff04ff5fff808080ffff02ff7effff04ff02ffff04ffff04ffff04ff2fff0580ffff04ff5fff82017f8080ffff04ffff02ff26ffff04ff02ffff04ff0bffff04ff05ffff01ff808080808080ffff04ff17ffff04ff81bfffff04ff82017fffff04ffff02ff2affff04ff02ffff04ff8204ffffff04ffff02ff76ffff04ff02ffff04ff09ffff04ff820affffff04ffff0bff34ff2d80ffff04ff15ff80808080808080ffff04ff8216ffff808080808080ffff04ff8205ffffff04ff820bffff808080808080808080808080ff02ff5affff04ff02ffff04ff5fffff04ff3bffff04ffff02ffff03ff17ffff01ff09ff2dffff02ff2affff04ff02ffff04ff27ffff04ffff02ff76ffff04ff02ffff04ff29ffff04ff57ffff04ffff0bff34ff81b980ffff04ff59ff80808080808080ffff04ff81b7ff80808080808080ff8080ff0180ffff04ff17ffff04ff05ffff04ff8202ffffff04ffff04ffff04ff78ffff04ffff0eff5cffff02ff2effff04ff02ffff04ffff04ff2fffff04ff82017fff808080ff8080808080ff808080ffff04ffff04ff20ffff04ffff0bff81bfff5cffff02ff2effff04ff02ffff04ffff04ff15ffff04ffff10ff82017fffff11ff8202dfff2b80ff8202ff80ff808080ff8080808080ff808080ff138080ff80808080808080808080ff018080ffff04ffff01a037bef360ee858133b69d595a906dc45d01af50379dad515eb9518abb7c1d2a7affff04ffff01a00570076f3c2cd8d6e65f9b56f96ab92079d3ce7ab7372c751e1c19fdb42b25d4ffff04ffff01ff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b08059810f9c69bc54f8aeebafdbb47faca702105ba15f59152a80168944a751a1042a7affb1a09fc5379c4334fcd2d3f0ff018080ff0180808080\",\r\n                    \"solution\": \"0xffff80ffff01ffff33ffa02ec33794739e953ff07ebbe93ee72056f5f08da3a9d31c216596a07eaaf1b5b4ff01ffffa02ec33794739e953ff07ebbe93ee72056f5f08da3a9d31c216596a07eaaf1b5b48080ffff33ffa0ee1d5710dcd99fd96ad38174bb4d0f87f04031abe15dc28d84415a251c67f1b9ff830f423f80ffff3cffa05e300a78dd793d53afb2a59039ea5f9661b9114b6ff006af9a5f9fdd088424948080ff8080ffffa094a128de0450c01d3d9e4b68516a2ec09fd219a3fe371d20ebbc47dd2f092faeffa0bae24162efbd568f89bc7a340798a6118df0189eb9e3f8697bcea27af99f8f79ff830f424080ffa060a8b06515aaefe74236eb234130d769a1b65c99706414901277926fe29c3360ffffa0e752c4dadffe6edcb14e83646e6d4d53f7b3d8d74d2c20ed138aa35f8230ceb1ffa02a161b188eb77baa486653398d8bdc2194ff946f9a9b1d6f55f1ab0017623aa9ff830f424080ffffa0e752c4dadffe6edcb14e83646e6d4d53f7b3d8d74d2c20ed138aa35f8230ceb1ffa0b361e26773b161ca94291a54353dfd7e257f18a8e9abbb49ee89718e8c8bfc0bff830f424080ff80ff8080\"\r\n                },\r\n                {\r\n                    \"coin\": {\r\n                        \"amount\": 39261665,\r\n                        \"parent_coin_info\": \"0xeb17e80fcb72f15bfb28924f0bcd684df626646dca282bc88098cb0d59ffe1bb\",\r\n                        \"puzzle_hash\": \"0x057539dee39ab1deddb31f72602e4a280c27e84c53ab92122735a044916619bb\"\r\n                    },\r\n                    \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b08ed87f7cda15feadd676e2677f4bc162176c408910dcbf29d79cfe6d1aff1c2f1d2897ab4e29f90cb91f605dc575705aff018080\",\r\n                    \"solution\": \"0xff80ffff01ffff33ffa043a21683130c97ed272becd70e02d60f1b86a180fd759e28bf0d94f7eedd0fa5ff84025715e080ffff34ff0180ffff3cffa09840c31ad16cb371bdcaf0433554ff0e7a648e2517f530d004f2a08fa9e3ee6b80ffff3dffa0469663a0bb12424a04b8b0331c09a7887f23b50e64fd9cca4afac9d920d8246a8080ff8080\"\r\n                }\r\n            ]\r\n        },\r\n        \"to_address\": \"xch19mpn09rnn62nlur7h05naeeq2m6lprdr48f3cgt9j6s8a2h3kk6qdydujd\",\r\n        \"to_puzzle_hash\": \"0x2ec33794739e953ff07ebbe93ee72056f5f08da3a9d31c216596a07eaaf1b5b4\",\r\n        \"trade_id\": null,\r\n        \"type\": 1,\r\n        \"wallet_id\": 7\r\n    },\r\n    \"transaction_id\": \"0xb9df7b15f7a6b8e7b3903ae3834308a8a3d04943da96bff58b39c112e42b73ab\"\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<CatSpend_RPC> helper = new Test_RPCClasses<CatSpend_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<CatSpend_RPC> helper = new Test_RPCClasses<CatSpend_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<CatSpend_Response> helper = new Test_ResponseClasses<CatSpend_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<CatSpend_Response> helper = new Test_ResponseClasses<CatSpend_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
