using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.PoolWallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.PoolWallet_NS
{
    public class Test_PwStatus
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 9}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"state\": {\r\n        \"current\": {\r\n            \"owner_pubkey\": \"0xa2c2a511421dcc4a88cb523f2c8784050687982c3b22deaee6b2ab0b409fe50660101079619d34f71214d00d650dd88f\",\r\n            \"pool_url\": \"\",\r\n            \"relative_lock_height\": 0,\r\n            \"state\": 1,\r\n            \"target_puzzle_hash\": \"0x7b1ede8172c025d85040db053aa1b03115daf3099acb302cc92cd545202137f2\",\r\n            \"version\": 1\r\n        },\r\n        \"current_inner\": \"0xff02ffff01ff02ffff01ff02ffff03ff82017fffff01ff04ffff04ff1cffff04ff5fff808080ffff04ffff04ff12ffff04ff8205ffffff04ff8206bfff80808080ffff04ffff04ff08ffff04ff17ffff04ffff02ff1effff04ff02ffff04ffff04ff8205ffffff04ff8202ffff808080ff80808080ff80808080ff80808080ffff01ff02ff16ffff04ff02ffff04ff05ffff04ff8204bfffff04ff8206bfffff04ff8202ffffff04ffff0bffff19ff2fffff18ffff019100ffffffffffffffffffffffffffffffffff8205ff8080ff0bff8202ff80ff808080808080808080ff0180ffff04ffff01ffff32ff3d52ffff333effff04ffff04ff12ffff04ff0bffff04ff17ff80808080ffff04ffff04ff12ffff04ff05ffff04ff2fff80808080ffff04ffff04ff1affff04ff5fff808080ffff04ffff04ff14ffff04ffff0bff5fffff012480ff808080ff8080808080ff02ffff03ffff07ff0580ffff01ff0bffff0102ffff02ff1effff04ff02ffff04ff09ff80808080ffff02ff1effff04ff02ffff04ff0dff8080808080ffff01ff0bffff0101ff058080ff0180ff018080ffff04ffff01a07b1ede8172c025d85040db053aa1b03115daf3099acb302cc92cd545202137f2ffff04ffff01a0d1a74bf2022d701bee11b17b30118ef16edd258493d16e710fbc984bffc17aa3ffff04ffff01b0a2c2a511421dcc4a88cb523f2c8784050687982c3b22deaee6b2ab0b409fe50660101079619d34f71214d00d650dd88fffff04ffff01a0ccd5bb71183532bff220ba46c268991a00000000000000000000000000000000ffff04ffff0180ff01808080808080\",\r\n        \"launcher_coin\": {\r\n            \"amount\": 1,\r\n            \"parent_coin_info\": \"0x0908243d25a95d27a254c46301ae954bf9aca2fe7a18673a3b29dc40401d2416\",\r\n            \"puzzle_hash\": \"0xeff07522495060c066f66f32acc2a77e3a3e737aca8baea4d1a64ea4cdc13da9\"\r\n        },\r\n        \"launcher_id\": \"0x5b2c9538a5388a47fa213cc71ce59f0f9de35be79b1459443e90506291060a2d\",\r\n        \"p2_singleton_puzzle_hash\": \"0xd1a74bf2022d701bee11b17b30118ef16edd258493d16e710fbc984bffc17aa3\",\r\n        \"singleton_block_height\": 2871654,\r\n        \"target\": null,\r\n        \"tip_singleton_coin_id\": \"0xa7c25e2640c6d009c8d7a02bd06eb103071b1572a23d24cccc5810bb01000160\"\r\n    },\r\n    \"success\": true,\r\n    \"unconfirmed_transactions\": []\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<PwStatus_Response> helper = new Test_ResponseClasses<PwStatus_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<PwStatus_Response> helper = new Test_ResponseClasses<PwStatus_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
