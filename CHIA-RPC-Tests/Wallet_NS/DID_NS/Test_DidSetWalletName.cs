using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.DID_NS;
using CHIA_RPC.Wallet_NS.WalletManagement_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.DID_NS
{
    public class Test_DidSetWalletName
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 3, \"name\": \"My DID Wallet\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true,\r\n  \"wallet_id\": 3\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DidSetWalletName_RPC> helper = new Test_RPCClasses<DidSetWalletName_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DidSetWalletName_RPC> helper = new Test_RPCClasses<DidSetWalletName_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<WalletID_Response> helper = new Test_ResponseClasses<WalletID_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<WalletID_Response> helper = new Test_ResponseClasses<WalletID_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
