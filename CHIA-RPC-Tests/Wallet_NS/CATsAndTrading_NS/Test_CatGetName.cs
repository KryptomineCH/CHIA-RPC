using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.CATsAndTrading_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.CATsAndTrading_NS
{
    public class Test_CatGetName
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"wallet_id\": 2}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"name\": \"New CAT Wallet\",\r\n    \"success\": true,\r\n    \"wallet_id\": 2\r\n}"
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
            
            Test_ResponseClasses<CatAssetIdToName_Response> helper = new Test_ResponseClasses<CatAssetIdToName_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<CatAssetIdToName_Response> helper = new Test_ResponseClasses<CatAssetIdToName_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
