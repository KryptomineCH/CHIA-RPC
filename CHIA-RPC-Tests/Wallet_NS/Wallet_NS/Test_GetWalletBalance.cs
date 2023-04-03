using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_GetWalletBalance
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 1}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"wallet_balance\": {\r\n        \"confirmed_wallet_balance\": 999999799,\r\n        \"fingerprint\": 874731676,\r\n        \"max_send_amount\": 999999799,\r\n        \"pending_change\": 0,\r\n        \"pending_coin_removal_count\": 0,\r\n        \"spendable_balance\": 999999799,\r\n        \"unconfirmed_wallet_balance\": 999999799,\r\n        \"unspent_coin_count\": 1,\r\n        \"wallet_id\": 1,\r\n        \"wallet_type\": 0\r\n    }\r\n}"
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
            
            Test_ResponseClasses<GetWalletBalance_Response> helper = new Test_ResponseClasses<GetWalletBalance_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetWalletBalance_Response> helper = new Test_ResponseClasses<GetWalletBalance_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
