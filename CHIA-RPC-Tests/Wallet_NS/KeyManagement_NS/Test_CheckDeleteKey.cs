using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.KeyManagement;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.KeyManagement_NS
{
    public class Test_CheckDeleteKey
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"fingerprint\": 874731676, \"max_ph_to_search\": 200}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"fingerprint\": 874731676,\r\n    \"success\": true,\r\n    \"used_for_farmer_rewards\": false,\r\n    \"used_for_pool_rewards\": false,\r\n    \"wallet_balance\": false\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<CheckDeleteKey_RPC> helper = new Test_RPCClasses<CheckDeleteKey_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<CheckDeleteKey_RPC> helper = new Test_RPCClasses<CheckDeleteKey_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<CheckDeleteKey_Response> helper = new Test_ResponseClasses<CheckDeleteKey_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<CheckDeleteKey_Response> helper = new Test_ResponseClasses<CheckDeleteKey_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
