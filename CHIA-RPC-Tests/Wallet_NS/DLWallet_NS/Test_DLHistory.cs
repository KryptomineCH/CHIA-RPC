using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DLWallet_NS
{
    public class Test_DLHistory
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"launcher_id\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"count\": 2,\r\n    \"history\": [\r\n        {\r\n            \"coin_id\": \"0x70e75ede3b9ba91ab4b91bc5efea8946fde60518becdce40e2cf6800ff173245\",\r\n            \"confirmed\": true,\r\n            \"confirmed_at_height\": 2872567,\r\n            \"generation\": 1,\r\n            \"inner_puzzle_hash\": \"0x607b04952b317c81eb21ba96ff5f62adb58621f89d5fe6240f6e83d4395998c5\",\r\n            \"launcher_id\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\",\r\n            \"lineage_proof\": {\r\n                \"amount\": 1,\r\n                \"inner_puzzle_hash\": \"0x60f66f9824d5f96d4025b70b4f7ac3def458cae742fbd2d70343eeeaa5a59c58\",\r\n                \"parent_name\": \"0xc2347b264b412bde5893f4e1369adab3a6c61496845c10f8ec98bc35f9e1429f\"\r\n            },\r\n            \"root\": \"0x0000000000000000000000000000000000000000000000000000000000000000\",\r\n            \"timestamp\": 1669352585\r\n        },\r\n        {\r\n            \"coin_id\": \"0xc2347b264b412bde5893f4e1369adab3a6c61496845c10f8ec98bc35f9e1429f\",\r\n            \"confirmed\": true,\r\n            \"confirmed_at_height\": 2871924,\r\n            \"generation\": 0,\r\n            \"inner_puzzle_hash\": \"0xd4580b76e486b061812848a710bd7d4116b34e2c56fc4357cf8ff4ca63106a84\",\r\n            \"launcher_id\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\",\r\n            \"lineage_proof\": {\r\n                \"amount\": 1,\r\n                \"inner_puzzle_hash\": \"0x481d9aabeccd0ab87526a980f6b3389465b6b21cb9255e30175b52114791cd91\",\r\n                \"parent_name\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\"\r\n            },\r\n            \"root\": \"0x0000000000000000000000000000000000000000000000000000000000000000\",\r\n            \"timestamp\": 1669340887\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DlHistory_RPC> helper = new Test_RPCClasses<DlHistory_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DlHistory_RPC> helper = new Test_RPCClasses<DlHistory_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DlHistory_Response> helper = new Test_ResponseClasses<DlHistory_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DlHistory_Response> helper = new Test_ResponseClasses<DlHistory_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
