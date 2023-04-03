using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DLWallet_NS
{
    public class Test_DLOwnedSingletons
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"count\": 2,\r\n    \"singletons\": [\r\n        {\r\n            \"coin_id\": \"0x70e75ede3b9ba91ab4b91bc5efea8946fde60518becdce40e2cf6800ff173245\",\r\n            \"confirmed\": true,\r\n            \"confirmed_at_height\": 2872567,\r\n            \"generation\": 1,\r\n            \"inner_puzzle_hash\": \"0x607b04952b317c81eb21ba96ff5f62adb58621f89d5fe6240f6e83d4395998c5\",\r\n            \"launcher_id\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\",\r\n            \"lineage_proof\": {\r\n                \"amount\": 1,\r\n                \"inner_puzzle_hash\": \"0x60f66f9824d5f96d4025b70b4f7ac3def458cae742fbd2d70343eeeaa5a59c58\",\r\n                \"parent_name\": \"0xc2347b264b412bde5893f4e1369adab3a6c61496845c10f8ec98bc35f9e1429f\"\r\n            },\r\n            \"root\": \"0x0000000000000000000000000000000000000000000000000000000000000000\",\r\n            \"timestamp\": 1669352585\r\n        },\r\n        {\r\n            \"coin_id\": \"0xf9b3b8302919b4adb12a8d3914ed512cbbfed8bfadcf6e6b0e888c9533db5fab\",\r\n            \"confirmed\": true,\r\n            \"confirmed_at_height\": 2871913,\r\n            \"generation\": 0,\r\n            \"inner_puzzle_hash\": \"0x5dd62b0a1883fe7565cc243c830940b541ed219c8a373f50f3cd00e003663fa9\",\r\n            \"launcher_id\": \"0xba934d7f4ad47c34cb1a99d3c57adacb1883cff5528cca67c34f724f3560e401\",\r\n            \"lineage_proof\": {\r\n                \"amount\": 1,\r\n                \"inner_puzzle_hash\": \"0xd9d049c23a9eea8ddfcc47971479574b5f3c7da9bb7d34f24365a82c944e270e\",\r\n                \"parent_name\": \"0xba934d7f4ad47c34cb1a99d3c57adacb1883cff5528cca67c34f724f3560e401\"\r\n            },\r\n            \"root\": \"0x0000000000000000000000000000000000000000000000000000000000000000\",\r\n            \"timestamp\": 1669340703\r\n        }\r\n    ],\r\n    \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DlOwnedSingletons_Response> helper = new Test_ResponseClasses<DlOwnedSingletons_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DlOwnedSingletons_Response> helper = new Test_ResponseClasses<DlOwnedSingletons_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
