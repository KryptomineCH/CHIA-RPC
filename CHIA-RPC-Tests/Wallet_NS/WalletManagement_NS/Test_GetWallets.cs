using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.WalletManagement_NS;
using CHIA_RPC.Wallet_NS.WalletNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.WalletManagement_NS
{
    public class Test_GetWallets
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"include_data\": false}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"fingerprint\": 874731676,\r\n    \"success\": true,\r\n    \"wallets\": [\r\n        {\r\n            \"data\": \"\",\r\n            \"id\": 1,\r\n            \"name\": \"Chia Wallet\",\r\n            \"type\": 0\r\n        }\r\n    ]\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<GetWallets_RPC> helper = new Test_RPCClasses<GetWallets_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<GetWallets_RPC> helper = new Test_RPCClasses<GetWallets_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetWallets_Response> helper = new Test_ResponseClasses<GetWallets_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetWallets_Response> helper = new Test_ResponseClasses<GetWallets_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
