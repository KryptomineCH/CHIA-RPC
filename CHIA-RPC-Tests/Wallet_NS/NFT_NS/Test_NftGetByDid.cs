using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.NFT_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.NFT_NS
{
    public class Test_NftGetByDid
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"did_id\": \"did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"wallet_id\": 5\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DidID_RPC> helper = new Test_RPCClasses<DidID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DidID_RPC> helper = new Test_RPCClasses<DidID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<WalletID_Response> helper = new Test_ResponseClasses<WalletID_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<WalletID_Response> helper = new Test_ResponseClasses<WalletID_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
