﻿using CHIA_RPC.Wallet_NS.DLWallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DLWallet_NS
{
    public class Test_DLUpdateRoot
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"launcher_id\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\", \"new_root\": \"0x0000000000000000000000000000000000000000000000000000000000000000\", \"fee\": 1}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"tx_record\": {\r\n        \"additions\": [\r\n            {\r\n                \"amount\": 1,\r\n                \"parent_coin_info\": \"0xc2347b264b412bde5893f4e1369adab3a6c61496845c10f8ec98bc35f9e1429f\",\r\n                \"puzzle_hash\": \"0xb4aaf8fffd0fe7cc74fd9c7a5dd519a58775d42b924cab183e8e8a6a48144362\"\r\n            }\r\n        ],\r\n        \"amount\": 1,\r\n        \"confirmed\": false,\r\n        \"confirmed_at_height\": 0,\r\n        \"created_at_time\": 1669352476,\r\n        \"fee_amount\": 1,\r\n        \"memos\": {\r\n            \"70e75ede3b9ba91ab4b91bc5efea8946fde60518becdce40e2cf6800ff173245\": \"607b04952b317c81eb21ba96ff5f62adb58621f89d5fe6240f6e83d4395998c5\"\r\n        },\r\n        \"name\": \"0xc2347b264b412bde5893f4e1369adab3a6c61496845c10f8ec98bc35f9e1429f\",\r\n        \"removals\": [\r\n            {\r\n                \"amount\": 1,\r\n                \"parent_coin_info\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\",\r\n                \"puzzle_hash\": \"0xfddfe3a8ded6d3327204e1a4c8b3ac39725082b53556526f788250cf2b541c84\"\r\n            }\r\n        ],\r\n        \"sent\": 10,\r\n        \"sent_to\": [],\r\n        \"spend_bundle\": {\r\n            \"aggregated_signature\": \"0x990dd3c598b16e245e44e3bed148fa3fb5e5f65bd6b05ed560021c0d46efdbdef18d70346ffe8b3401984b017045ed97169f77a041c8e995b507e00f0496e057630d8d609d7e69857b3122ae440cb2f67ad5d3f5ab8fe84448be414d1107f657\",\r\n            \"coin_spends\": [\r\n                {\r\n                    \"coin\": {\r\n                        \"amount\": 1,\r\n                        \"parent_coin_info\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\",\r\n                        \"puzzle_hash\": \"0xfddfe3a8ded6d3327204e1a4c8b3ac39725082b53556526f788250cf2b541c84\"\r\n                    },\r\n                    \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ffff18ff2fff3480ffff01ff04ffff04ff20ffff04ff2fff808080ffff04ffff02ff3effff04ff02ffff04ff05ffff04ffff02ff2affff04ff02ffff04ff27ffff04ffff02ffff03ff77ffff01ff02ff36ffff04ff02ffff04ff09ffff04ff57ffff04ffff02ff2effff04ff02ffff04ff05ff80808080ff808080808080ffff011d80ff0180ffff04ffff02ffff03ff77ffff0181b7ffff015780ff0180ff808080808080ffff04ff77ff808080808080ffff02ff3affff04ff02ffff04ff05ffff04ffff02ff0bff5f80ffff01ff8080808080808080ffff01ff088080ff0180ffff04ffff01ffffffff4947ff0233ffff0401ff0102ffffff20ff02ffff03ff05ffff01ff02ff32ffff04ff02ffff04ff0dffff04ffff0bff3cffff0bff34ff2480ffff0bff3cffff0bff3cffff0bff34ff2c80ff0980ffff0bff3cff0bffff0bff34ff8080808080ff8080808080ffff010b80ff0180ffff02ffff03ffff22ffff09ffff0dff0580ff2280ffff09ffff0dff0b80ff2280ffff15ff17ffff0181ff8080ffff01ff0bff05ff0bff1780ffff01ff088080ff0180ff02ffff03ff0bffff01ff02ffff03ffff02ff26ffff04ff02ffff04ff13ff80808080ffff01ff02ffff03ffff20ff1780ffff01ff02ffff03ffff09ff81b3ffff01818f80ffff01ff02ff3affff04ff02ffff04ff05ffff04ff1bffff04ff34ff808080808080ffff01ff04ffff04ff23ffff04ffff02ff36ffff04ff02ffff04ff09ffff04ff53ffff04ffff02ff2effff04ff02ffff04ff05ff80808080ff808080808080ff738080ffff02ff3affff04ff02ffff04ff05ffff04ff1bffff04ff34ff8080808080808080ff0180ffff01ff088080ff0180ffff01ff04ff13ffff02ff3affff04ff02ffff04ff05ffff04ff1bffff04ff17ff8080808080808080ff0180ffff01ff02ffff03ff17ff80ffff01ff088080ff018080ff0180ffffff02ffff03ffff09ff09ff3880ffff01ff02ffff03ffff18ff2dffff010180ffff01ff0101ff8080ff0180ff8080ff0180ff0bff3cffff0bff34ff2880ffff0bff3cffff0bff3cffff0bff34ff2c80ff0580ffff0bff3cffff02ff32ffff04ff02ffff04ff07ffff04ffff0bff34ff3480ff8080808080ffff0bff34ff8080808080ffff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff2effff04ff02ffff04ff09ff80808080ffff02ff2effff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff02ffff03ffff21ff17ffff09ff0bff158080ffff01ff04ff30ffff04ff0bff808080ffff01ff088080ff0180ff018080ffff04ffff01ffa07faa3253bfddd1e0decb0906b2dc6247bbc4cf608f58345d173adb63e8b47c9fffa04aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09ea0eff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9ffff04ffff01ff02ffff01ff02ffff01ff02ff3effff04ff02ffff04ff05ffff04ffff02ff2fff5f80ffff04ff80ffff04ffff04ffff04ff0bffff04ff17ff808080ffff01ff808080ffff01ff8080808080808080ffff04ffff01ffffff0233ff04ff0101ffff02ff02ffff03ff05ffff01ff02ff1affff04ff02ffff04ff0dffff04ffff0bff12ffff0bff2cff1480ffff0bff12ffff0bff12ffff0bff2cff3c80ff0980ffff0bff12ff0bffff0bff2cff8080808080ff8080808080ffff010b80ff0180ffff0bff12ffff0bff2cff1080ffff0bff12ffff0bff12ffff0bff2cff3c80ff0580ffff0bff12ffff02ff1affff04ff02ffff04ff07ffff04ffff0bff2cff2c80ff8080808080ffff0bff2cff8080808080ffff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff2effff04ff02ffff04ff09ff80808080ffff02ff2effff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff02ffff03ff0bffff01ff02ffff03ffff09ff23ff1880ffff01ff02ffff03ffff18ff81b3ff2c80ffff01ff02ffff03ffff20ff1780ffff01ff02ff3effff04ff02ffff04ff05ffff04ff1bffff04ff33ffff04ff2fffff04ff5fff8080808080808080ffff01ff088080ff0180ffff01ff04ff13ffff02ff3effff04ff02ffff04ff05ffff04ff1bffff04ff17ffff04ff2fffff04ff5fff80808080808080808080ff0180ffff01ff02ffff03ffff09ff23ffff0181e880ffff01ff02ff3effff04ff02ffff04ff05ffff04ff1bffff04ff17ffff04ffff02ffff03ffff22ffff09ffff02ff2effff04ff02ffff04ff53ff80808080ff82014f80ffff20ff5f8080ffff01ff02ff53ffff04ff818fffff04ff82014fffff04ff81b3ff8080808080ffff01ff088080ff0180ffff04ff2cff8080808080808080ffff01ff04ff13ffff02ff3effff04ff02ffff04ff05ffff04ff1bffff04ff17ffff04ff2fffff04ff5fff80808080808080808080ff018080ff0180ffff01ff04ffff04ff18ffff04ffff02ff16ffff04ff02ffff04ff05ffff04ff27ffff04ffff0bff2cff82014f80ffff04ffff02ff2effff04ff02ffff04ff818fff80808080ffff04ffff0bff2cff0580ff8080808080808080ff378080ff81af8080ff0180ff018080ffff04ffff01a0a04d9f57764f54a43e4030befb4d80026e870519aaa66334aef8304f5d0393c2ffff04ffff01ffa0000000000000000000000000000000000000000000000000000000000000000080ffff04ffff01a057bfd1cb0adda3d94315053fda723f2028320faa8338225d99f629e3d46d43a9ffff04ffff01ff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b0a889344c9bc729cadd340f41d5937a95442767133fd6ca7b5ec865df553b15cc43a0930bdd0a55ffc03edad3dfb62cbdff018080ff018080808080ff01808080\",\r\n                    \"solution\": \"0xffffa0e9158d9c2f0769c00cb0cbccfa90536b99253aebf4a0dfecd5d8298ff4ec55fbff0180ff01ffffff80ffff01ffff33ffa0607b04952b317c81eb21ba96ff5f62adb58621f89d5fe6240f6e83d4395998c5ff01ffffa04aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09effa00000000000000000000000000000000000000000000000000000000000000000ffa0607b04952b317c81eb21ba96ff5f62adb58621f89d5fe6240f6e83d4395998c58080ffff3cff248080ff80808080\"\r\n                },\r\n                {\r\n                    \"coin\": {\r\n                        \"amount\": 99990,\r\n                        \"parent_coin_info\": \"0xe9158d9c2f0769c00cb0cbccfa90536b99253aebf4a0dfecd5d8298ff4ec55fb\",\r\n                        \"puzzle_hash\": \"0x7be3f330dd5cbacdee14f124b51ad744d7504cf4426d92b67953a96c9760d869\"\r\n                    },\r\n                    \"puzzle_reveal\": \"0xff02ffff01ff02ffff01ff02ffff03ff0bffff01ff02ffff03ffff09ff05ffff1dff0bffff1effff0bff0bffff02ff06ffff04ff02ffff04ff17ff8080808080808080ffff01ff02ff17ff2f80ffff01ff088080ff0180ffff01ff04ffff04ff04ffff04ff05ffff04ffff02ff06ffff04ff02ffff04ff17ff80808080ff80808080ffff02ff17ff2f808080ff0180ffff04ffff01ff32ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff06ffff04ff02ffff04ff09ff80808080ffff02ff06ffff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01b091f7f25662e59ab551649924abca7b3cb95393038c0161d6a34a3de4ffd2a43788c7b3a08221f430b55eaa417386700eff018080\",\r\n                    \"solution\": \"0xff80ffff01ffff33ffa0f7bf0a56b4883b42f5999fd7237300b33a541f8b92be02868483d073506098e0ff8301869580ffff34ff0180ffff3cffa058a074f99002b5471ceef509c59729ab7dcdffbc3d387597bc67bfec6f81423480ffff3dffa01cabec2e124d3c7c4cca9bd5d25a98e0bdab66690db30185e0b6fe8f74a0f6838080ff8080\"\r\n                }\r\n            ]\r\n        },\r\n        \"to_address\": \"xch1vpasf9ftx97gr6eph2t07hmz4k6cvg0cn407vfq0d6pagw2enrzsey2rsa\",\r\n        \"to_puzzle_hash\": \"0x607b04952b317c81eb21ba96ff5f62adb58621f89d5fe6240f6e83d4395998c5\",\r\n        \"trade_id\": null,\r\n        \"type\": 1,\r\n        \"wallet_id\": 8\r\n    }\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DlUpdateRoot_RPC> helper = new Test_RPCClasses<DlUpdateRoot_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DlUpdateRoot_RPC> helper = new Test_RPCClasses<DlUpdateRoot_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DlUpdateRoot_Response> helper = new Test_ResponseClasses<DlUpdateRoot_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DlUpdateRoot_Response> helper = new Test_ResponseClasses<DlUpdateRoot_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}