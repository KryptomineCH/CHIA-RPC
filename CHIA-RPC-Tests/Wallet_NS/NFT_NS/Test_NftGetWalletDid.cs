using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.NFT_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.NFT_NS
{
    public class Test_NftGetWalletDid
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 5}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"did_id\": \"did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5\",\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<WalletID_RPC> helper = new Test_RPCClasses<WalletID_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<DidID_Response> helper = new Test_ResponseClasses<DidID_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<DidID_Response> helper = new Test_ResponseClasses<DidID_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
