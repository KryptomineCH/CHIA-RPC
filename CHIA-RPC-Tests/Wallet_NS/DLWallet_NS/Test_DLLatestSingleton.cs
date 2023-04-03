using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DLWallet_NS
{
    public class Test_DLLatestSingleton
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"launcher_id\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"singleton\": {\r\n        \"coin_id\": \"0xc2347b264b412bde5893f4e1369adab3a6c61496845c10f8ec98bc35f9e1429f\",\r\n        \"confirmed\": true,\r\n        \"confirmed_at_height\": 2871924,\r\n        \"generation\": 0,\r\n        \"inner_puzzle_hash\": \"0xd4580b76e486b061812848a710bd7d4116b34e2c56fc4357cf8ff4ca63106a84\",\r\n        \"launcher_id\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\",\r\n        \"lineage_proof\": {\r\n            \"amount\": 1,\r\n            \"inner_puzzle_hash\": \"0x481d9aabeccd0ab87526a980f6b3389465b6b21cb9255e30175b52114791cd91\",\r\n            \"parent_name\": \"0x4aecd65d5fd0dcac59ef41ad5a74134e38b3e8334aebb1356972b7e9c793a09e\"\r\n        },\r\n        \"root\": \"0x0000000000000000000000000000000000000000000000000000000000000000\",\r\n        \"timestamp\": 1669340887\r\n    },\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DlLatestSingleton_RPC> helper = new Test_RPCClasses<DlLatestSingleton_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DlLatestSingleton_RPC> helper = new Test_RPCClasses<DlLatestSingleton_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DlLatestSingleton_Response> helper = new Test_ResponseClasses<DlLatestSingleton_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DlLatestSingleton_Response> helper = new Test_ResponseClasses<DlLatestSingleton_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
